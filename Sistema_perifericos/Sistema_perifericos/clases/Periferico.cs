using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_perifericos.clases;

public class Periferico
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public double Precio { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine($"{Id} - {Nombre} - {Marca} - ${Precio}");
    }
}