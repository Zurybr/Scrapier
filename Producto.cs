using System;
public class Producto
{
    public Guid ID { get; set; } = Guid.NewGuid();
    
    public string Termino { get; set; }
    public string Vendedor { get; set; }
    public string Descripcion { get; set; }
    public string Precio { get; set; }
    public string Calificacion { get; set; }
    
    public override string ToString()
    {
        return $"ID: {ID}\nVendedor: {Vendedor}\nDescripción: {Descripcion}\nPrecio: {Precio} \nCal: {Calificacion}";
    }
}