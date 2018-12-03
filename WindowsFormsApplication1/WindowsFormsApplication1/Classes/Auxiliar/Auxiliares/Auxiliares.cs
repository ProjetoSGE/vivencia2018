using MySql.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Classes.Auxiliares
{
    public class Auxiliares
    {
        public Bitmap BotaoFechar => Properties.Resources.excluir;
    }
    public class VText
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
