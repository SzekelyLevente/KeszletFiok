namespace KeszletFiok.views;

public partial class Account : ContentPage
{
	private IRepository repository;
	private Ilogic logic;

	private int max = 24;
    private int maxPerPage = 2;
	private Storage[] storages;
	public Account()
	{
		InitializeComponent();
		repository = new Repository();
		logic = new Logic(repository);
        createStorages(logic.Read("firstStorage"));
        imagePager.ItemsSource = storages;
	}

	public void createStorages(String first)
	{
		String withoutCode = first.Substring(6, 6);
        String code=first.Substring(0, 6);
		int afterDot = int.Parse(withoutCode.Substring(5,1));
		int column = int.Parse(withoutCode.Substring(0, 3));
		int row = int.Parse(withoutCode.Substring(3, 2));
		storages = new Storage[max/2];
        String storageS;
        QR qr;
        QR[] qr2=new QR[2];
		for (int i = 0; i < max; i++)
		{
            storageS = code + "00" + column + "0" + row + "" + afterDot;
            qr = new QR(storageS);
            qr2[i % 2] = qr;
            afterDot = afterDotSubstract(afterDot);
            column++;
            if (i % 4 == 3)
            {
                row += 2;
                column = 1;
                afterDot = afterDotPlus(afterDot);
            }
            if(i%2==1)
            {
                Storage storage = new Storage(qr2[0].Path, qr2[0].Text, qr2[1].Path, qr2[1].Text);
                storages[i/2] = storage;
            }
        }
    }

    public int afterDotSubstract(int afterDot)
    {
        int result = afterDot -= 3;
        if (result < 0)
        {
            result += 10;
        }
        return result;
    }

    public int afterDotPlus(int afterDot)
    {
        int result = afterDot += 6;
        if (result > 9)
        {
            result -= 10;
        }
        return result;
    }
}