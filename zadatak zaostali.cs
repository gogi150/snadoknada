using System;

class Stablo
{
    private bool otpadajuListovi;
    private string vrstaStabla;

    public bool OtpadajuListovi
    {
        get { return otpadajuListovi; }
        set { otpadajuListovi = value; }
    }

    public Stablo(bool otpadajuListovi)
    {
        this.otpadajuListovi = otpadajuListovi;
    }

    public override string ToString()
    {
        if (otpadajuListovi)
        {
            vrstaStabla = "bijelogorično";
        }
        else
        {
            vrstaStabla = "crnogorično";
        }
        return "Vrsta stabla: {vrstaStabla}";
    }
}

class Program
{
    public static void Main()
    {
        Stablo stablo1 = new Stablo(false);
        Stablo stablo2 = new Stablo(true);

        Console.WriteLine(stablo1.ToString());
        Console.WriteLine(stablo2.ToString());
    }
}