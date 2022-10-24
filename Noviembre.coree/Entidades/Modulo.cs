using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noviembre.coree.Entidades
{
    public class Modulo
    {

        public int Id { get; set; }

        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Horario { get; set; }
        public String Referencias { get; set; }
        public Municipio Municipio { get; set; }

    }
}
