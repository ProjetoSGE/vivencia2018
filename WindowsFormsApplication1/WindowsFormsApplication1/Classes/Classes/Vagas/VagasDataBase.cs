using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;
using WindowsFormsApplication1.Classes.Classes.Vagas;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class VagasDataBase
    {
        public int Salvar(VagasDTO vaga)
        {
            string Script = @"INSERT INTO tb_vagas
                            (
                                    nm_vaga,
                                    nm_area,
                                    qtd_vaga,
                                    dt_inicioEstagio,
                                    ds_sexo,
                                    id_empresa,
                                    ds_horarioEntrada,
                                    ds_horarioSaida,
                                    ds_intervalo,
                                    op_seguroDeVida,                     
                                    op_auxTransporte,
                                    op_recRemunerado,
                                    op_valeRefeicao,
                                    op_cestaBasica,
                                    op_refLocal,
                                    op_assisMedica,
                                    nvl_ingles,
                                    op_infoOffice,
                                    op_infoAutoCAD,
                                    op_infoCorel,
                                    op_infoPhotoShop,
                                    op_infoProgramacao,
                                    ds_outros,
                                    ds_observacao,
                                    ds_compPessoal,
                                    ds_tarefas
                                    
                            )
                            VALUES
                            (       
                                    @nm_vaga,
                                    @nm_area,
                                    @qtd_vaga,
                                    @dt_inicioEstagio,
                                    @ds_sexo,
                                    @id_empresa,
                                    @ds_horarioEntrada,
                                    @ds_horarioSaida,
                                    @ds_intervalo,
                                    @op_seguroDeVida,                     
                                    @op_auxTransporte,
                                    @op_recRemunerado,
                                    @op_valeRefeicao,
                                    @op_cestaBasica,
                                    @op_refLocal,
                                    @op_assisMedica,
                                    @nvl_ingles,
                                    @op_infoOffice,
                                    @op_infoAutoCAD,
                                    @op_infoCorel,
                                    @op_infoPhotoShop,
                                    @op_infoProgramacao,
                                    @ds_outros,
                                    @ds_observacao,
                                    @ds_compPessoal,
                                    @ds_tarefas
                             )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_vaga", vaga.NomeVaga));
            parms.Add(new MySqlParameter("nm_area", vaga.NomeArea));
            parms.Add(new MySqlParameter("qtd_vaga", vaga.QuantidadeDeVaga));
            parms.Add(new MySqlParameter("dt_inicioEstagio", vaga.DataDeInicio));
            parms.Add(new MySqlParameter("ds_sexo", vaga.Sexo));
            parms.Add(new MySqlParameter("id_empresa", vaga.IdEmpresa));
            parms.Add(new MySqlParameter("ds_horarioEntrada", vaga.HorarioEntrada));
            parms.Add(new MySqlParameter("ds_horarioSaida", vaga.HorarioSaida));
            parms.Add(new MySqlParameter("ds_intervalo", vaga.Intervalo));
            parms.Add(new MySqlParameter("op_seguroDeVida", vaga.SeguroDeVida));
            parms.Add(new MySqlParameter("op_auxTransporte", vaga.AuxTransporte));
            parms.Add(new MySqlParameter("op_recRemunerado", vaga.RecRemunerado));
            parms.Add(new MySqlParameter("op_valeRefeicao", vaga.ValeRefeicao));
            parms.Add(new MySqlParameter("op_cestaBasica", vaga.CestaBasica));
            parms.Add(new MySqlParameter("op_refLocal", vaga.ReLocal));
            parms.Add(new MySqlParameter("op_assisMedica", vaga.AssisMedica));
            parms.Add(new MySqlParameter("nvl_ingles", vaga.NivelIngles));
            parms.Add(new MySqlParameter("op_infoOffice", vaga.InfoOffice));
            parms.Add(new MySqlParameter("op_infoAutoCAD", vaga.InfoAutoCAD));
            parms.Add(new MySqlParameter("op_infoCorel", vaga.InfoCorel));
            parms.Add(new MySqlParameter("op_infoPhotoShop", vaga.InfoPhotoShop));
            parms.Add(new MySqlParameter("op_infoProgramacao", vaga.InfoProgramacao));
            parms.Add(new MySqlParameter("ds_outros", vaga.Outros));
            parms.Add(new MySqlParameter("ds_observacao", vaga.Observacao));
            parms.Add(new MySqlParameter("ds_compPessoal", vaga.CompPessoal));
            parms.Add(new MySqlParameter("ds_tarefas", vaga.Tarefas));


            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }

        public void Alterar(VagasDTO vaga)
        {
            string script =
            @"UPDATE TB_VAGAS
                 SET                NM_VAGA           = @NM_VAGA,
                                    NM_AREA            = @NM_AREA,
                                    QTD_VAGA       = @QTD_VAGA,
                                    DT_INICIOESTAGIO         = @DT_INICIOESTAGIO,
                                    DS_SEXO            = @DS_SEXO,
                                    ID_EMPRESA     = @ID_EMPRESA,
                                    DS_HORARIO        = @DS_HORARIO, 
                                    DS_INTERVALO          = @DS_INTERVALO,        
                                    OP_SEGURODEVIDA    = @OP_SEGURODEVIDA,  
                                    OP_AUXTRANSPORTE           = @OP_AUXTRANSPORTE,   
                                    OP_RECREMUNERADO       = @OP_RECREMUNERADO, 
                                    OP_VALEREFEICAO             = @OP_VALEREFEICAO,    
                                    OP_CESTABASICA        = @OP_CESTABASICA, 
                                    OP_REFLOCAL          = @OP_REFLOCAL,
                                    OP_ASSISMEDICA          = @OP_ASSISMEDICA, 
                                    NVL_INGLES             = @NVL_INGLES,
                                    OP_INFOOFFICE      = @OP_INFOOFFICE, 
                                    OP_INFOAUTOCAD     = @OP_INFOAUTOCAD, 
                                    OP_INFOCOREL         = @OP_INFOCOREL,
                                    OP_INFOPHOTOSHOP        = @OP_INFOPHOTOSHOP,
                                    OP_INFOPROGRAMACAO      = @OP_INFOPROGRAMACAO,
                                      OP_OUTROS        = @OP_OUTROS,
                                    DS_OBSERVACAO      = @DS_OBSERVACAO,
                                    DS_COMPPESSOAL      = @DS_COMPPESSOAL,
                                    DS_TAREFAS          = @DS_TAREFAS
               WHERE ID_VAGA = @ID_VAGA";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ID_VAGA", vaga.Id));
            parms.Add(new MySqlParameter("NM_VAGA", vaga.NomeVaga));
            parms.Add(new MySqlParameter("NM_AREA", vaga.NomeArea));
            parms.Add(new MySqlParameter("QTD_VAGA", vaga.QuantidadeDeVaga));
            parms.Add(new MySqlParameter("DT_INICIOESTAGIO", vaga.DataDeInicio));
            parms.Add(new MySqlParameter("DS_SEXO", vaga.Sexo));
            parms.Add(new MySqlParameter("ID_EMPRESA", vaga.IdEmpresa));
            parms.Add(new MySqlParameter("DS_HORARIO", vaga.HorarioEntrada));
            parms.Add(new MySqlParameter("DS_INTERVALO", vaga.HorarioSaida));
            parms.Add(new MySqlParameter("OP_SEGURODEVIDA", vaga.SeguroDeVida));
            parms.Add(new MySqlParameter("OP_AUXTRANSPORTE", vaga.AuxTransporte));
            parms.Add(new MySqlParameter("OP_RECREMUNERADO", vaga.RecRemunerado));
            parms.Add(new MySqlParameter("OP_VALEREFEICAO", vaga.ValeRefeicao));
            parms.Add(new MySqlParameter("OP_CESTABASICA", vaga.CestaBasica));
            parms.Add(new MySqlParameter("OP_REFLOCAL", vaga.ReLocal));
            parms.Add(new MySqlParameter("OP_ASSISMEDICA", vaga.AssisMedica));
            parms.Add(new MySqlParameter("NVL_INGLES", vaga.NivelIngles));
            parms.Add(new MySqlParameter("OP_INFOOFFICE", vaga.InfoOffice));
            parms.Add(new MySqlParameter("OP_INFOAUTOCAD", vaga.InfoAutoCAD));
            parms.Add(new MySqlParameter("OP_INFOCOREL", vaga.InfoCorel));
            parms.Add(new MySqlParameter("OP_INFOPHOTOSHOP", vaga.InfoPhotoShop));
            parms.Add(new MySqlParameter("OP_INFOPROGRAMACAO", vaga.InfoProgramacao));
            parms.Add(new MySqlParameter("OP_OUTROS", vaga.Outros));
            parms.Add(new MySqlParameter("DS_OBSERVACAO", vaga.Observacao));
            parms.Add(new MySqlParameter("DS_COMPPESSOAL", vaga.CompPessoal));
            parms.Add(new MySqlParameter("DS_TAREFAS", vaga.Tarefas));


            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM TB_VAGAS WHERE ID_VAGA = @ID_VAGA";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ID_VAGA", id));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public List<VagasDTO> Listar()
        {
            string script =
            @"SELECT * FROM TB_FUNCIONARIO";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VagasDTO> vagas = new List<VagasDTO>();

            while (reader.Read())
            {
                VagasDTO novavaga = new VagasDTO();
                novavaga.Id = reader.GetInt32("ID_VAGA");
                novavaga.NomeVaga = reader.GetString("NM_VAGA");
                novavaga.NomeArea = reader.GetString("NM_AREA");
                novavaga.QuantidadeDeVaga = reader.GetInt32("QTD_VAGA");
                novavaga.DataDeInicio = reader.GetDateTime("DT_INICIOESTAGIO");
                novavaga.Sexo = reader.GetString("DS_SEXO");
                novavaga.IdEmpresa = reader.GetInt32("id_empresa");
                novavaga.HorarioEntrada = reader.GetString("DS_HORARIO");
                novavaga.HorarioSaida = reader.GetString("DS_INTERVALO");
                novavaga.Intervalo = reader.GetString("ds_intervalo");
                novavaga.SeguroDeVida = reader.GetBoolean("OP_SEGURODEVIDA");
                novavaga.AuxTransporte = reader.GetBoolean("OP_AUXTRANSPORTE");
                novavaga.RecRemunerado = reader.GetBoolean("OP_RECREMUNERADO");
                novavaga.ValeRefeicao = reader.GetBoolean("OP_VALEREFEICAO");
                novavaga.CestaBasica = reader.GetBoolean("OP_CESTABASICA");
                novavaga.ReLocal = reader.GetBoolean("OP_REFLOCAL");
                novavaga.AssisMedica = reader.GetBoolean("OP_ASSISMEDICA");
                novavaga.NivelIngles = reader.GetString("NVL_INGLES");
                novavaga.InfoOffice = reader.GetBoolean("OP_INFOOFFICE");
                novavaga.InfoAutoCAD = reader.GetBoolean("OP_INFOAUTOCAD");
                novavaga.InfoCorel = reader.GetBoolean("OP_INFOCOREL");
                novavaga.InfoPhotoShop = reader.GetBoolean("OP_INFOPHOTOSHOP");
                novavaga.InfoProgramacao = reader.GetBoolean("OP_INFOPROGRAMACAO");
                novavaga.Outros = reader.GetString("OP_OUTROS");
                novavaga.Observacao = reader.GetString("DS_OBSERVACAO");
                novavaga.CompPessoal = reader.GetString("DS_COMPPESSOAL");
                novavaga.Tarefas = reader.GetString("DS_TAREFAS");

                vagas.Add(novavaga);
            }
            reader.Close();

            return vagas;

        }

        public List<VagasView> ListarView()
        {
            string script = @"SELECT * FROM vw_vagas";

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<VagasView> vagas = new List<VagasView>();

            while (reader.Read())
            {
                VagasView novavaga = new VagasView();
                novavaga.Id = reader.GetInt32("ID_VAGA");
                novavaga.NomeVaga = reader.GetString("NM_VAGA");
                novavaga.NomeArea = reader.GetString("NM_AREA");
                novavaga.QuantidadeDeVaga = reader.GetInt32("QTD_VAGA");
                novavaga.DataDeInicio = reader.GetDateTime("DT_INICIOESTAGIO");
                novavaga.Sexo = reader.GetString("DS_SEXO");
                novavaga.Empresa = reader.GetString("nm_fantasia");
                novavaga.HorarioEntrada = reader.GetString("ds_horarioEntrada");
                novavaga.HorarioSaida = reader.GetString("ds_horarioSaida");
                novavaga.Intervalo = reader.GetString("ds_intervalo");
                novavaga.SeguroDeVida = reader.GetBoolean("OP_SEGURODEVIDA");
                novavaga.AuxTransporte = reader.GetBoolean("OP_AUXTRANSPORTE");
                novavaga.RecRemunerado = reader.GetBoolean("OP_RECREMUNERADO");
                novavaga.ValeRefeicao = reader.GetBoolean("OP_VALEREFEICAO");
                novavaga.CestaBasica = reader.GetBoolean("OP_CESTABASICA");
                novavaga.ReLocal = reader.GetBoolean("OP_REFLOCAL");
                novavaga.AssisMedica = reader.GetBoolean("OP_ASSISMEDICA");
                novavaga.NivelIngles = reader.GetString("NVL_INGLES");
                novavaga.InfoOffice = reader.GetBoolean("OP_INFOOFFICE");
                novavaga.InfoAutoCAD = reader.GetBoolean("OP_INFOAUTOCAD");
                novavaga.InfoCorel = reader.GetBoolean("OP_INFOCOREL");
                novavaga.InfoPhotoShop = reader.GetBoolean("OP_INFOPHOTOSHOP");
                novavaga.InfoProgramacao = reader.GetBoolean("OP_INFOPROGRAMACAO");
                novavaga.Outros = reader.GetString("ds_outros");
                novavaga.Observacao = reader.GetString("DS_OBSERVACAO");
                novavaga.CompPessoal = reader.GetString("DS_COMPPESSOAL");
                novavaga.Tarefas = reader.GetString("DS_TAREFAS");

                vagas.Add(novavaga);
            }
            reader.Close();

            return vagas;
        }

        public List<VagasView> Consultar(string vaga)
        {
            string script = @"SELECT * FROM vw_vagas WHERE nm_vaga LIKE @ nm_vaga";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_vaga", vaga + "%"));

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VagasView> vagas = new List<VagasView>();

            while (reader.Read())
            {
                VagasView novavaga = new VagasView();
                novavaga.Id = reader.GetInt32("ID_VAGA");
                novavaga.NomeVaga = reader.GetString("NM_VAGA");
                novavaga.NomeArea = reader.GetString("NM_AREA");
                novavaga.QuantidadeDeVaga = reader.GetInt32("QTD_VAGA");
                novavaga.DataDeInicio = reader.GetDateTime("DT_INICIOESTAGIO");
                novavaga.Sexo = reader.GetString("DS_SEXO");
                novavaga.Empresa = reader.GetString("nm_fantasia");
                novavaga.HorarioEntrada = reader.GetString("ds_horarioEntrada");
                novavaga.HorarioSaida = reader.GetString("ds_horarioSaida");
                novavaga.Intervalo = reader.GetString("ds_intervalo");
                novavaga.SeguroDeVida = reader.GetBoolean("OP_SEGURODEVIDA");
                novavaga.AuxTransporte = reader.GetBoolean("OP_AUXTRANSPORTE");
                novavaga.RecRemunerado = reader.GetBoolean("OP_RECREMUNERADO");
                novavaga.ValeRefeicao = reader.GetBoolean("OP_VALEREFEICAO");
                novavaga.CestaBasica = reader.GetBoolean("OP_CESTABASICA");
                novavaga.ReLocal = reader.GetBoolean("OP_REFLOCAL");
                novavaga.AssisMedica = reader.GetBoolean("OP_ASSISMEDICA");
                novavaga.NivelIngles = reader.GetString("NVL_INGLES");
                novavaga.InfoOffice = reader.GetBoolean("OP_INFOOFFICE");
                novavaga.InfoAutoCAD = reader.GetBoolean("OP_INFOAUTOCAD");
                novavaga.InfoCorel = reader.GetBoolean("OP_INFOCOREL");
                novavaga.InfoPhotoShop = reader.GetBoolean("OP_INFOPHOTOSHOP");
                novavaga.InfoProgramacao = reader.GetBoolean("OP_INFOPROGRAMACAO");
                novavaga.Outros = reader.GetString("ds_outros");
                novavaga.Observacao = reader.GetString("DS_OBSERVACAO");
                novavaga.CompPessoal = reader.GetString("DS_COMPPESSOAL");
                novavaga.Tarefas = reader.GetString("DS_TAREFAS");

                vagas.Add(novavaga);
            }
            reader.Close();

            return vagas;
        }
    }
}
