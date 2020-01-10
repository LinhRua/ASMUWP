using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using T1809E_UWP_CXL_ASM.Utils;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E_UWP_CXL_ASM.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class Login : Page
    {
        private readonly Validator validator = new Validator();

        public Login()
        {
            this.InitializeComponent();
        }

        private async void LoginHanlde(object sender, RoutedEventArgs e)
        {
            if (validator.IsEmail(email.Text))
            {
                emailAlert.Text = "";
                if (validator.IsNotNullAndNotEmpty(password.Password)){
                    passwordAlert.Text = "";
                    //Next
                }
                else
                {
                    passwordAlert.Text = "Please enter password";
                }
            }
            else
            {
                var content = new LoginNTT
                {
                    email = email.Text,
                    password = password.Password
                };
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(content);
                var para = new StringContent(json, Encoding.UTF8, "application/json");
                var response =
                    await httpClient.PostAsync(
                        "https://2-dot-backup-server-002.appspot.com/_api/v2/members/authentication",
                        para);
                var resp = await response.Content.ReadAsStringAsync();
                LoginTk member = JsonConvert.DeserializeObject<LoginTk>(resp);

                var Url = Path.Combine(
                    "C://Users//LinhRua//source//repos//T1809E_UWP_CXL_ASM//T1809E_UWP_CXL_ASM//Assets//token.txt");
                System.IO.File.WriteAllText(Url, member.token.ToString());
            }

            {
            emailAlert.Text = "Inlavid email, please enter valid email format.";
        }
    }
        public class LoginNTT
    {
        public string email { get; set; }
        public string password { get; set; }
    }
        public class LoginTk
        {
            public string token { get; set; }
            public string secretToken { get; set; }

        }
    }
}