using Hausuebung_03.Klassen;

namespace Hausuebung_03;

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
        e_fehlermeldung.Text = "";
        bool empty = false;
        for (int i = 0; i < numberOfColumns; i++)
        {
            for (int j = 0; j < numberOfRows; j++)
            {
                if (container[i, j] == null)
                {
                    empty = true;
                }
                if (container[i, j] != null && empty)
                {
                    e_fehlermeldung.Text = "Container schweben!";
                    return false;
                }
            }
            empty = false;
        }
        return true;
    }

    private void b_information_Clicked(object sender, EventArgs e)
    {
        string containerInfo = "";
        for (int i = 0; i < numberOfColumns; i++)
        {
            for (int j = 0; j < numberOfRows; j++)
            {
                if (container[i, j] != null)
                {
                    containerInfo += container[i, j].ToString() + "\n\n";
                }
            }
        }
        e_information.Text = containerInfo;
    }

    private void b_hinzufuegen_Clicked(object sender, EventArgs e)
    {
        int xValue = 0;
        int yValue = 0;
        int entry1 = 0;
        int entry2 = 0;

        try
        {
            xValue = int.Parse(e_x.Text);
            yValue = int.Parse(e_y.Text);
            entry1 = int.Parse(e_1.Text);
            entry2 = int.Parse(e_2.Text);
        }
        catch { }

        if (rb_buero.IsChecked)
        {
            Büro büro = new Büro(xValue, yValue, entry1);
            container[xValue, yValue] = büro;
        }
        else if (rb_magazin.IsChecked)
        {
            Magazin magazin = new Magazin(xValue, yValue, entry1);
            container[xValue, yValue] = magazin;
        }
        else if (rb_pausenraum.IsChecked)
        {
            Pausenraum pausenraum = new Pausenraum(xValue, yValue, entry1, entry2);
            container[xValue, yValue] = pausenraum;
        }
        else if (rb_toilette.IsChecked)
        {
            Toilette toilette = new Toilette(xValue, yValue, entry1);
            container[xValue, yValue] = toilette;
        }
        else if (rb_umkleide.IsChecked)
        {
            Umkleide umkleide = new Umkleide(xValue, yValue, entry1, entry2);
            container[xValue, yValue] = umkleide;
        }
        else
        {
            e_fehlermeldung.Text = "Bitte wählen Sie einen Container aus!";
        }


    }

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
                    g_Grid.Children.Add(img);
                    Grid.SetColumn(img, i);
                    Grid.SetRow(img, (numberOfRows - 1) - j);
                    if (container[i, j] is Büro)
                    {
                        img.Source = "/Images/B.png";
                    }
                    if (container[i, j] is Umkleide)
                    {
                        img.Source = "/Images/Umkleide.png";
                    }
                    if (container[i, j] is Toilette)
                    {
                        img.Source = "/Images/Toilette.png";
                    }
                    if (container[i, j] is Magazin)
                    {
                        img.Source = "/Images/Magazin.png";
                    }
                    if (container[i, j] is Pausenraum)
                    {
                        img.Source = "/Images/Pausenraum.png";
                    }
                }
            }
        }
    }

    private void rb_buero_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        l_1.IsVisible = true;
        l_1.Text = "Bitte geben Sie die Anzahl an Computern ein:";
        e_1.IsVisible = true;
        e_1.IsEnabled = true;
        l_2.IsVisible = false;
        e_2.IsVisible = false;
        e_2.IsEnabled = false;
    }

    private void rb_umkleide_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        l_1.IsVisible = true;
        l_1.Text = "Bitte geben Sie die Anzahl an Sitzplätzen ein:";
        e_1.IsVisible = true;
        e_1.IsEnabled = true;
        l_2.IsVisible = true;
        l_2.Text = "Bitte geben sie die Anzahl an Schließfähern ein:";
        e_2.IsVisible = true;
        e_2.IsEnabled = true;
    }

    private void rb_toilette_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        l_1.IsVisible = true;
        l_1.Text = "Bitte geben Sie die Anzahl an Toiletten ein:";
        e_1.IsVisible = true;
        e_1.IsEnabled = true;
        l_2.IsVisible = false;
        e_2.IsVisible = false;
        e_2.IsEnabled = false;
    }

    private void rb_magazin_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        l_1.IsVisible = true;
        l_1.Text = "Bitte geben Sie die Anzahl an Artikeln ein:";
        e_1.IsVisible = true;
        e_1.IsEnabled = true;
        l_2.IsVisible = false;
        e_2.IsVisible = false;
        e_2.IsEnabled = false;
    }

    private void rb_pausenraum_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        l_1.IsVisible = true;
        l_1.Text = "Bitte geben Sie die Anzahl an Zeitschriften ein:";
        e_1.IsVisible = true;
        e_1.IsEnabled = true;
        l_2.IsVisible = true;
        l_2.Text = "Bitte geben sie die Anzahl an Sitzplätzen ein:";
        e_2.IsVisible = true;
        e_2.IsEnabled = true;
    }
}

