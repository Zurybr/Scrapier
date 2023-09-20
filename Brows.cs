using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;
public class Brows
{
    public IWebDriver driver;
    public Brows(string url,string selectedMotor)
    {
        switch (selectedMotor.ToLower())
        {
            case "chrome":
                driver = new ChromeDriver();
                break;
            case "edge":
                driver = new EdgeDriver();
                break;
            case "firefox":
                driver = new FirefoxDriver();
                break;
            case "safari":
                driver = new SafariDriver();
                break;
            default:
                driver = new ChromeDriver();
                break;
        }
        driver.Navigate().GoToUrl(url);
    }
    public List<Producto> Start( string item)
    {
        List<Producto> products = new List<Producto>();
        
        System.Threading.Thread.Sleep(10000);
        
        IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
        searchBox.Clear();
        searchBox.SendKeys(item + Keys.Enter);
        System.Threading.Thread.Sleep(2000);

        string currentUrl = driver.Url;
        Console.WriteLine("URL de la página actual: " + currentUrl);

        bool hasNextPage = true;
        int pageNumber = 1;
        while (hasNextPage)
        {
            var elementsWithAttributes = driver.FindElements(By.CssSelector("div[data-asin][data-uuid]"));
            foreach (var element in elementsWithAttributes)
            {
                Producto p = new Producto();

                try
                {
                    IWebElement Vendedor = element.FindElement(By.CssSelector("h2.a-size-mini.s-line-clamp-1"));
                    p.Vendedor = Vendedor.Text;
                    IWebElement Description = element.FindElement(By.CssSelector("h2.a-size-mini.a-spacing-none.a-color-base.s-line-clamp-2"));
                    p.Descripcion = Description.Text;
                    IWebElement precioElement = element.FindElement(By.CssSelector("span.a-price span.a-price-whole"));
                    IWebElement precioDecimalElement = element.FindElement(By.CssSelector("span.a-price span.a-price-fraction"));
                    p.Precio = precioElement.Text + "." +precioDecimalElement.Text;

                    IWebElement elemento = element.FindElement(By.CssSelector($"span[aria-label*='de 5 estrellas']"));
                    p.Calificacion = elemento.GetAttribute("aria-label");
                    p.Termino = item;
                    products.Add(p);
                }
                catch (Exception err)
                {
                    // Console.WriteLine(err.Message);
                }
            }
            try
            {
                var nextPageLink = driver.FindElement(By.CssSelector("a.s-pagination-next"));
                nextPageLink.Click();
                pageNumber++;
                Console.WriteLine($"Navegando a la página {pageNumber}");
                System.Threading.Thread.Sleep(2000);
            }
            catch (NoSuchElementException)
            {
                hasNextPage = false;
            }
        }
        return products;
    }

    public void CloseConn()
    {
        driver.Quit();
    }

}