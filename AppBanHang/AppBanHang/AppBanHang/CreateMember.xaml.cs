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
	public partial class CreateMember : ContentPage
	{
		public CreateMember ()
		{
			InitializeComponent ();
		}
        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var time = dtpicker.Date;
            var nameber = name.Text;
            var pass = password.Text;
            var phone = number.Text;
            var mail = email.Text;
            details.Text = string.Format("Member name: {0} \n Password: {1} \n Brith: {2} \n Phone:{3} \n Email:{4}", nameber, pass, time, phone, mail);


        }
    }
}