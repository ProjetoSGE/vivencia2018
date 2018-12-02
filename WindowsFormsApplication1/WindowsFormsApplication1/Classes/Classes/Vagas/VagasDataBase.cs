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
            string Script = @"INSERT INTO TB_VAGAS
                            (
                                    NM_VAGA,
                                    NM_AREA,
                                    QTD_VAGA,
                                    DT_INICIOESTAGIO,
                                    DS_SEXO,
                                    ID_EMPRESA,
                                    DS_HORARIOENTRADA,
                                    DS_HORARIOSAIDA
                                    DS_INTERVALO,
                                    OP_SEGURODEVIDA,                     
                                    OP_AUXTRANSPORTE,
                                    OP_RECREMUNERADO,
                                    OP_VALEREFEICAO,
                                    OP_CESTABASICA,
                                    OP_REFLOCAL,
                                    OP_ASSISMEDICA,
                                    NVL_INGLES,
                                    OP_INFOOFFICE,
                                    OP_INFOAUTOCAD,
                                    OP_INFOCOREL,
                                    OP_INFOPHOTOSHOP,
                                    OP_INFOPROGRAMACAO,
                                    OP_OUTROS,
                                    DS_OBSERVACAO,
                                    DS_COMPPESSOAL,
                                    DS_TAREFAS
                                    
                            )
                            VALUES
                            (       
                                    @NM_VAGA,
                                    @NM_AREA,
                                    @QTD_VAGA,
                                    @DT_INICIOESTAGIO,
                                    @DS_SEXO,
                                    @ID_EMPRESA,
                                    @DS_HORARIOENTRADA,
                                    @DS_HORARIOSAIDA
                                    @DS_INTERVALO,
                                    @OP_SEGURODEVIDA,                     
                                    @OP_AUXTRANSPORTE,
                                    @OP_RECREMUNERADO,
                                    @OP_VALEREFEICAO,
                                    @OP_CESTABASICA,
                                    @OP_REFLOCAL,
                                    @OP_ASSISMEDICA,
                                    @NVL_INGLES,
                                    @OP_INFOOFFICE,
                                    @OP_INFOAUTOCAD,
                                    @OP_INFOCOREL,
                                    @OP_INFOPHOTOSHOP,
                                    @OP_INFOPROGRAMACAO,
                                    @OP_OUTROS,
                                    @DS_OBSERVACAO,
                                    @DS_COMPPESSOAL,
                                    @DS_TAREFAS
                             )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("NM_VAGA", vaga.NomeVaga));
            parms.Add(new MySqlParameter("NM_AREA", vaga.NomeArea));
            parms.Add(new MySqlParameter("QTD_VAGA", vaga.QuantidadeDeVaga));
            parms.Add(new MySqlParameter("DT_INICIOESTAGIO", vaga.DataDeInicio));
            parms.Add(new MySqlParameter("DS_SEXO", vaga.Sexo));
            parms.Add(new MySqlParameter("ID_EMPRESA", vaga.IdEmpresa));
            parms.Add(new MySqlParameter("DS_HORARIOENTRADA", vaga.HorarioEntrada));
            parms.Add(new MySqlParameter("DS_HORARIOSAIDA", vaga.HorarioSaida));
            parms.Add(new MySqlParameter("DS_INTERVALO", vaga.Intervalo));
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
            int pk = db.ExecuteInsertScriptWithPk(Script, parms);
            return pk;


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
                novavaga.HorarioEntrada = reader.GetDateTime("DS_HORARIO");
                novavaga.HorarioSaida = reader.GetDateTime("DS_INTERVALO");
                novavaga.Intervalo = reader.GetDateTime("ds_intervalo");
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
                novavaga.HorarioEntrada = reader.GetDateTime("DS_HORARIO");
                novavaga.HorarioSaida = reader.GetDateTime("DS_INTERVALO");
                novavaga.Intervalo = reader.GetDateTime("ds_intervalo");
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
    }
}
