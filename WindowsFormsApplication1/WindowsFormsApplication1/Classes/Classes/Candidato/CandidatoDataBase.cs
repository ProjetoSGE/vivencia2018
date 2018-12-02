using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    class CandidatoDataBase
    {
        public int Salvar(CandidatoDTO dto)
        {
            string script = @"INSERT INTO tb_candidado(id_aluno, id_vaga, ds_status)
                                                VALUES(@id_aluno, @id_vaga, @ds_status)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_aluno", dto.IdAluno));
            parms.Add(new MySqlParameter("id_vaga", dto.IdVaga));
            parms.Add(new MySqlParameter("ds_status", dto.Status));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
     
        public List<CandidatoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_candidato";

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<CandidatoDTO> lista = new List<CandidatoDTO>();
            while (reader.Read())
            {
                CandidatoDTO dto = new CandidatoDTO();
                dto.Id = reader.GetInt32("id_candidato");
                dto.IdAluno = reader.GetInt32("id_aluno");
                dto.IdVaga = reader.GetInt32("id_vaga");
                dto.Status = reader.GetString("ds_status");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
      
        public List<CandidatoView> ListarView()
        {
            string script = @"SELECT * FROM vw_candidato";

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<CandidatoView> lista = new List<CandidatoView>();
            while (reader.Read())
            {
                CandidatoView dto = new CandidatoView();
                dto.Id = reader.GetInt32("id_candidato");
                dto.Aluno = reader.GetString("nm_aluno");
                dto.Curso = reader.GetString("nm_curso");
                dto.Vaga = reader.GetString("nm_vaga");
                dto.Status = reader.GetString("ds_status");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<CandidatoView> Consultar(string nome, string curso)
        {
            string script = @"SELECT * FROM vw_candidato
                                      WHERE nm_aluno LIKE @nm_aluno     
                                        AND ds_curso LIKE @ds_curso";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", nome + "%"));
            parms.Add(new MySqlParameter("nm_curso", curso + "%"));

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CandidatoView> lista = new List<CandidatoView>();
            while (reader.Read())
            {
                CandidatoView dto = new CandidatoView();
                dto.Id = reader.GetInt32("id_candidato");
                dto.Aluno = reader.GetString("nm_aluno");
                dto.Curso = reader.GetString("nm_curso");
                dto.Vaga = reader.GetString("nm_vaga");
                dto.Status = reader.GetString("ds_status");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }
    }
}
