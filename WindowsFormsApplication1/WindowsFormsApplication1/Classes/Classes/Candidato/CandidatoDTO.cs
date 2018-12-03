using Asnsf.AdmPersonalizadora.Lib.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    public class CandidatoDTO
    {
        public int Id { get; set; }

        public int IdAluno { get; set; }

        public int IdVaga { get; set; }

        public EnStatus IdStatus { get; set; }
    }

    public enum EnStatus
    {
        [Description("Dispensado")]
        Dispensado = 0,
        [Description("Em Andamento")]
        Andamento = 1,
        [Description("Contratado")]
        Contratado = 2
    }
}
