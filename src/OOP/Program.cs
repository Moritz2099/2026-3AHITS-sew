// ------------------------------
// OOP
// ------------------------------

namespace OOP;

class Schule
{
    public string name; //member variable oder feld
    public int anzahlSchueler;
    public int anzahlLehrer;
    // non static methode
    public int AnzahlPersonen()
    {
        return anzahlSchueler + anzahlLehrer;
    }

    // ToString() methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahlSchueler}, Lehrer: {anzahlLehrer}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schule htl =new Schule(); //Objekt erstellen (instanzieren)
        htl.name="HTL Braunau"; // member Variable setzten
        htl.anzahlSchueler= 800;
        htl.anzahlLehrer=100;
    
        Console.WriteLine($"Gesamte Anzahl der Personen: {htl.AnzahlPersonen()}");

        // HLW
        Schule hlw = new Schule();
        hlw.name="HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer =80;



        int n=42;
        Console.WriteLine(n);
        Console.WriteLine(htl);
        Console.WriteLine(htl.ToString());


        
    }

}
