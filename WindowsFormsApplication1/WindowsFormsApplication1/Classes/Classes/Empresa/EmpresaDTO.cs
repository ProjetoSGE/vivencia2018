using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Empresa
{
    public class EmpresaDTO
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Endereço { get; set; }
        public string PontoDeReferencia { get; set; }
    }
}
