using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noviembre.coree.Entidades
{
    public class Cita  {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Modulo Modulo { get; set; }
        public Ciudadano Ciudadano { get; set; }
        public DocumentoNacionalidad DocumentoNacionalidad { get; set; }
        public ComprobanteDomicilio ComprobanteDomicilio { get; set; }




    }
}
