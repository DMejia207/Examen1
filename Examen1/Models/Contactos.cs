using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }
        [MaxLength(100)]       
        public string phone { get; set; }
        [MaxLength(100)]
        public string edad { get; set; }
        [MaxLength(100)]
        public string pais { get; set; }
        [MaxLength(100)]
        public string nota { get; set; }

    }
}
