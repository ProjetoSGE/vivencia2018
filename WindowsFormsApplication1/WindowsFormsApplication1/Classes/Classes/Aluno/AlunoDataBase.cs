using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;

namespace WindowsFormsApplication1.Classes.Classes.Aluno
{
    class AlunoDataBase
    {
        public int Salvar(AlunoDTO dto)
        {
            string script = @"INSERT INTO tb_alunos (nm_aluno,nm_curso,ds_anoEstudo,dt_nascimento,ds_idade,ds_endereco,ds_numero,ds_bairro,ds_cep,nr_fixo,nr_celular,ds_seEstuda,ds_qualCurso,ds_turno,ds_expProfissional,ds_areaPreferencia)
                                           VALUES (@nm_aluno,@nm_curso,@ds_anoEstudo,@dt_nascimento,@ds_idade,@ds_endereco,@ds_numero,@ds_bairro,@ds_cep,@nr_fixo,@nr_celular,@ds_seEstuda,@ds_qualCurso,@ds_turno,@ds_expProfissional,@ds_areaPreferencia)";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", dto.Nome));
            parms.Add(new MySqlParameter("nm_curso", dto.NomeCurso));
            parms.Add(new MySqlParameter("ds_anoEstudo", dto.AnoDeEstudo));
            parms.Add(new MySqlParameter("dt_nascimento", dto.Nascimento));
            parms.Add(new MySqlParameter("ds_idade", dto.Idade));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereco));
            parms.Add(new MySqlParameter("ds_numero", dto.Numero));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));
            parms.Add(new MySqlParameter("nr_fixo", dto.Fixo));
            parms.Add(new MySqlParameter("nr_celular", dto.Celular));
            parms.Add(new MySqlParameter("ds_seEstuda", dto.SeEstuda));
            parms.Add(new MySqlParameter("ds_qualCurso", dto.QualCurso));
            parms.Add(new MySqlParameter("ds_turno", dto.Turno));
            parms.Add(new MySqlParameter("ds_expProfissional", dto.ExpProfissional));
            parms.Add(new MySqlParameter("ds_areaPreferencia", dto.AreaPreferencial));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Alterar(AlunoDTO dto)
        {

            string script = @" UPDATE  tb_alunos

                                                SET
                                                   nm_aluno = @nm_aluno,
                                                   nm_curso = @nm_curso,
                                               ds_anoEstudo = @ds_anoEstudo,
                                              dt_nascimento = @dt_nascimento,
                                                   ds_idade = @ds_idade,
                                                ds_endereco = @ds_endereco,
                                                  ds_numero = @ds_numero,
                                                  ds_bairro = @ds_bairro,
                                                     ds_cep = @ds_cep,
                                                    nr_fixo = @nr_fixo,
                                                 nr_celular = @nr_celular,
                                                ds_seEstudO = @ds_seEstuda,
                                               ds_qualCurso = @ds_qualCurso,
                                                   ds_turno = @ds_turno,
                                         ds_expProfissional = @ds_expProfissional,
                                         ds_areaPreferencia = @ds_areaPreferencia
                                            WHERE id_aluno = @id_aluno";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", dto.Nome));
            parms.Add(new MySqlParameter("nm_curso", dto.NomeCurso));
            parms.Add(new MySqlParameter("ds_anoEstudo", dto.AnoDeEstudo));
            parms.Add(new MySqlParameter("dt_nascimento", dto.Nascimento));
            parms.Add(new MySqlParameter("ds_idade", dto.Idade));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereco));
            parms.Add(new MySqlParameter("ds_numero", dto.Numero));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));
            parms.Add(new MySqlParameter("nr_fixo", dto.Fixo));
            parms.Add(new MySqlParameter("nr_celular", dto.Celular));
            parms.Add(new MySqlParameter("ds_seEstuda", dto.SeEstuda));
            parms.Add(new MySqlParameter("ds_qualCurso", dto.QualCurso));
            parms.Add(new MySqlParameter("ds_turno", dto.Turno));
            parms.Add(new MySqlParameter("ds_expProfissional", dto.ExpProfissional));
            parms.Add(new MySqlParameter("ds_areaPreferencia", dto.AreaPreferencial));


            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_alunos WHERE id_aluno = @id_aluno";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_aluno", ID));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public List<AlunoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_alunos";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<AlunoDTO> lista = new List<AlunoDTO>();
            while (reader.Read())


            {
                AlunoDTO dto = new AlunoDTO();
                dto.ID = reader.GetInt32("id_aluno");
                dto.Nome = reader.GetString("nm_aluno");
                dto.NomeCurso = reader.GetString("nm_curso");
                dto.AnoDeEstudo = reader.GetString("ds_anoEstudo");
                dto.Nascimento = reader.GetDateTime("dt_nascimento");
                dto.Idade = reader.GetInt32("ds_idade");
                dto.Endereco = reader.GetString("ds_endereco");
                dto.Numero = reader.GetInt32("ds_numero");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.CEP = reader.GetString("ds_cep");
                dto.Fixo = reader.GetString("nr_fixo");
                dto.Celular = reader.GetString("nr_celular");
                dto.SeEstuda = reader.GetString("ds_seEstuda");
                dto.QualCurso = reader.GetString("ds_qualCurso");
                dto.Turno = reader.GetString("ds_turno");
                dto.ExpProfissional = reader.GetString("ds_expProfissional");
                dto.AreaPreferencial = reader.GetString("ds_areaPreferencia");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

        public List<AlunoDTO> Consultar(string aluno)
        {
            string script = @"SELECT * FROM tb_alunos WHERE nm_aluno like @nm_aluno";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_aluno", aluno + "%"));

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<AlunoDTO> lista = new List<AlunoDTO>();
            while (reader.Read())
            {
                AlunoDTO dto = new AlunoDTO();
                dto.ID = reader.GetInt32("id_aluno");
                dto.Nome = reader.GetString("nm_aluno");
                dto.NomeCurso = reader.GetString("nm_curso");
                dto.AnoDeEstudo = reader.GetString("ds_anoEstudo");
                dto.Nascimento = reader.GetDateTime("dt_nascimento");
                dto.Idade = reader.GetInt32("ds_idade");
                dto.Endereco = reader.GetString("ds_endereco");
                dto.Numero = reader.GetInt32("ds_numero");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.CEP = reader.GetString("ds_cep");
                dto.Fixo = reader.GetString("nr_fixo");
                dto.Celular = reader.GetString("nr_celular");
                dto.SeEstuda = reader.GetString("ds_seEstuda");
                dto.QualCurso = reader.GetString("ds_qualCurso");
                dto.Turno = reader.GetString("ds_turno");
                dto.ExpProfissional = reader.GetString("ds_expProfissional");
                dto.AreaPreferencial = reader.GetString("ds_areaPreferencia");

                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }
    }
}
