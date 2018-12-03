using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WindowsFormsApplication1.Classes.Base;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;
using WindowsFormsApplication1.Classes.Classes.Empresa;
using Asnsf.AdmPersonalizadora.Lib.Auxiliar;
using WindowsFormsApplication1.Classes.Classes.Auxiliares;
using static WindowsFormsApplication1.Classes.Auxiliar.Auxiliares.Enumeradores;
using WindowsFormsApplication1.Classes.Classes.Aluno;

namespace WindowsFormsApplication1.Classes.Classes.Candidato
{
    internal class CandidatoDataBase
    {
        internal void Salvar(CandidatoDTO c, VagasDTO v)
        {
            var dBase = new DataBase();
            
            try
            {

                const string sScript = @"
                    START TRANSACTION;

                    INSERT INTO TB_CANDIDATO
                    (
                        ID_ALUNO,
                        ID_VAGA,
                        DS_STATUS
                    )
                    VALUES
                    (
                        @ID_ALUNO,
                        @ID_VAGA,
                        @DS_STATUS
                    );

                    UPDATE QT
                    SET
                        QT_VAGAS = @QT_VAGAS - 1
                    FROM TB_QTVAGAS AS QT
                    INNER JOIN TB_VAGAS VG ON VG.ID_QTVAGAS = QT.ID_QTVAGAS
                    WHERE
                        ID_VAGA = @ID_VAGA;

                    COMMIT;";

                var lParams = new List<MySqlParameter>
                {
                    new MySqlParameter("ID_ALUNO", c.IdAluno),
                    new MySqlParameter("ID_VAGA", c.IdVaga),
                    new MySqlParameter("DS_STATUS", c.IdStatus),
                    new MySqlParameter("ID_VAGA", c.IdVaga)
                };
                
                          
                dBase.ExecuteInsertScriptWithPk(sScript, lParams);
            }
            catch (Exception)
            {
                dBase.ExecuteInsertScriptWithPk("ROLLBACK;", null);
                throw;
            }
        }


        internal List<Tuple<CandidatoDTO, VagasDTO, AlunoDTO>> Listar(string pFiltro)
        {
            MySqlDataReader dR = null;
            try
            {
                var sScript = string.Format(@"
                    SELECT
                        C.ID_CANDIDATO,
                        C.ID_ALUNO,
                        C.ID_VAGA,
                        C.DS_STATUS,
                        A.NM_ALUNO,
                        A.DS_IDADE,
                        A.DS_NUMERO,
                        A.NR_FIXO,
                        V.NM_VAGA,
                        V.NM_AREA,
                        V.QTD_AREA,
                        V.DT_INICIOESTAGIO,
                        V.DS_SEXO,
                        V.ID_EMPRESA,
                        V.DS_HORARIOENTRADA,
                        V.DS_HORARIOSAIDA,
                        V.DS_INTERVALO,
                        V.OP_SEGURODEVIDA,
                        V.OP_AUXTRANSPORTE,
                        V.OP_RECREMUNERADO,
                        V.OP_VALEREFEICAO,
                        V.OP_CESTABASICA,
                        V.OP_REFLOCAL,
                        V.OP_ASSISMEDICA,
                        V.NVL_INGLES,
                        V.OP_INFOOFFICE,
                        V.OP_INFOAUTOCAD,
                        V.OP_INFOCOREL,
                        V.OP_INFOPHOTOSHOP,
                        V.OP_INFOPROGRAMACAO,
                        V.DS_OUTROS,
                        V.DS_OBSERVACAO,
                        V.DS_COMPPESSOAL,
                        V.DS_TAREFAS

 
                    FROM
                        TB_CANDIDATO C
                    WHERE
                        1=1
                        {0}",
                        !pFiltro.ParseIsNullOrEmpty()
                            ? @"
                            AND
                            (
                                DS_NOME LIKE @P_FILTRO_L
                                OR NR_SALARIO LIKE @P_FILTRO_L
                                OR DT_CADASTRO LIKE @P_FILTRO_L
                            )"
                            : string.Empty);

                var lParams = new List<MySqlParameter>();
                if (!pFiltro.ParseIsNullOrEmpty())
                    lParams.AddRange(new List<MySqlParameter>
                    {
                        new MySqlParameter("P_FILTRO", pFiltro),
                        new MySqlParameter("P_FILTRO_L", pFiltro.ParseToSqlLike())
                    });

                var lReturn = new List<Tuple<CandidatoDTO, VagasDTO, AlunoDTO>>();
                using (dR = new DataBase().ExecuteSelectScript(sScript, !pFiltro.ParseIsNullOrEmpty() ? lParams : null))
                    while (dR.Read())
                        lReturn.Add(new Tuple<CandidatoDTO, VagasDTO, AlunoDTO>(new CandidatoDTO
                        {

                            Id = dR["ID_LOGIN_ALTERACAO"].ParseToInt()
                        }, new VagasDTO
                        {
                           
                       
                        }, new AlunoDTO
                        {

                        }

                        ));

                return lReturn;
            }
            finally
            {
                if (dR != null && !dR.IsClosed)
                    dR.Close();
            }
        }


         internal List<VText> ListarCBoxCursos()
        {
            MySqlDataReader dR = null;
            try
            {
                const string sScript = @"
                    SELECT
                        C.ID_CURSO,
                        C.NM_CURSO,
                        C.ID_TURMA,
                        T.NM_TURMA
                    FROM
                        TB_CURSO C 
                    INNER JOIN TB_TURMA T ON  C.ID_TURMA = @ID_STATUS
                    WHERE
                       ID_CURSO = @ID_CURSO
                    ORDER BY
                        DS_NOME_FANTASIA";

                var lReturn = new List<VText>();
                    while (dR.Read())
                        lReturn.Add(new VText
                        {
                            Value = dR["ID_CURSO"].ParseToString(),
                            Text = dR["NM_CURSO"].ParseToString().ParseToConcatStrings(dR["NM_CURSO"].ParseToString())
                        });

                return lReturn;
            }
            finally
            {
                if (dR != null && !dR.IsClosed)
                    dR.Close();
            }

















        /*


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
            return lista;*/
    }
    }
}
