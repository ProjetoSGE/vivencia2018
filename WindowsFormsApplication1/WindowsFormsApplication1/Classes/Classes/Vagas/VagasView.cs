using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Vagas
{
    public class VagasView
    {
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public string NomeArea { get; set; }
        public int QuantidadeDeVaga { get; set; }
        public DateTime DataDeInicio { get; set; }
        public string Sexo { get; set; }
        public string Empresa { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime HorarioSaida { get; set; }
        public DateTime Intervalo { get; set; }
        public bool SeguroDeVida { get; set; }
        public bool AuxTransporte { get; set; }
        public bool RecRemunerado { get; set; }
        public bool ValeRefeicao { get; set; }
        public bool CestaBasica { get; set; }
        public bool ReLocal { get; set; }
        public bool AssisMedica { get; set; }
        public string NivelIngles { get; set; }
        public bool InfoOffice { get; set; }
        public bool InfoAutoCAD { get; set; }
        public bool InfoCorel { get; set; }
        public bool InfoPhotoShop { get; set; }
        public bool InfoProgramacao { get; set; }
        public string Outros { get; set; }
        public string Observacao { get; set; }
        public string CompPessoal { get; set; }
        public string Tarefas { get; set; }
    }
}
