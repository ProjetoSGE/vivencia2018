using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;
using WindowsFormsApplication1.Classes.Classes.Vagas;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class VagasBusiness
    {
        VagasDataBase db = new VagasDataBase();
        public int Salvar(VagasDTO funcionario)
        {
            if (funcionario.NomeVaga == string.Empty)
            {
                throw new ArgumentException("Nome da vaga é obrigatório");
            }

            if (funcionario.NomeArea == string.Empty)
            {
                throw new ArgumentException("Área é obrigatório");
            }

            if (funcionario.Sexo == string.Empty)
            {
                throw new ArgumentException("Sexo é obrigatório");
            }

            if (funcionario.NivelIngles == string.Empty)
            {
                throw new ArgumentException("Nível do Inglês é obrigatório");
            }

            return db.Salvar(funcionario);
        }
        public void Alterar(VagasDTO vaga)
        {
            if (vaga.NomeVaga == string.Empty)
            {
                throw new ArgumentException("Nome da vaga é obrigatório");
            }

            if (vaga.NomeArea == string.Empty)
            {
                throw new ArgumentException("Área é obrigatório");
            }

            if (vaga.Sexo == string.Empty)
            {
                throw new ArgumentException("Sexo é obrigatório");
            }

            if (vaga.NivelIngles == string.Empty)
            {
                throw new ArgumentException("Nível do Inglês é obrigatório");
            }

            db.Alterar(vaga);
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
        public List<VagasDTO> Listar()
        {
           return db.Listar();
        }

        public List<VagasView> ListarView()
        {
            VagasDataBase db = new VagasDataBase();
            return db.ListarView();
        }

        public List<VagasView> Consultar(string vaga)
        {
            VagasDataBase db = new VagasDataBase();
            return db.Consultar(vaga);
        }
    }
}
