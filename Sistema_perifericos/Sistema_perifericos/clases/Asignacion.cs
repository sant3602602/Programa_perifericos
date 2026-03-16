using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_perifericos.clases;
public class Asignacion
{
    
    
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public int PerifericoId { get; set; }
    }

