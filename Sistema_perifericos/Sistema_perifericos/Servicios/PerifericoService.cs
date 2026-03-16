using CsvHelper;
using Sistema_perifericos.clases;
using Sistema_perifericos.Interfaz;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sistema_perifericos.Servicios;


using CsvHelper;
using System.Globalization;

public class PerifericoService : ICrud<Periferico>
{
    private List<Periferico> perifericos;
    private string archivo = "perifericos.csv";

    public PerifericoService()
    {
        perifericos = CargarCSV();
    }

    public void Crear(Periferico p)
    {
        perifericos.Add(p);
        GuardarCSV();
    }

    public List<Periferico> Leer()
    {
        return perifericos;
    }

    public void Actualizar(int id, Periferico nuevo)
    {
        var p = perifericos.Find(x => x.Id == id);

        if (p != null)
        {
            p.Nombre = nuevo.Nombre;
            p.Marca = nuevo.Marca;
            p.Precio = nuevo.Precio;

            GuardarCSV();
        }
    }

    public void Eliminar(int id)
    {
        perifericos.RemoveAll(x => x.Id == id);
        GuardarCSV();
    }

    private void GuardarCSV()
    {
        using var writer = new StreamWriter(archivo);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(perifericos);
    }

    private List<Periferico> CargarCSV()
    {
        if (!File.Exists(archivo))
            return new List<Periferico>();

        using var reader = new StreamReader(archivo);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<Periferico>().ToList();
    }
}
