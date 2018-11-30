using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Asnsf.AdmPersonalizadora.Lib.Entidade;
using Newtonsoft.Json;

namespace Asnsf.AdmPersonalizadora.Lib.Auxiliar
{
    public class Functions
    {
        public static void JustNumbersKDown(ref bool nNEntered, ref KeyEventArgs e)
        {
            nNEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                        nNEntered = true;
            if (Control.ModifierKeys == Keys.Shift)
                nNEntered = true;
        }
        public static void JustNumbersKPress(ref bool nNEntered, ref KeyPressEventArgs e)
        {
            if (nNEntered)
                e.Handled = true;
        }

        public static void FormatCnpj(TextBox txt)
        {
            var sValue = txt.Text.ParseToRemoveFormats();
            switch (sValue.Length)
            {
                case 14:
                    if (txt.Text.Count(i => i == '.') == 2 && txt.Text.Count(i => i == '/') == 1 && txt.Text.Count(i => i == '-') == 1)
                        return;

                    txt.MaxLength = 18;
                    txt.Text = string.Format("{0}.{1}.{2}/{3}-{4}",
                        sValue.Substring(0, 2),
                        sValue.Substring(2, 3),
                        sValue.Substring(5, 3),
                        sValue.Substring(8, 4),
                        sValue.Substring(12, 2));
                    txt.SelectionStart = txt.Text.Length;
                    break;
                case 13:
                    txt.MaxLength = 14;
                    txt.Text = sValue;
                    txt.SelectionStart = txt.Text.Length;
                    break;
            }
        }
        public static void FormatCpf(TextBox txt)
        {
            var sValue = txt.Text.ParseToRemoveFormats();
            switch (sValue.Length)
            {
                case 11:
                    if (txt.Text.Count(i => i == '.') == 2 && txt.Text.Count(i => i == '-') == 1)
                        return;

                    txt.MaxLength = 14;
                    txt.Text = string.Format("{0}.{1}.{2}-{3}",
                        sValue.Substring(0, 3),
                        sValue.Substring(3, 3),
                        sValue.Substring(6, 3),
                        sValue.Substring(9, 2));
                    txt.SelectionStart = txt.Text.Length;
                    break;
                case 10:
                    txt.MaxLength = 11;
                    txt.Text = sValue;
                    txt.SelectionStart = txt.Text.Length;
                    break;
            }
        }
        public static void FormatTel(TextBox txt)
        {
            var sValue = txt.Text.ParseToRemoveFormats();
            switch (sValue.Length)
            {
                case 10:
                    if (txt.Text.Count(i => i == '-') == 1 && txt.Text.Count(i => i == ' ') == 1)
                        return;

                    txt.MaxLength = 12;
                    txt.Text = string.Format("{0} {1}-{2}",
                        sValue.Substring(0, 2),
                        sValue.Substring(2, 4),
                        sValue.Substring(6, 4));
                    txt.SelectionStart = txt.Text.Length;
                    break;
                case 9:
                    txt.MaxLength = 10;
                    txt.Text = sValue;
                    txt.SelectionStart = txt.Text.Length;
                    break;
            }
        }
        public static void FormatCel(TextBox txt)
        {
            var sValue = txt.Text.ParseToRemoveFormats();
            switch (sValue.Length)
            {
                case 11:
                    if (txt.Text.Count(i => i == '-') == 1 && txt.Text.Count(i => i == ' ') == 2)
                        return;

                    txt.MaxLength = 14;
                    txt.Text = string.Format("{0} {1} {2}-{3}",
                        sValue.Substring(0, 2),
                        sValue.Substring(2, 1),
                        sValue.Substring(3, 4),
                        sValue.Substring(7, 4));
                    txt.SelectionStart = txt.Text.Length;
                    break;
                case 10:
                    txt.MaxLength = 11;
                    txt.Text = sValue;
                    txt.SelectionStart = txt.Text.Length;
                    break;
            }
        }
        public static void FormatCep(TextBox txt, bool gCep = false)
        {
            var sValue = txt.Text.ParseToRemoveFormats();
            switch (sValue.Length)
            {
                case 8:
                    if (gCep)
                        new Thread(() => ObterCep(sValue.ParseToInt())).Start();

                    if (txt.Text.Count(i => i == '-') == 1)
                        return;

                    txt.MaxLength = 9;
                    txt.Text = string.Format("{0}-{1}",
                        sValue.Substring(0, 5),
                        sValue.Substring(5, 3));
                    txt.SelectionStart = txt.Text.Length;
                    break;
                default:
                    txt.MaxLength = 8;
                    txt.Text = sValue;
                    txt.SelectionStart = txt.Text.Length;

                    if (gCep)
                        EvCep?.Invoke(new Cep());
                    break;
            }
        }

