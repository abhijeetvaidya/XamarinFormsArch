using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;
using XamarinFormsArch.Classes;
using XamarinFormsArch.Classes.Network;
using XamarinFormsArch.Classes.Registeration;
using static XamarinFormsArch.Classes.DoIEx;

namespace XamarinFormsArch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NetworkApi api = RestService.For<NetworkApi>(AppConstants.BASE_URL);

            RegisterModel model = new RegisterModel();
            model.email = "x1x212w3@gmail.com";
            model.password = "123123";
            model.confirm_password = "123123";
            model.first_name = "Dummy Name";
            model.last_name = "Last Name";
            model.gender = "M";
            model.phone_no = 123;

            try
            {
                //CustBusinessLogin custBusinessLogin = new CustBusinessLogin();
                CustService service = new CustService();
                var DoIVal = service.GetCustomerName(); 
                //var DoIVal = custBusinessLogin.GetCustName();

                /*var regResponse = api.Register(model);
                regResponse.ContinueWith(post => {
                    if (post.IsCompleted)
                    {
                        var demo = post.Result;
                    }
                    else if (post.IsFaulted)
                    {
                        Debug.WriteLine("Error occured ->" + post.Status);
                    }
                    else
                    {
                        Debug.WriteLine("Cancelled");
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext()).ConfigureAwait(false);*/
            }
            catch (Exception ex){
                Debug.WriteLine("Error--->>"+ex.StackTrace);
            }

        }
    }
}
