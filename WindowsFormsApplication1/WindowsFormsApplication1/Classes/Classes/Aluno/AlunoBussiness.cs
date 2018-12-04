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
            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome do aluno é obrigatório");
            }

            if (dto.Curso == string.Empty)
            {
                throw new ArgumentException("Curso é obrigatório");
            }

            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome da Empresa é obrigatório");
            }

            if (dto.AnoDeEstudo == string.Empty)
            {
                throw new ArgumentException("Ano de estudo é obrigatório");
            }

            if (dto.Idade <= 13)
            {
                throw new ArgumentException("Idade deve ser maior que 13");
            }

            if (dto.Endereco == string.Empty)
            {
                throw new ArgumentException("Endereço é obrigatório");
            }

            if (dto.Numero == string.Empty)
            {
                throw new ArgumentException("Número da casa é obrigatório");
            }

            if (dto.Bairro == string.Empty)
            {
                throw new ArgumentException("Bairro é obrigatório");
            }

            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome da Empresa é obrigatório");
            }

            if (dto.AreaPreferencial == string.Empty)
            {
                throw new ArgumentException("Área de preferência é obrigatório");
            }

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
            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome do aluno é obrigatório");
            }

            if (dto.Curso == string.Empty)
            {
                throw new ArgumentException("Curso é obrigatório");
            }

            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome da Empresa é obrigatório");
            }

            if (dto.AnoDeEstudo == string.Empty)
            {
                throw new ArgumentException("Ano de estudo é obrigatório");
            }

            if (dto.Idade <= 13)
            {
                throw new ArgumentException("Idade deve ser maior que 13");
            }

            if (dto.Endereco == string.Empty)
            {
                throw new ArgumentException("Endereço é obrigatório");
            }

            if (dto.Bairro == string.Empty)
            {
                throw new ArgumentException("Bairro é obrigatório");
            }

            if (dto.Numero == string.Empty)
            {
                throw new ArgumentException("Número da casa é obrigatório");
            }

            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome da Empresa é obrigatório");
            }

            if (dto.AreaPreferencial == string.Empty)
            {
                throw new ArgumentException("Área de preferência é obrigatório");
            }

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
