using System;
using System.Collections.Generic;

namespace Menu
{
    internal class Program
    {
        static float totale = 0;
        static List<string> ordine = new List<string>();

        static void ShowMenu()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1: Coca Cola 150 ml  2.50 Euro");
            Console.WriteLine("2: Insalata di pollo  5.20 Euro");
            Console.WriteLine("3: Pizza Margherita 10.00 Euro");
            Console.WriteLine("4: Pizza 4 Formaggi  12.50 Euro");
            Console.WriteLine("5: Patatine fritte  3.50 Euro");
            Console.WriteLine("6: Insalata di riso  8.00 Euro");
            Console.WriteLine("7: Frutta di stagione  5.00 Euro");
            Console.WriteLine("8: Pizza fritta  5.00 Euro");
            Console.WriteLine("9: Piadina vegetariana  6.00 Euro");
            Console.WriteLine("10: Panino Hamburger  7.90 Euro");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Cosa vorresti mangiare?");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                switch (value)
                {
                    case 1:
                        totale += 2.50f;
                        ordine.Add("Coca Cola 150 ml 2.50 Euro");
                        Console.WriteLine("Hai selezionato: Coca Cola 150 ml 2.50 Euro");
                        break;
                    case 2:
                        totale += 5.20f;
                        ordine.Add("Insalata di pollo  5.20 Euro");
                        Console.WriteLine("Hai selezionato: Insalata di pollo 5.20 Euro");
                        break;
                    case 3:
                        totale += 10.00f;
                        ordine.Add("Pizza Margherita  10.00 Euro");
                        Console.WriteLine("Hai selezionato: Pizza Margherita 10.00 Euro");
                        break;
                    case 4:
                        totale += 12.50f;
                        ordine.Add("Pizza 4 Formaggi  12.50 Euro");
                        Console.WriteLine("Hai selezionato: Pizza 4 Formaggi  12.50 Euro");
                        break;
                    case 5:
                        totale += 3.50f;
                        ordine.Add("Pz patatine fritte  3.50 Euro");
                        Console.WriteLine("Hai selezionato:  patatine fritte  3.50 Euro");
                        break;
                    case 6:
                        totale += 8.00f;
                        ordine.Add("Insalata di riso  8.00 Euro");
                        Console.WriteLine("Hai selezionato: Insalata di riso 8.00 Euro");
                        break;
                    case 7:
                        totale += 5.00f;
                        ordine.Add("Frutta di stagione 5.00 Euro");
                        Console.WriteLine("Hai selezionato: Frutta di stagione 5.00 Euro");
                        break;
                    case 8:
                        totale += 5.00f;
                        ordine.Add("Pizza fritta 5.00 Euro");
                        Console.WriteLine("Hai selezionato: Pizza fritta 5.00 Euro");
                        break;
                    case 9:
                        totale += 6.00f;
                        ordine.Add("Piadina vegetariana  6.00 Euro");
                        Console.WriteLine("Hai selezionato: Piadina vegetariana  6.00 Euro");
                        break;
                    case 10:
                        totale += 7.90f;
                        ordine.Add("Panino Hamburger  7.90 Euro");
                        Console.WriteLine("Hai selezionato: Panino Hamburger  7.90 Euro");
                        break;
                    case 11:
                        Conto();
                        return;
                    default:
                        Console.WriteLine("Valore non riconosciuto, prego riprovare.");
                        Menu();
                        break;
                }
                Menu();
            }
            else
            {
                Console.WriteLine("Inserimento non valido, prego riprovare.");
                Menu();
            }
        }

        static void Conto()
        {
            Console.WriteLine("Hai ordinato i seguenti piatti:");
            foreach (var piatto in ordine)
            {
                Console.WriteLine(piatto);
            }
            Console.WriteLine($"Totale: {totale} Euro ");

        }

        static void Main(string[] args)
        {
            ShowMenu();
            Console.ReadKey();
        }
    }
}