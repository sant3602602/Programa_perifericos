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

public class UsuarioService : ICrud<Usuario>
    {
        private List<Usuario> usuarios;
        private string archivo = "usuarios.csv";

        public UsuarioService()
        {
            usuarios = CargarCSV();
        }

        public void Crear(Usuario u)
        {
            usuarios.Add(u);
            GuardarCSV();
        }

        public List<Usuario> Leer()
        {
            return usuarios;
        }

        public void Actualizar(int id, Usuario nuevo)
        {
            var u = usuarios.Find(x => x.Id == id);

            if (u != null)
            {
                u.Nombre = nuevo.Nombre;
                u.Correo = nuevo.Correo;
                GuardarCSV();
            }
        }

        public void Eliminar(int id)
        {
            usuarios.RemoveAll(x => x.Id == id);
            GuardarCSV();
        }

        private void GuardarCSV()
        {
            using var writer = new StreamWriter(archivo);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(usuarios);
        }

        private List<Usuario> CargarCSV()
        {
            if (!File.Exists(archivo))
                return new List<Usuario>();

            using var reader = new StreamReader(archivo);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Usuario>().ToList();
        }
    }
}
