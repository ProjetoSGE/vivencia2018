using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    public class CandidatoDB
    {
        public int Save(CandidatoDTO dto)
        {
            string script = @"INSERT INTO tb_candidato(id_aluno, id_vaga, ds_status)";
        }
    }
}
