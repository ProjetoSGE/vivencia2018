using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Aluno
{
    class AlunoBussiness
    {
        public int Salvar(AlunoDTO dto)
        {
            AlunoDataBase db = new AlunoDataBase();

            return db.Salvar(dto);
        }

        public List<AlunoDTO> Consultar(string aluno)
        {
            AlunoDataBase db = new AlunoDataBase();
            return db.Consultar(aluno);
        }

        public void Alterar(AlunoDTO dto)
        {
            AlunoDataBase db = new AlunoDataBase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            AlunoDataBase db = new AlunoDataBase();
            db.Remover(ID);
        }
        public List<AlunoDTO> Listar()
        {
            AlunoDataBase db = new AlunoDataBase();
            return db.Listar();

        }
    }
}
