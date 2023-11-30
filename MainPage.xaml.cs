using Containertool.Klassen;

namespace Containertool;

public partial class MainPage : ContentPage
{
    private int numberOfColumns = 5;
    private int numberOfRows = 3;
    private Container[,] container = new Container[5,3];

	public MainPage()
	{
		InitializeComponent();
	}

    private bool ContainerBurgErstellbar(Container[,] containers)
    {
        //Methode ergänzen siehe Aufgabe 4 (d)
    }

    //weitere Methoden ergänzen gemäß Aufgabenstellung
    

    private void b_ausgeben_Clicked(object sender, EventArgs e)
    {
        ContainerBurgErstellbar(container);

        for (int i = 0; i < g_Grid.Children.Count; i++)
        {
            if (g_Grid.Children[i] is Image)
            {
                g_Grid.Children.Remove((Image)g_Grid.Children[i]);
                i--;
            }
        }
        for (int i = 0; i < numberOfColumns; i++)
        {
            for (int j = 0; j < numberOfRows; j++)
            {
                if (container[i, j] != null)
                {
                    Image img = new Image();
                    g_Grid.Add(img,i,numberOfRows-1-j);
                    if (container[i, j] is Büro)
                    {
                        img.Source = "buero.png";
                    }
                    if (container[i, j] is Umkleide)
                    {
                        img.Source = "umkleide.png";
                    }
                    if (container[i, j] is Toilette)
                    {
                        img.Source = "toilette.png";
                    }
                    if (container[i, j] is Magazin)
                    {
                        img.Source = "magazin.png";
                    }
                    if (container[i, j] is Pausenraum)
                    {
                        img.Source = "pausenraum.png";
                    }
                }
            }
        }
        cp_contentpage.ForceLayout(); //!
    }
}

