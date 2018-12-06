﻿using System;
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

        public List<CandidatoView> SearchView(string aluno, string vaga)
        {
            string script = @"SELECT * FROM vw_candidato 
                                      WHERE nm_aluno LIKE @nm_aluno 
                                        AND nm_vaga LIKE @nm_vaga";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", aluno + "%"));
            parms.Add(new MySqlParameter("nm_vaga", vaga + "%"));

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
    }
}
