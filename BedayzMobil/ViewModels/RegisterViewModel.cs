using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using BedayzMobil.Services;
using Xamarin.Forms;

namespace BedayzMobil.ViewModels
{
    public class RegisterViewModel
    {
        RestAPIForAccounts restAPIForAccounts = new RestAPIForAccounts();
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //var isSuccess = await restAPIForAccounts.Register(Email, 
                    //   Password, Name, LastName, UserName);
                    //if (isSuccess)
                    Message = "Kayıt başarılı!";
                    //else
                    //  Message = "Kayıt başarısız, lütfen tekrar deneyin! ";
                });
            }
        }

    }
}
