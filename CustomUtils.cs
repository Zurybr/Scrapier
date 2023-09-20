namespace wb;

public static class CustomUtils
{
    public static string GetMotor()
    {
        List<string> Motores = new List<string>
        {
            "Chrome",
            "Edge",
            "Firefox",
            "Safari",
        };
        int currentIndex = 0;
        string selectedMotor= string.Empty;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione el motor para abrir el navegador:");
            for (int i = 0; i < Motores.Count; i++)
            {
                if (i == currentIndex)
                {
                    Console.Write(">> ");
                }
                else
                {
                    Console.Write("   ");
                }
        
                Console.WriteLine(Motores[i]);
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                currentIndex = Math.Max(0, currentIndex - 1);
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                currentIndex = Math.Min(Motores.Count - 1, currentIndex + 1);
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                selectedMotor = Motores[currentIndex];
                break;
            }
        }
        return selectedMotor;
    }
    public static string GetUrls()
    {
        List<string> urls = new List<string>
        {
            "https://www.amazon.com.mx/",
        };
        
        int currentIndex = 0;
        string selectedUrl = string.Empty;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una URL utilizando las flechas arriba y abajo y presione Enter para abrir:");
            for (int i = 0; i < urls.Count; i++)
            {
                if (i == currentIndex)
                {
                    Console.Write(">> ");
                }
                else
                {
                    Console.Write("   ");
                }
        
                Console.WriteLine(urls[i]);
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                currentIndex = Math.Max(0, currentIndex - 1);
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                currentIndex = Math.Min(urls.Count - 1, currentIndex + 1);
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                selectedUrl = urls[currentIndex];
                break;
            }
        }

        if (selectedUrl == "Custom")
        {
            Console.WriteLine("Ingresa la Url:");
            selectedUrl= Console.ReadLine();
        }
        return selectedUrl;
    }

    public static List<string> GetItems()
    {
        Console.Write("Ingrese terminos a buscar : ");
        List<string> itemsSearch = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break; 
            }
            Console.Write("Ingrese Otro termino a buscar si acabo presione enter: ");
            itemsSearch.Add(input);
        }

        return itemsSearch;
    }
   
}