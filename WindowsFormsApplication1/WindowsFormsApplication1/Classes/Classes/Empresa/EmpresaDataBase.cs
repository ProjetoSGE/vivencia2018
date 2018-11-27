using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Base;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class EmpresaDataBase
    {
        public int Salvar(EmpresaDTO dto)
        {
            string script = @"INSERT INTO tb_empresas (nm_empresa,nr_telefone,ds_email,ds_cep,ds_bairro,ds_endereco,ds_pontoReferencia)
                              VALUES(@nm_empresa,@nr_telefone,@ds_email,@ds_cep,@ds_bairro,@ds_endereco,@ds_pontoReferencia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_empresa", dto.Empresa));
            parms.Add(new MySqlParameter("nr_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereço));
            parms.Add(new MySqlParameter("ds_pontoReferencia", dto.PontoDeReferencia));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);

        }

        public List<EmpresaDTO> Listar()
        {
            string script = @"SELECT * FROM tb_empresas";


            List<MySqlParameter> parms = new List<MySqlParameter>();

            DataBase db = new DataBase();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EmpresaDTO> lista = new List<EmpresaDTO>();
            while (reader.Read())
            {
                EmpresaDTO dto = new EmpresaDTO();
                dto.ID = reader.GetInt32("id_empresa");
                dto.Empresa = reader.GetString("nm_empresa");
                dto.Telefone = reader.GetString("nr_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.CEP = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.Endereço = reader.GetString("ds_endereco");
                dto.PontoDeReferencia = reader.GetString("ds_pontoReferencia");

                lista.Add(dto);

            }
            reader.Close();

            return lista;
        }

        public List<EmpresaDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_empresas WHERE nm_empresa like @nm_empresa";


            List<MySqlParameter> parms = new List<MySqlParameter>();

            DataBase db = new DataBase();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EmpresaDTO> lista = new List<EmpresaDTO>();
            while (reader.Read())
            {
                EmpresaDTO dto = new EmpresaDTO();
                dto.ID = reader.GetInt32("id_empresa");
                dto.Empresa = reader.GetString("nm_empresa");
                dto.Telefone = reader.GetString("nr_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.CEP = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("ds_bairro");
                dto.Endereço = reader.GetString("ds_endereco");
                dto.PontoDeReferencia = reader.GetString("ds_pontoReferencia");

                lista.Add(dto);

            }
            reader.Close();

            return lista;


        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_empresa WHERE id_empresa like @id_empresa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_empresa", id));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alterar(EmpresaDTO dto)
        {
            string script =
            @"UPDATE tb_empresa
                 SET nm_empresa = @nm_empresa,
	                 nr_telefone = @nr_telefone,
                     ds_email = @ds_email,
                     ds_cep = @ds_cep,
                     ds_bairro = @ds_bairro,
                     ds_endereco = @ds_endereco,
                     ds_pontoReferencia = @ds_pontoReferencia
               WHERE id_empresa = @id_empresa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_empresa", dto.Empresa));
            parms.Add(new MySqlParameter("nr_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cep", dto.CEP));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereço));
            parms.Add(new MySqlParameter("ds_pontoReferencia", dto.PontoDeReferencia));


            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);


        }
    }

}