using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using wb;

var selectedEngine = CustomUtils.GetMotor();
var selectedUrl = CustomUtils.GetUrls();
var itemsSearch = CustomUtils.GetItems();
List<Producto> productos = new List<Producto>();

Brows st = new Brows(selectedUrl,selectedEngine);
foreach (var item in itemsSearch)
{
    List<Producto> ps= st.Start(item);
    productos.AddRange(ps);
}

st.CloseConn();

string csvFilePath = "productos.csv";
var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
using (var writer = new StreamWriter(csvFilePath))
using (var csv = new CsvWriter(writer, csvConfig))
{
    csv.WriteRecords(productos);
}