using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using Crypta_2._0.Models;
using Crypta_2._0.Views;
using FinanceTracker.Models;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Speech.Synthesis;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FinanceTracker
{
    public partial class MainPage : ContentPage
    {
        EncryptionService encryptionService;

        Money money = new Money();
        public MainPage()
        {
            InitializeComponent();

            Initialize();
        }

        private async Task Initialize()
        {
            string inputPassword = null;

            if(!File.Exists("transactions.txt"))
            {
                inputPassword = await RequestNewPasswordForList();
            }
            else
            {
                inputPassword = await RequestPassword();
                if (inputPassword == null)
                {
                    Debug.WriteLine("Password was null, aborting load");
                    return;
                }
            }

            encryptionService = new EncryptionService(inputPassword);

            string importString = File.ReadAllText("transactions.txt");
            string decryptedJson = null;
            try
            {
                decryptedJson = encryptionService.Decrypt(importString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error decrypting transactions: {ex.Message}");
                await DisplayAlert("Error", "Failed to decrypt transactions. Please check your password.", "OK");
                await Initialize();
                return;
            }

            money = JsonSerializer.Deserialize<Money>(decryptedJson) ?? new Money();

        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            string initialJson = JsonSerializer.Serialize(money);
            string encryptedJson = encryptionService.Encrypt(initialJson);
            File.WriteAllText("transactions.txt", encryptedJson);
        }

        private void NewTransaction_Clicked(object sender, EventArgs e)
        {

        }

        private void NewTransaction_Done()
        {

        }

        private async Task<string> RequestPassword()
        {
            var popup = new PasswordPopup();

            var result = await this.ShowPopupAsync<string>(
                popup,
                PopupOptions.Empty,
                CancellationToken.None);

            if (result == null || string.IsNullOrEmpty(result.Result)) return null;


            return result.Result;
        }

        private async Task<string> RequestNewPasswordForList()
        {
            var popup = new NewPasswordListPopup();

            var result = await this.ShowPopupAsync<string>(
                popup,
                PopupOptions.Empty,
                CancellationToken.None);

            if (result == null || string.IsNullOrEmpty(result.Result)) return null;


            return result.Result;
        }
    }
}
