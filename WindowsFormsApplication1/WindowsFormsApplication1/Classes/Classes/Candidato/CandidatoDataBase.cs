using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WindowsFormsApplication1.Classes.Base;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;
using WindowsFormsApplication1.Classes.Classes.Empresa;
using Asnsf.AdmPersonalizadora.Lib.Auxiliar;

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

                    UPDATE TB_VAGAS
                    SET
                        NM_VAGA = @NM_VAGA,
                        NM_AREA = @NM_AREA,
                        QTD_AREA = @QTD_AREA - 1,
                        DT_INICIOESTAGIO = @DT_INICIOESTAGIO,
                        DS_SEXO = @DS_SEXO,
                        ID_EMPRESA = @ID_EMPRESA,
                        DS_HORARIOENTRADA = @DS_HORARIOENTRADA,
                        DS_HORARIOSAIDA = @DS_HORARIOSAIDA,
                        DS_INTERVALO = @DS_INTERVALO,
                        OP_SEGURODEVIDA = @OP_SEGURODEVIDA,
                        OP_AUXTRANSPORTE = @OP_AUXTRANSPORTE,
                        OP_RECREMUNERADO = @OP_RECREMUNERADO,
                        OP_VALEREFEICAO = @OP_VALEREFEICAO,
                        OP_CESTABASICA = @OP_CESTABASICA,
                        OP_REFLOCAL = @OP_REFLOCAL,
                        OP_ASSISMEDICA = @OP_ASSISMEDICA,
                        NVL_INGLES = @NVL_INGLES,
                        OP_INFOOFFICE = @OP_INFOOFFICE,
                        OP_INFOAUTOCAD = @OP_INFOAUTOCAD,
                        OP_INFOCOREL = @OP_INFOCOREL,
                        OP_INFOPHOTOSHOP = @OP_INFOPHOTOSHOP,
                        OP_INFOPROGRAMACAO = @OP_INFOPROGRAMACAO,
                        DS_OUTROS = @DS_OUTROS,
                        DS_OBSERVACAO = @DS_OBSERVACAO,
                        DS_COMPPESSOAL = @DS_COMPPESSOAL,
                        DS_TAREFAS = @DS_TAREFAS
                    WHERE
                        ID_VAGA = @ID_VAGA;

                    COMMIT;";

                var lParams = new List<MySqlParameter>
                {
                    new MySqlParameter("ID_ALUNO", c.IdAluno),
                    new MySqlParameter("ID_VAGA", c.IdVaga),
                    new MySqlParameter("DS_STATUS", c.IdStatus),
                    new MySqlParameter("NM_VAGA", v.NomeVaga),
                    new MySqlParameter("NM_AREA", v.NomeArea),
                    new MySqlParameter("QTD_AREA", v.QuantidadeDeVaga),
                    new MySqlParameter("DT_INICIOESTAGIO", v.DataDeInicio),
                    new MySqlParameter("ID_EMPRESA", v.IdEmpresa),
                    new MySqlParameter("DS_HORARIOENTRADA", v.HorarioEntrada),
                    new MySqlParameter("DS_HORARIOSAIDA", v.HorarioSaida),
                    new MySqlParameter("DS_INTERVALO", v.Intervalo),
                    new MySqlParameter("OP_SEGURODEVIDA", v.SeguroDeVida),
                    new MySqlParameter("OP_AUXTRANSPORTE", v.AuxTransporte),
                    new MySqlParameter("OP_RECREMUNERADO", v.RecRemunerado),
                    new MySqlParameter("OP_VALEREFEICAO", v.ValeRefeicao),
                    new MySqlParameter("OP_CESTABASICA", v.CestaBasica),
                    new MySqlParameter("OP_REFLOCAL", v.ReLocal),
                    new MySqlParameter("OP_ASSISMEDICA", v.AssisMedica),
                    new MySqlParameter("NVL_INGLES", v.NivelIngles),
                    new MySqlParameter("OP_INFOOFFICE", v.InfoOffice),
                    new MySqlParameter("OP_INFOAUTOCAD", v.InfoAutoCAD),
                    new MySqlParameter("OP_INFOCOREL", v.InfoCorel),
                    new MySqlParameter("OP_INFOPHOTOSHOP", v.InfoPhotoShop),
                    new MySqlParameter("OP_INFOPROGRAMACAO", v.InfoProgramacao),
                    new MySqlParameter("DS_OUTROS", v.Outros),
                    new MySqlParameter("DS_OBSERVACAO", v.Observacao),
                    new MySqlParameter("DS_COMPPESSOAL", v.CompPessoal),
                    new MySqlParameter("DS_TAREFAS", v.Tarefas)
                };
                
                          
                dBase.ExecuteInsertScriptWithPk(sScript, lParams);
            }
            catch (Exception)
            {
                dBase.ExecuteInsertScriptWithPk("ROLLBACK;", null);
                throw;
            }
        }


        internal List<Tuple<CandidatoDTO, VagasDTO>> Listar(string pFiltro)
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
NM_CURSO,
DS_RG,
DS_ANOESTUDO,
DT_NASCIMENTO,
DS_IDADE,
DS_ENDERECO,
DS_NUMERO,
DS_BAIRRO,
DS_CEP,
NR_FIXO,
NR_CELULAR,
DS_SEESTUDA,
DS_QUALCURSO,
DS_TURNO,
DS_EXPPROFISSIONAL,
DS_AREAPREFERENCIAL

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

                var lReturn = new List<Tuple<Cargo>>();
                using (dR = new DBase.DBase().ExecuteScriptDataReader(sScript, !pFiltro.ParseIsNullOrEmpty() ? lParams : null))
                    while (dR.Read())
                        lReturn.Add(new Tuple<Cargo>(new Cargo
                        {
                            IdCargo = dR["ID_CARGO"].ParseToLong(),
                            DsNome = dR["DS_NOME"].ParseToString(),
                            NrSalario = dR["NR_SALARIO"].ParseToDouble(),
                            TpPermissao = Extensions.GetEnum<EnPermissao>(dR["TP_PERMISAO"].ParseToInt()),
                            FlPedidoCompra = dR["FL_PEDIDO_COMPRA"].ParseToBool(),
                            FlPedidoVenda = dR["FL_PEDIDO_VENDA"].ParseToBool(),
                            IdStatus = Extensions.GetEnum<EnStatus>(dR["ID_STATUS"].ParseToInt()),
                            DtCadastro = dR["DT_CADASTRO"].ParseToDateTime(),
                            DtAlteracao = dR["DT_ALTERACAO"].ParseToDateTime(),
                            IdLoginCadastro = dR["ID_LOGIN_CADASTRO"].ParseToLong(),
                            IdLoginAlteracao = dR["ID_LOGIN_ALTERACAO"].ParseToLong()
                        }));

                return lReturn;
            }
            finally
            {
                if (dR != null && !dR.IsClosed)
                    dR.Close();
            }
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
