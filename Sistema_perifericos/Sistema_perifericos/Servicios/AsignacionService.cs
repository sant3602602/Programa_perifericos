using CsvHelper;
using Sistema_perifericos.clases;
using Sistema_perifericos.Interfaz;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sistema_perifericos.Servicios
{
   
    
        using CsvHelper;
using System.Globalization;

public class AsignacionService : ICrud<Asignacion>
    {
        private List<Asignacion> asignaciones;
        private string archivo = "asignaciones.csv";

        public AsignacionService()
        {
            asignaciones = CargarCSV();
        }

        public void Crear(Asignacion a)
        {
            asignaciones.Add(a);
            GuardarCSV();
        }

        public List<Asignacion> Leer()
        {
            return asignaciones;
        }

        public void Actualizar(int id, Asignacion nueva)
        {
            var a = asignaciones.Find(x => x.Id == id);

            if (a != null)
            {
                a.UsuarioId = nueva.UsuarioId;
                a.PerifericoId = nueva.PerifericoId;
                GuardarCSV();
            }
        }

        public void Eliminar(int id)
        {
            asignaciones.RemoveAll(x => x.Id == id);
            GuardarCSV();
        }

        private void GuardarCSV()
        {
            using var writer = new StreamWriter(archivo);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(asignaciones);
        }

        private List<Asignacion> CargarCSV()
        {
            if (!File.Exists(archivo))
                return new List<Asignacion>();

            using var reader = new StreamReader(archivo);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Asignacion>().ToList();
        }
    }
}

