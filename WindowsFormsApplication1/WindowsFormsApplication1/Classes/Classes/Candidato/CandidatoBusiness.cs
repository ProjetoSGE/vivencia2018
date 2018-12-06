using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    public class CandidatoBusiness
    {
        public int Save(CandidatoDTO dto)
        {
            CandidatoDB db = new CandidatoDB();
            return db.Save(dto);
        }

        public List<CandidatoView> List()
        {
            CandidatoDB db = new CandidatoDB();
            return db.ListView();
        }

        public List<CandidatoView> SearchView(string aluno, string vaga)
        {
            CandidatoDB db = new CandidatoDB();
            return db.SearchView(aluno, vaga);
        }
    }
}
