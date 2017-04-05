using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Solicitud
    {
        public int id_solic { get; set; }
        public int id_lab { get; set; }
        public int id_curso { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora_ini { get; set; }
        public TimeSpan hona_fin { get; set; }
        public Boolean activo { get; set; }
    }
}
