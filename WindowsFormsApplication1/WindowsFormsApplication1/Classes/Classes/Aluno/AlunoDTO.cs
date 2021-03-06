﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Aluno
{
    public class AlunoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Rg { get; set; }
        public string AnoDeEstudo { get; set; }
        public DateTime Nascimento { get; set; }
        public string Idade { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public bool SeEstuda { get; set; }
        public string QualCurso { get; set; }
        public string Turno { get; set; }
        public string ExpProfissional { get; set; }
        public string AreaPreferencial { get; set; }
        public string email { get; set; }
    }
}