        public static event EvCepFound EvCep;
        public delegate void EvCepFound(Cep cep);
        public static void ObterCep(int nrCep)
        {
            var wRequest = (HttpWebRequest)WebRequest.Create(string.Format("https://viacep.com.br/ws/{0}/json/", nrCep.ToString().PadLeft(8, '0')));
            wRequest.Method = "GET";
            wRequest.ContentType = "application/x-www-form-urlencoded";
            using (var response = wRequest.GetResponse())
            {
                var rStream = response.GetResponseStream();
                if (rStream == null)
                    return;

                dynamic jObj = JsonConvert.DeserializeObject(new StreamReader(rStream).ReadToEnd());
                EvCep?.Invoke(new Cep
                {
                    Logradouro = jObj["logradouro"]?.Value,
                    Bairro = jObj["bairro"]?.Value,
                    Cidade = jObj["localidade"]?.Value,
                    Estado = jObj["uf"]?.Value
                });
            }
        }

        public static void ValidarEmailKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).Text.Length > mLength;
            else
                e.Handled = true;
        }

        public static void ValidarTextoKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                e.Handled = ((TextBox)sender).Text.Length > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }


        public static void ValidarTextoNumeroKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).Text.Length > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }

        public static void ValidarTextoNumeroEspacoKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).Text.Length > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }

        public static void ValidarNumeroKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).Text.Length > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }

        public static void ValidarDecimalKeyPress(object sender, ref KeyPressEventArgs e, int mLength, string dPermitidos = ",")
        {
            if (char.IsNumber(e.KeyChar) || dPermitidos.Contains(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).Text.Length > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }
      
        public static void ValidarSenhaKeyPress(object sender, ref KeyPressEventArgs e, int mLength)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
                e.Handled = ((TextBox)sender).TextLength > mLength && e.KeyChar != (char)Keys.Back;
            else
                e.Handled = true;
        }

        public static void ValidarCampoNulo(ref TextBox tBox, ref bool tRegNull)
        {
            if (!tRegNull)
                tRegNull = tBox.Text.ParseIsNullOrEmpty();
            tBox.BackColor = tBox.Text.ParseIsNullOrEmpty() ? Constantes.BackColorNullField : Constantes.BackColorNotNullField;
        }

        public static void ValidarCampoNulo(ref ComboBox cBox, ref bool tRegNull)
        {
            if (!tRegNull)
                tRegNull = cBox.SelectedIndex == 0;
            cBox.BackColor = cBox.SelectedIndex == 0 ? Constantes.BackColorNullField : Constantes.BackColorNotNullField;
        }

        public static List<VText> ObterListaEnum<T>(bool cFirstItemDrop = true)
        {
            var lEnum = Enum
                .GetValues(typeof(T))
                .Cast<T>()
                .Select(i => new VText
                {
                    Value = i.ParseToInt().ParseToString(),
                    Text = i.GetDescription()
                })
                .OrderBy(i => i.Text);

            return cFirstItemDrop
                ? lEnum.ParseToPrepend(Constantes.DsFirstItemDrop).ToList()
                : lEnum.ToList();
        }

        public static DataGridViewTextBoxColumn DgvTextBoxColumn(string pName, string hName, bool iVisible = true)
        {
            return new DataGridViewTextBoxColumn
            {
                ValueType = typeof(DataGridViewColumn),
                DataPropertyName = pName,
                HeaderText = hName,
                Visible = iVisible,
                ReadOnly = true
            };
        }

        public static void DgvCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgView = ((DataGridView)sender);
            var dgvColumn = dgView.Columns[e.ColumnIndex];
            if (!dgvColumn.DataPropertyName.Contains("."))
                return;
            var data = dgView.Rows[e.RowIndex].DataBoundItem;
            var properties = dgvColumn.DataPropertyName.Split('.');
            for (var i = 0; i < properties.Length && data != null; i++)
                data = data.GetType().GetProperty(properties[i]).GetValue(data);
            dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }

        public static void FecharAplicacao()
        {
            Application.Exit();
            //FAZER LOG DE ENCERRAMENTO
        }

        public static FolhaPagamentoCalculo CalcularFolhaPagamento(double nrSalario, double pAlimenticia, int nrDepIrpf, List<FolhaPagamentoCalculoList> lFPag)
        {
            var sBase = nrSalario + (lFPag?.Sum(i => i.NrProvento) ?? 0);
            var dAdicionais = (lFPag?.Sum(i => i.NrDesconto) ?? 0);
            var rInss = Constantes.RegrasInss.Select(i => new RegraInss(i) { NrSalario = sBase }).FirstOrDefault(i => sBase.ParseToBetween(i.NrSalDe, i.NrSalAte));
            var bCalculoIrpf = sBase - (rInss?.NrDesconto ?? 0) - pAlimenticia - (nrDepIrpf * Constantes.VlDependente);
            var rIrpf = Constantes.RegrasIrpf.FirstOrDefault(i => sBase.ParseToBetween(i.NrSalDe, i.NrSalAte));
            var cIrpf = (bCalculoIrpf * ((rIrpf?.NrAliquota ?? 1) / 100)) - (rIrpf?.NrDeducao ?? 0);
            var sLiquido = bCalculoIrpf - cIrpf - dAdicionais;

            return new FolhaPagamentoCalculo
            {
                NrBaseFgts = sBase,
                NrBaseCalcIrpf = bCalculoIrpf,
                NrSalContribInss = rInss?.NrDesconto ?? 0,
                AlimJudicial = pAlimenticia,
                NrTProvento = sBase,
                NrTDesconto = (sBase - sLiquido),
                NrSalLiquido = sLiquido,
                NrFgtsMes = sBase * Constantes.PctDepFgts,
                FPagList = new List<FolhaPagamentoCalculoList>
                {
                    new FolhaPagamentoCalculoList{DsInfo = "SALÁRIO", NrProvento = sBase},
                    new FolhaPagamentoCalculoList {DsInfo = "INSS", NrDesconto = (rInss?.NrDesconto ?? 0)},
                    new FolhaPagamentoCalculoList {DsInfo = "IR", NrDesconto = cIrpf}
                }.Concat(lFPag ?? new List<FolhaPagamentoCalculoList>()).ToList()
            };
        }

        public static void Wait(int x)
        {
            var t = DateTime.Now;
            var tf = DateTime.Now.AddSeconds(x);

            while (t < tf)
            {
                t = DateTime.Now;
                Application.DoEvents();
            }
        }

        public static double CalcularJurosSimples(double capital, double taxaJuros, int parcelas) => ((capital * taxaJuros * parcelas).ParseToDouble() + capital);

        public static double CalcularJurosComposto(double capital, double taxaJuros, int nrParcelas) => (capital * Math.Pow((1 + taxaJuros), nrParcelas));
    }
}