using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class VagasBusiness
    {
        VagasDataBase db = new VagasDataBase();
        public int Salvar(VagasDTO funcionario)
        {
            
            return db.Salvar(funcionario);
        }
        public void Alterar(VagasDTO vaga)
        {

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
    }
}
