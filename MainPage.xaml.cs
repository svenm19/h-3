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
        return false;
    }

    private void b_information_Clicked(object sender, EventArgs e)
    {

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


    }

    private void b_ausgeben_Clicked(object sender, EventArgs e)
    {

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

