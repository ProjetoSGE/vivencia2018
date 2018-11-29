﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
   public class EmpresaBusiness
   {
        public int Salvar(EmpresaDTO dto)
        {
            if (dto.Empresa == string.Empty)
            {
                throw new ArgumentException("Nome da Empresa é obrigatório");
            }

            if (dto.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório");
            }

            if (dto.CEP == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório");
            }

            if (dto.Bairro == string.Empty)
            {
                throw new ArgumentException("Bairro é obrigatório");
            }

            if (dto.Endereço == string.Empty)
            {
                throw new ArgumentException("Endereço é obrigatório");
            }

            if (dto.Email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório");
            }

            if (dto.PontoDeReferencia == string.Empty)
            {
                throw new ArgumentException("Ponto de Referência é obrigatório");
            }

       
            EmpresaDataBase db = new EmpresaDataBase();
            return db.Salvar(dto);

        }

        public List<EmpresaDTO> Listar()
        {
            EmpresaDataBase db = new EmpresaDataBase();
            return db.Listar();
        }

        public List<EmpresaDTO> Consultar(string nome)
        {
            EmpresaDataBase db = new EmpresaDataBase();
            return db.Consultar(nome);
        }

        public void Remover(int id)
        {
            EmpresaDataBase db = new EmpresaDataBase();
            db.Remover(id);
        }

        public void Alterar(EmpresaDTO dto)
        {
            EmpresaDataBase db = new EmpresaDataBase();
            db.Alterar(dto);

        }


   }
}
