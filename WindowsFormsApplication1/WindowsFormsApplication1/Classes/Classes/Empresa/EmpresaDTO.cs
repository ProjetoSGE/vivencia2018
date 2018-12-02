using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class EmpresaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazãoSocial { get; set; }
        public string Cnpj { get; set; }
        public int CodEstadual { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Endereço { get; set; }
        public string PontoDeReferencia { get; set; }
    }
}
