using KeszletFiok.views;
using System.Reflection;

namespace KeszletFiok
{
    public partial class MainPage : ContentPage
    {
        private IRepository repository;
        private Ilogic logic;
        private String account, firstStorage, code;

        private void btnAccount_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(Account));
        }

        private void btnSettings_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(Settings));
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            check();
        }

        private void btnPrint_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(Print));
        }

        public MainPage()
        {
            InitializeComponent();
            repository = new Repository();
            logic = new Logic(repository);
        }

        public void check()
        {
            if (logic.Contains("account") && logic.Contains("firstStorage"))
            {
                account = repository.Read("account");
                firstStorage = repository.Read("firstStorage");
                code = account.Substring(7, 4);
                QR qrW = new QR("W"+code);
                QR qrR = new QR("R" + code);
                QR qrAccount = new QR(account);
                qrw.Source = qrW.Path;
                qrr.Source = qrR.Path;
                qrAcc.Source = qrAccount.Path;
                lblw.Text=qrW.Text;
                lblr.Text=qrR.Text;
                lblacc.Text = qrAccount.Text;
            }
        }
    }

}
