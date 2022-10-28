using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posgrado : Estudiante
    {
        public string programa_posgrado { get; set; }
        public string promedio_semestre { get; set; }
    }
}
