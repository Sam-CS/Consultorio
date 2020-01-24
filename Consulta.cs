using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    class Consulta
    {
        public int idConsulta { get; set; }
        public String motivo { get; set; }
        public DateTime dtConsulta { get; set; }
        public String diagnostico { get; set; }
        public String receita { get; set; }
        public DateTime dtRetorno { get; set; }
        public String motivoRetorno { get; set; }
        public int idPaciente { get; set; }
        public int idDentista { get; set; }


    }
}
