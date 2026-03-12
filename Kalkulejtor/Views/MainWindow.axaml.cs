using Avalonia.Controls;
using Avalonia.Interactivity;
using Kalkulatorek;

namespace Kalkulejtor.Views;

public partial class MainWindow : Window
{
    private readonly Kalkulator kalkulator = new Kalkulator();

    public MainWindow()
    {
        InitializeComponent();
    }

    private int PobierzLiczbe1()
    {
        return int.Parse(Liczba1.Text!);
    }

    private int PobierzLiczbe2()
    {
        return int.Parse(Liczba2.Text!);
    }

    private void Dodaj_Click(object? sender, RoutedEventArgs e)
    {
        WynikTekst.Text = "Wynik: " + kalkulator.Dodawanie(PobierzLiczbe1(), PobierzLiczbe2());
    }

    private void Odejmij_Click(object? sender, RoutedEventArgs e)
    {
        WynikTekst.Text = "Wynik: " + kalkulator.Odejmowanie(PobierzLiczbe1(), PobierzLiczbe2());
    }

    private void Pomnoz_Click(object? sender, RoutedEventArgs e)
    {
        WynikTekst.Text = "Wynik: " + kalkulator.Mnozenie(PobierzLiczbe1(), PobierzLiczbe2());
    }

    private void Podziel_Click(object? sender, RoutedEventArgs e)
    {
        WynikTekst.Text = "Wynik: " + kalkulator.Dzielenie(PobierzLiczbe1(), PobierzLiczbe2());
    }
}