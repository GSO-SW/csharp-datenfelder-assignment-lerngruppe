// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Datenfelder
/// Arbeitsauftrag 1 - Aufgabe 3
/// Notentabelle
/// </summary>


Aufgabe_33.Aufgabe33();

public static class Aufgabe_33
{
    public static void Aufgabe33()
    {
        // Deklarieren und Initialisieren einer Variablen zum Zählen der Anzahl der Durchläufe
        int counter = 0;

        // Titel des Programms
        Console.WriteLine("-----Notenliste-----");

        // Den Benutzer auffordern, die Anzahl der Schüler einzugeben
        Console.WriteLine("Bitte geben Sie die Anzahl der Lernenden ein:");


        // Die Eingabe des Benutzers als String
        string anzahl_lernende_str = Console.ReadLine();

        // Der String wird in eine Ganzzahl konvertiert
        int anzahl_schueler_int = Convert.ToInt32(anzahl_lernende_str);

        // Variablen für die Noten der lernenden deklarieren





        // Eine Schleife durchlaufen, um die Noten der Schüler einzugeben
        do
        {

            // Den Benutzer auffordern, die Note des ersten Schülers einzugeben
            Console.WriteLine("Bitte geben Sie die Note des Lernenden an:");




            // Den Zähler erhöhen
            counter++;
        } while (counter < anzahl_schueler_int);

    }
}