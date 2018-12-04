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
            string script = @"INSERT INTO tb_empresas (nm_fantasia, nm_razaoSocial, ds_cnpj, nr_codEstadual, nr_telefone, ds_email, ds_cep, ds_bairro, ds_endereco, ds_pontoReferencia)
                                                VALUES(@nm_fantasia, @nm_razaoSocial, @ds_cnpj, @nr_codEstadual, @nr_telefone, @ds_email, @ds_cep, @ds_bairro, @ds_endereco, @ds_pontoReferencia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_fantasia", dto.Nome));
            parms.Add(new MySqlParameter("nm_razaoSocial", dto.RazãoSocial));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("nr_codEstadual", dto.CodEstadual));
            parms.Add(new MySqlParameter("nr_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
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
                dto.Id = reader.GetInt32("id_empresa");
                dto.Nome = reader.GetString("nm_fantasia");
                dto.RazãoSocial = reader.GetString("nm_razaoSocial");
                dto.Cnpj = reader.GetString("ds_cnpj");
                dto.CodEstadual = reader.GetString("nr_codEstadual");
                dto.Telefone = reader.GetString("nr_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.Cep = reader.GetString("ds_cep");
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
            string script = @"SELECT * FROM tb_empresas WHERE nm_fantasia like @nm_fantasia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_fantasia", nome + "%"));

            DataBase db = new DataBase();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EmpresaDTO> lista = new List<EmpresaDTO>();
            while (reader.Read())
            {
                EmpresaDTO dto = new EmpresaDTO();
                dto.Id = reader.GetInt32("id_empresa");
                dto.Nome = reader.GetString("nm_fantasia");
                dto.RazãoSocial = reader.GetString("nm_razaoSocial");
                dto.Cnpj = reader.GetString("ds_cnpj");
                dto.CodEstadual = reader.GetString("nr_codEstadual");
                dto.Telefone = reader.GetString("nr_telefone");
                dto.Email = reader.GetString("ds_email");
                dto.Cep = reader.GetString("ds_cep");
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
            string script = @"DELETE FROM tb_empresas WHERE id_empresa like @id_empresa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_empresa", id));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alterar(EmpresaDTO dto)
        {
            string script =
            @"UPDATE tb_empresas
                 SET nm_fantasia = @nm_fantasia,
                     nm_razaoSocial = @nm_razaoSocial,
                     ds_cnpj = @ds_cnpj,
                     nr_codEstadual = @nr_codEstadual,
	                 nr_telefone = @nr_telefone,
                     ds_email = @ds_email,
                     ds_cep = @ds_cep,
                     ds_bairro = @ds_bairro,
                     ds_endereco = @ds_endereco,
                     ds_pontoReferencia = @ds_pontoReferencia
               WHERE id_empresa = @id_empresa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_empresa", dto.Id));
            parms.Add(new MySqlParameter("nm_fantasia", dto.Nome));
            parms.Add(new MySqlParameter("nm_razaoSocial", dto.RazãoSocial));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));
            parms.Add(new MySqlParameter("nr_codEstadual", dto.CodEstadual));
            parms.Add(new MySqlParameter("nr_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("ds_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereço));
            parms.Add(new MySqlParameter("ds_pontoReferencia", dto.PontoDeReferencia));


            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);


        }
    }

}