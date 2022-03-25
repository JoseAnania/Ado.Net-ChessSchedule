using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChessSchedule.Modelo
{
    class Pais
    {
        public int idPais { get; set; }
        public string nombre { get; set; }

        public Pais(int idPais, string nombre)
        {
            this.idPais = idPais;
            this.nombre = nombre;
        }

        public Pais()
        {
        }
    }
}
