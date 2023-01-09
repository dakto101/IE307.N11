using IE307.N11.Models;
using IE307.N11.Services;
using IE307.N11.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
   public  class LoginViewModel
    {

        public ICommand Cmd_LogIn { get; set; }
        public ICommand Cmd_LogOut { get; set; }
        public ICommand Cmd_SignUp { get; set; }
        public ICommand Cmd_SignUp_SignUp { get; set; }
        public ICommand Cmd_ResetPassword { get; set; }
        public ICommand Cmd_ResetPassword_SendEmail { get; set; }
        public ICommand Cmd_ResetPassword_Verify { get; set; }
        public LoginViewModel()
        {
            // Tạm thời set thành true
            Cmd_LogIn = new Command(async o =>
            {
                LoginPage logInPage = o as LoginPage;
                String email = (logInPage.FindByName("Entry_Email") as Entry).Text;
                String password = (logInPage.FindByName("Entry_Password") as Entry).Text;
                // Check email và password
                if (email == null || email.Length == 0)
                {
                    await Shell.Current.DisplayAlert("Warning", "Email address is required!", "OK");
                    return;
                }
                if (password == null || password.Length == 0)
                {
                    await Shell.Current.DisplayAlert("Warning", "Password is required!", "OK");
                    return;
                }

                if (email.Equals("admin") && password.Equals("123456")) SettingsService.SetValue("ankidroid_account", true);
                else SettingsService.SetValue("ankidroid_account", false);
                //

                if (SettingsService.GetValue("ankidroid_account").Equals(true))
                {
                    await Shell.Current.DisplayAlert("Info", "Log in successfully!", "OK");

                    await Shell.Current.Navigation.PushAsync(new LoginPage_Logout());
                    Shell.Current.Navigation.RemovePage(logInPage);
                }
                else
                {
                    await Shell .Current.DisplayAlert("Info", "Invalid email address or password", "OK");
                }

            });
            Cmd_LogOut = new Command(async o =>
            {
                SettingsService.SetValue("ankidroid_account", false);
                await Shell.Current.DisplayAlert("Info", "Log out successfully!", "OK");
                await Shell.Current.Navigation.PopAsync();
            });
            Cmd_SignUp = new Command(async o =>
            {
                await Shell.Current.Navigation.PushAsync(new LoginPage_SignUp());
            });
            Cmd_SignUp_SignUp = new Command(async o =>
            {
                await Shell.Current.DisplayAlert("Info", "Sign up successfully.", "OK");
                DatabaseService.DBTest();
            });
            Cmd_ResetPassword = new Command(async o =>
            {
                await Shell.Current.Navigation.PushAsync(new LoginPage_ResetPassword());
            });
            Cmd_ResetPassword_SendEmail = new Command(async o =>
            {
                LoginPage_ResetPassword page = (LoginPage_ResetPassword) o;
                String email = (page.FindByName("Email") as Entry).Text;
                if (email == null || !email.Contains(".") || !email.Contains("@"))
                {
                    await Shell.Current.DisplayAlert("Info", "Invalid email.", "OK");
                    return;
                }
                // Send email
                try
                {
                    /*
                    EmailService.SendEmail("Someone has requested that your password be reset. <br>" +
                        "<h1>Your code is 111111.</h1><br>" +
                        "This code will expire in 15 minutes.", "[AnkiDroid] Password reset", email);
                    */
                }
                catch (Exception)
                {
                    await Shell.Current.DisplayAlert("Info", "Unable to send verification email. Please try again.", "OK");
                }
                finally
                {
                    await Shell.Current.DisplayAlert("Info", "We've sent you an email with a code to reset your password.", "OK");
                    await Shell.Current.Navigation.PushAsync(new LoginPage_ResetPassword_Verify());
                }
            });
            Cmd_ResetPassword_Verify = new Command(async o =>
            {
                if (!(o is LoginPage_ResetPassword_Verify)) return;
                LoginPage_ResetPassword_Verify page = o as LoginPage_ResetPassword_Verify;

                Entry code = page.FindByName("Entry_Code") as Entry;
                Entry newpassword0 = page.FindByName("Entry_NewPassword0") as Entry;
                Entry newpassword1 = page.FindByName("Entry_NewPassword1") as Entry;

                if (code.Text == null) await Shell.Current.CurrentPage.DisplayAlert("Info", "Please enter the code.", "OK");
                if (newpassword0.Text == null) await Shell.Current.CurrentPage.DisplayAlert("Info", "Please enter the password.", "OK");
                if (newpassword1.Text == null) await Shell.Current.CurrentPage.DisplayAlert("Info", "Please re-enter the password.", "OK");
                if (newpassword0.Text != newpassword1.Text) await Shell.Current.CurrentPage.DisplayAlert("Info", "You must re-enter the same password.", "OK");


                await Shell.Current.CurrentPage.DisplayAlert("Info", "Your password has been changed successfully.", "OK");
            });
        
        }

    }
}
