using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBanHang
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        private void BtnLogin(object sender, EventArgs e)
        {
            DisplayAlert("Messege", "Login success", "Ok");
            Navigation.PushAsync(new HomePage(usernameentry.Text));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateMember());
        }
    }
}