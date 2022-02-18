namespace Clases_libreria;

public class Coche
{
    //Atributos
    private int id;
    //private string modelo;
    //private string precio;
    //private string km;

    //Propiedades
    public int Id { get => id; set => id = value; }

    //public string Marca { get; set; }

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
    public int  Km { get; set; }


    //Constructor
    public Coche () { }

    public Coche(int id, string marca) 
    { 
        Id = id;
        Marca = marca;
    }

    //Metodos
    public string DevolverDatosCoche()
    {
        return "Id: " + Id + " Marca: " + Marca + " Modelo: " + Modelo; 
    }
}
