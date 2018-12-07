using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes.Base;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    public class CandidatoDB
    {
        public int Save(CandidatoDTO dto)
        {
            string script = @"INSERT INTO tb_candidato(id_aluno, id_vaga, ds_status)
                                                VALUES(@id_aluno, @id_vaga, @ds_status)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_aluno", dto.IdAluno));
            parms.Add(new MySqlParameter("id_vaga", dto.IdVaga));
            parms.Add(new MySqlParameter("ds_status", dto.Status));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<CandidatoView> ListView()
        {
            string script = @"SELECT * FROM vw_candidato";

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);
            List<CandidatoView> list = new List<CandidatoView>();

            while (reader.Read())
            {
                CandidatoView dto = new CandidatoView();
                dto.Id = reader.GetInt32("id_candidato");
                dto.Aluno = reader.GetString("nm_aluno");
                dto.Curso = reader.GetString("nm_curso");
                dto.Vaga = reader.GetString("nm_vaga");
                dto.Status = reader.GetString("ds_status");

                list.Add(dto);
            }
            reader.Close();
            return list;
        }

      
        public List<CandidatoView> Search(string name, string status)
        {
            string script = @"SELECT * FROM vw_candidato 
                                      WHERE nm_aluno LIKE @nm_aluno
                                        AND ds_status LIKE @ds_status";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", name + "%"));
            parms.Add(new MySqlParameter("ds_status", status + "%"));

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<CandidatoView> list = new List<CandidatoView>();

            while (reader.Read())
            {
                CandidatoView dto = new CandidatoView();
                dto.Id = reader.GetInt32("id_candidato");
                dto.Aluno = reader.GetString("nm_aluno");
                dto.Curso = reader.GetString("nm_curso");
                dto.Vaga = reader.GetString("nm_vaga");
                dto.Status = reader.GetString("ds_status");

                list.Add(dto);
            }
            reader.Close();
            return list;
        }

        public void Update(CandidatoView dto)
        {
            string script = @"UPDATE tb_candidato SET ds_status = @ds_status
                                                WHERE id_candidato = @id_candidato";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_status", dto.Status));
            parms.Add(new MySqlParameter("id_candidato", dto.Id));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
