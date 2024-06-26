namespace KeszletFiok.views;

public partial class Print : ContentPage
{
	private IRepository repository;
	private Ilogic logic;
	public Print()
	{
		InitializeComponent();
		repository = new Repository();
		logic = new Logic(repository);
		check();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
		if(inputPrint.Text!=null)
		{
			logic.Update("print", inputPrint.Text);
			setPrint(inputPrint.Text);
			inputPrint.Text = null;
		}
    }

	public void check()
	{
		if(logic.Contains("print"))
		{
			setPrint(logic.Read("print"));
		}
	}

	public void setPrint(String text)
	{
		QR qr=new QR(text);
		qrPrint.Source = qr.Path;
		lblPrint.Text = text;
	}
}