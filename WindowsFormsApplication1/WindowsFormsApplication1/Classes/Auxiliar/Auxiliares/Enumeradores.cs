using Asnsf.AdmPersonalizadora.Lib.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Auxiliar.Auxiliares
{
    public class Enumeradores
    {
        public enum EnStatus
        {
            [Description("Dispensado")]
            Dispensado = 0,
            [Description("Em Andamento")]
            Andamento = 1,
            [Description("Contratado")]
            Contratado = 2
        }
        public enum EnCursos
        {
            [Description("Administração")]
            Curso1 = 0,
            [Description("Comunicação Visual")]
            Curso2 = 1,
            [Description("Eletromecânica")]
            Curso3 = 2,
            [Description("Eletrotécnica")]
            Curso4 = 3,
            [Description("Informática")]
            Curso5 = 4,
            [Description("Inglês")]
            Curso6 = 5
        }
    }
}
