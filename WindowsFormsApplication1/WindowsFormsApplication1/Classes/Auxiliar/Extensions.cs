using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asnsf.AdmPersonalizadora.Lib.Auxiliar
{
    public class TextValue
    {
        public string SubText { get; set; }
        public string Text { get; set; }
        public int Value { get; set; }
    }

    public class Description : Attribute
    {
        public readonly string SubText;
        public readonly string Text;
        public readonly object Value;
        public Description(string text, object value = null, string subText = "") { Text = text; Value = value; SubText = subText; }
    }

    public enum EnNameDayOfWeek
    {
        Name = 0,
        ShortName = 1,
        NumberName = 2
    }

    public enum EnTpDescription
    {
        Description = 0,
        Value = 1,
        ValueDescription = 2,
        SubDescription = 3,
        DescriptionSubDescription = 4,
        ValueDescriptionSubDescription = 5
    }

    public static class Extensions
    {
        public static IEnumerable<T> ParseToPrepend<T>(this IEnumerable<T> q, T i) { return new[] { i }.Concat(q).ToList(); }

        public static string GetDescription<T>(this T en, EnTpDescription tpEn = EnTpDescription.Description)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0)
                return en.ParseToString();

            var attrs = memInfo[0].GetCustomAttributes(typeof(Description), false);

            if (attrs.Length <= 0)
                return en.ParseToString();

            var obj = (Description)attrs[0];
            if (!obj.ParseIsNullOrEmpty())
                switch (tpEn)
                {
                    case EnTpDescription.Description:
                        return obj.Text;
                    case EnTpDescription.Value:
                        return obj.Value.ParseToString();
                    case EnTpDescription.ValueDescription:
                        return obj.Value.ParseToString().ParseToDescription(obj.Text);
                    case EnTpDescription.SubDescription:
                        return obj.SubText;
                    case EnTpDescription.DescriptionSubDescription:
                        return string.Format("{0}({1})", obj.Text, obj.SubText);
                    case EnTpDescription.ValueDescriptionSubDescription:
                        return obj.Value.ParseToString().ParseToDescription(string.Format("{0}({1})", obj.Text, obj.SubText));
                }

            return en.ParseToString();
        }

        public static string GetDescription<T>(string value, EnTpDescription tpEn = EnTpDescription.Description)
        {
            var e = GetEnumValues<T>().FirstOrDefault(i => String.Equals(i.GetDescription(EnTpDescription.Value), value, StringComparison.CurrentCultureIgnoreCase));
            return e.ParseIsNullOrEmpty() ? value : e.GetDescription(tpEn);
        }

        public static IEnumerable<T> GetEnumValues<T>() { return Enum.GetValues(typeof(T)).Cast<T>(); }

        public static T GetEnum<T>(string value)
        {
            var lE = Enum.GetValues(typeof(T)).Cast<T>();
            var e = lE.FirstOrDefault(i => (i.GetDescription(EnTpDescription.Value) == value || string.Equals(i.ParseToString(), value, StringComparison.CurrentCultureIgnoreCase)));
            return !e.ParseIsNullOrEmpty() ? e : lE.FirstOrDefault(i => i.ParseToInt() == 0);
        }

        public static T GetEnum<T>(int id)
        {
            var lE = Enum.GetValues(typeof(T)).Cast<T>();
            var e = lE.FirstOrDefault(i => i.ParseToInt() == id);
            return !e.ParseIsNullOrEmpty() ? e : lE.FirstOrDefault(i => i.ParseToInt() == 0);
        }

        public static string ParseToDescription(this string s1, string s2, string s3 = "-") { return !s2.ParseIsNullOrEmpty() ? string.Format("{0} {1} {2}", s1, s3, s2) : s1; }

        public static string ParseToRemoveFormats(this string s, string fmts = "/.- ") { return fmts.Aggregate(s, (current, c) => current.Replace(c.ToString(), string.Empty)); }

        public static string ConcatenarStrings(string s1, string s2, string s = "-") { return !s1.ParseToStringZero().ParseIsNullOrEmpty() ? (!s2.ParseIsNullOrEmpty() ? string.Format("{0} {1} {2}", s1, s, s2) : s1) : (!s2.ParseIsNullOrEmpty() ? s2 : string.Empty); }

        public static short ParseToShort(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? short.MinValue : Convert.ToInt16(p); } catch (Exception) { return 0; } }

        public static int ParseToInt(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? 0 : Convert.ToInt32(p); } catch (Exception) { return 0; } }
        public static object ParseToSqlInt(this int i) { return ((long)i).ParseToSqlLong(); }
        public static string ParseToSqlIntEquals(this int i, string s) { return i.ParseToSqlLongEquals(s); }

        public static long ParseToLong(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? 0 : Convert.ToInt64(p); } catch (Exception) { return 0; } }
        public static object ParseToSqlLong(this long l) { try { return l <= 0 ? (object)null : l; } catch (Exception) { return null; } }
        public static string ParseToSqlLongEquals(this int i, string s) { return i <= 0 ? "IS NULL" : string.Format("= {0}", s); }

        public static char ParseToChar(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? char.MinValue : Convert.ToChar(p); } catch (Exception) { return char.MinValue; } }

        public static bool ParseToBool(this object p, string pV = "") { try { return (!(p == null || p is DBNull || p.Equals(string.Empty)) && (p.ToString() == "S" || p.ParseToInt() == 1 || p.ToString().ToUpper() == "TRUE" || (!pV.ParseIsNullOrEmpty() && p.ToString() == pV))); } catch (Exception) { return false; } }

        public static decimal ParseToDecimal(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? 0 : Convert.ToDecimal(p); } catch (Exception) { return 0; } }
        public static string ParseToDecimalString(this decimal p, int nrCasas = 2) { return p.ToString(string.Format("N{0}", nrCasas)); }

        public static double ParseToDouble(this object p) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) ? 0 : Convert.ToDouble(p); } catch (Exception) { return 0; } }
        public static string ParseToDoubleString(this double p, int nrCasas = 2) { return p.ToString(string.Format("N{0}", nrCasas)); }

        public static DateTime ParseToDateTime(this object p, bool maxTime = false) { try { return p is DBNull || (p?.Equals(string.Empty) ?? true) || p.ToString() == "--/--/----" ? (maxTime ? DateTime.MaxValue : DateTime.MinValue) : Convert.ToDateTime(p); } catch (Exception) { return (maxTime ? DateTime.MaxValue : DateTime.MinValue); } }

        public static object ParseToSqlDateTime(this DateTime d) { try { if (d.IsEqualDateTimeMinMaxYMDHMS()) return null; return d; } catch (Exception) { return null; } }

        public static TimeSpan ParseToTimeSpan(this object o) { try { return o is DBNull || (o?.Equals(string.Empty) ?? true) ? TimeSpan.Zero : TimeSpan.Parse(o.ToString()); } catch (Exception) { return TimeSpan.Zero; } }

        public static TimeSpan ParseToTimeSpanOver23(this object o)
        {
            try
            {
                if (o is DBNull || (o?.Equals(string.Empty) ?? true))
                    return TimeSpan.Zero;

                var oP = o.ToString();
                if (!oP.Contains(":"))
                    return TimeSpan.Parse(oP);

                var ss = oP.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(i => i.ParseToInt()).ToList();
                return TimeSpan.FromMilliseconds(
                    (ss.Count >= 1 ? ss[0] * 60 * 60 * 1000 : 0)
                +
                    (ss.Count >= 2 ? ss[1] * 60 * 1000 : 0)
                +
                    (ss.Count >= 3 ? ss[2] * 1000 : 0)
                +
                    (ss.Count >= 4 ? ss[3] : 0)
                );
            }
            catch (Exception) { return TimeSpan.Zero; }
        }

        public static string ParseToDsHhMm(this TimeSpan hM, bool rZTime = false)
        {
            var h = (int)((hM.TotalSeconds / 60) / 60);
            var m = (int)((hM.TotalSeconds - ((h * 60) * 60)) / 60);
            return rZTime ? string.Format("{0:D2}:{1:D2}", h, m).Replace("00:00", string.Empty) : string.Format("{0:D2}:{1:D2}", h, m);
        }

        public static string ParseToDsSignalHhMm(this TimeSpan tS)
        {
            var axTs = tS.Ticks < 0 ? new TimeSpan(tS.Ticks * -1) : tS;
            return string.Format("{0}{1:D2}:{2:D2}", tS.Ticks >= 0 ? "+" : "-", axTs.Days > 0 ? ((axTs.Days * 24) + axTs.Hours) : axTs.Hours, axTs.Minutes);
        }

        public static object ParseToSqlTimeSpan(this TimeSpan tS) { try { return tS == TimeSpan.Zero ? (object)null : tS; } catch (Exception) { return null; } }

        public static bool ParseIsNullOrEmpty(this object p) { return p is DBNull || p == null || string.IsNullOrEmpty(p.ToString()) || string.IsNullOrWhiteSpace(p.ToString()); }

        public static string ParseToString(this object p) { try { return p is DBNull || p == null || (p.GetType().Name.ToUpper() == "CHAR" && p.ParseToChar() == char.MinValue) ? string.Empty : p.ToString(); } catch (Exception) { return string.Empty; } }

        public static string ParseToUtf8(this object p) { return !p.ParseIsNullOrEmpty() ? Encoding.UTF8.GetString((byte[])p) : string.Empty; }

        public static string ParseToStringZero(this object p) { try { return p is DBNull || p == null || (p.GetType().Name.ToUpper() == "CHAR" && p.ParseToChar() == char.MinValue) || p.ToString().Trim('0').ParseIsNullOrEmpty() ? string.Empty : p.ToString(); } catch (Exception) { return string.Empty; } }

        public static string ParseToShortDateString(this DateTime p) { return p == DateTime.MinValue ? string.Empty : p.ToString("dd/MM/yyyy"); }

        public static string ParseToShortTimeString(this DateTime p) { return p == DateTime.MinValue ? string.Empty : p.ToString("HH:mm:ss"); }

        public static string ParseToShortDateTimeString(this DateTime p) { return p == DateTime.MinValue ? string.Empty : string.Format("{0} às {1}", p.ToString("dd/MM/yyyy"), p.ToString("HH:mm:ss")); }

        public static string ParseRemoveFormatRgCpfCpnj(this string p) { return p.ParseIsNullOrEmpty() ? string.Empty : p.Replace(".", string.Empty).Replace("-", string.Empty).Replace("_", string.Empty).Replace("/", string.Empty).Trim(); }

        public static string ParseRemoveDateTimeFormat(this string p) { return p.Replace("/", string.Empty).Replace("-", string.Empty).Replace(":", string.Empty).Replace("_", string.Empty).Trim(); }

        public static string ParseRemoveCepFormat(this string p) { return p.Replace("-", string.Empty).Trim(); }

        public static string ParseRemoveTelCelFormat(this string p) { return p.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Trim(); }

        public static string ParseToFlag(this bool p) { return p ? "S" : "N"; }

        public static string ParseToTrue(this bool p, string t, string f = "") { return p ? t : f; }

        public static string ParseToVString(this object p, string r = null) { return !p.ParseIsNullOrEmpty() && !p.ParseToString().Trim('0').ParseIsNullOrEmpty() ? p.ParseToString().Trim() : (r ?? "--"); }

        public static string VDateTime(DateTime? p) { return p.ParseToDateTime().ParseToShortDateString(); }

        public static string ParseToFormatCpfCnpj(this string nrCpfCnpj)
        {
            return nrCpfCnpj.ParseToRemoveFormats().Length > 11
                ? nrCpfCnpj.ParseToFormatCnpj()
                : nrCpfCnpj.ParseToFormatCpf();
        }

        public static string ParseToFormatCnpj(this string nrCnpj)
        {
            if (nrCnpj.TrimStart('0').Length > 14)
                return nrCnpj;

            nrCnpj = nrCnpj.Trim().PadLeft(14, '0');
            return nrCnpj.Substring(0, 2) + "." + nrCnpj.Substring(2, 3) + "." + nrCnpj.Substring(5, 3) + "/" + nrCnpj.Substring(8, 4) + "-" + nrCnpj.Substring(12, 2);
        }

        public static string ParseToFormatCpf(this string nrCpf)
        {
            if (nrCpf?.TrimStart('0').Length > 11)
                return nrCpf;

            nrCpf = nrCpf?.Trim().PadLeft(11, '0');
            return nrCpf?.Substring(0, 3) + "." + nrCpf?.Substring(3, 3) + "." + nrCpf?.Substring(6, 3) + "-" + nrCpf?.Substring(9, 2);
        }

        public static string ParseToFormatRg(this string nrRg)
        {
            if (nrRg.TrimStart('0').Trim().Length > 9)
                return nrRg;

            nrRg = nrRg.Trim().PadLeft(9, '0');
            return nrRg.Substring(0, 2) + "." + nrRg.Substring(2, 3) + "." + nrRg.Substring(5, 3) + "-" + nrRg.Substring(8, 1);
        }

        public static string ParseToFormatPisPasep(this string nrPisPasep)
        {
            if (nrPisPasep.TrimStart('0').Length > 11)
                return nrPisPasep;

            nrPisPasep = nrPisPasep.Trim().PadLeft(11, '0');
            return nrPisPasep.Substring(0, 3) + "." + nrPisPasep.Substring(3, 3) + "." + nrPisPasep.Substring(6, 3) + "." + nrPisPasep.Substring(9, 2);
        }

        public static string ParseToFormatCep(this string nrCep)
        {
            if (nrCep.TrimStart('0').Length > 8)
                return nrCep;

            nrCep = nrCep.Trim().PadLeft(8, '0');
            return nrCep.Substring(0, 5) + "-" + nrCep.Substring(5, 3);
        }

        public static string ParseToFormatTituloEleitoral(this string nrTituloEleitoral)
        {
            if (nrTituloEleitoral.TrimStart('0').Length > 12)
                return nrTituloEleitoral;

            nrTituloEleitoral = nrTituloEleitoral.Trim().PadLeft(12, '0');
            return nrTituloEleitoral.Substring(0, 10) + "-" + nrTituloEleitoral.Substring(10, 2);
        }

        public static string ParseToFormatCel(this string nrCel)
        {
            if (nrCel.Length == 0)
                return string.Empty;

            if (nrCel.TrimStart('0').Length > 11)
                return nrCel;

            nrCel = nrCel.Trim().PadLeft(11, '0');
            return nrCel.Substring(0, 2) + " " + nrCel.Substring(2, 5) + "-" + nrCel.Substring(7, 4);
        }

        public static string ParseToFormatTel(this string nrTel)
        {
            if (nrTel.Length == 0)
                return string.Empty;

            if (nrTel.TrimStart('0').Length > 10)
                return nrTel;

            nrTel = nrTel.Trim().PadLeft(10, '0');
            return nrTel.PadLeft(10, '0').Substring(0, 2) + " " + nrTel.Substring(2, 4) + "-" + nrTel.Substring(6, 4);
        }

        public static DayOfWeek ParseToGetDayOfWeek(this int d)
        {
            switch (d)
            {
                case 1: return DayOfWeek.Monday;
                case 2: return DayOfWeek.Tuesday;
                case 3: return DayOfWeek.Wednesday;
                case 4: return DayOfWeek.Thursday;
                case 5: return DayOfWeek.Friday;
                case 6: return DayOfWeek.Saturday;
                default: return DayOfWeek.Sunday;//0
            }
        }

        public static string ParseToDayOfWeek(this DateTime dt, EnNameDayOfWeek e = EnNameDayOfWeek.Name) { return dt.DayOfWeek.ParseToDayOfWeek(e); }

        public static string ParseToDayOfWeek(this DayOfWeek dow, EnNameDayOfWeek e = EnNameDayOfWeek.Name)
        {
            switch (dow)
            {
                case DayOfWeek.Sunday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Domingo";
                        case EnNameDayOfWeek.ShortName: return "Dom";
                        default: return "D";
                    }
                case DayOfWeek.Monday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Segunda";
                        case EnNameDayOfWeek.ShortName: return "Seg";
                        default: return "2ª";
                    }
                case DayOfWeek.Tuesday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Terça";
                        case EnNameDayOfWeek.ShortName: return "Ter";
                        default: return "3ª";
                    }
                case DayOfWeek.Wednesday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Quarta";
                        case EnNameDayOfWeek.ShortName: return "Qua";
                        default: return "4ª";
                    }
                case DayOfWeek.Thursday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Quinta";
                        case EnNameDayOfWeek.ShortName: return "Qui";
                        default: return "5ª";
                    }
                case DayOfWeek.Friday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Sexta";
                        case EnNameDayOfWeek.ShortName: return "Sex";
                        default: return "6ª";
                    }
                case DayOfWeek.Saturday:
                    switch (e)
                    {
                        case EnNameDayOfWeek.Name: return "Sábado";
                        case EnNameDayOfWeek.ShortName: return "Sáb";
                        default: return "S";
                    }
            }
            return string.Empty;
        }

        public static string ParseToMonthOfYear(this DateTime dt, bool shrt = false) { return ParseToMonthOfYear(dt.Month, shrt); }

        public static string ParseToMonthOfYear(this int month, bool shrt = false)
        {
            switch (month)
            {
                case 1:
                    return shrt ? "Jan" : "Janeiro";
                case 2:
                    return shrt ? "Fev" : "Fevereiro";
                case 3:
                    return shrt ? "Mar" : "Março";
                case 4:
                    return shrt ? "Abr" : "Abril";
                case 5:
                    return shrt ? "Mai" : "Maio";
                case 6:
                    return shrt ? "Jun" : "Junho";
                case 7:
                    return shrt ? "Jul" : "Julho";
                case 8:
                    return shrt ? "Ago" : "Agosto";
                case 9:
                    return shrt ? "Set" : "Setembro";
                case 10:
                    return shrt ? "Out" : "Outubro";
                case 11:
                    return shrt ? "Nov" : "Novembro";
                case 12:
                    return shrt ? "Dez" : "Dezembro";
            }
            return string.Empty;
        }

        public static string ParseToCamelCase(this string text)
        {
            text = new CultureInfo("en-US").TextInfo.ToTitleCase(text.ToLower());

            var ignoreCases = new[] { "da", "das", "do", "dos", "a", "e", "o", "de" };
            var newText = text.Split(' ').Where(i => !i.ParseIsNullOrEmpty()).Aggregate(string.Empty, (current, i) => current + string.Format("{0} ", (ignoreCases.Any(x => x == i.ToLower()) ? i.ToLower() : i)));

            return newText.Trim();
        }

        public static string ParseRemoveDoubleString(this object text)
        {
            var t = text.ParseToString();

            while (t.Contains(new string(' ', 2)))
                t = t.Replace(new string(' ', 2), new string(' ', 1));

            return t.Trim();
        }

        public static string ParseToLength(this string txt, int length, bool addReticence = false) { return txt.ParseIsNullOrEmpty() ? string.Empty : (txt.Length > length ? (txt.Substring(0, length) + (addReticence ? "..." : string.Empty)) : txt); }

        public static string ParseToLengthAbbreviate(this string txt, int length)
        {
            if (txt.ParseIsNullOrEmpty())
                return string.Empty;

            if (!txt.Contains(' '))
                return txt.ParseToLength(length);

            var nTxt = string.Join(" ", txt.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).ParseRemoveDoubleString();
            var sSplited = nTxt.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var c = sSplited.Length - 1;
            while (nTxt.Length > length)
            {
                sSplited[c] = sSplited[c].Substring(0, 1) + ". ";
                c--;
                nTxt = string.Join(" ", sSplited).Trim();
            }

            return nTxt;
        }

        public static string ParseToLengthSubtract(this string txt, int length) { return txt.ParseIsNullOrEmpty() ? string.Empty : (txt.Length > length ? txt.Substring(0, txt.Length - length) : string.Empty); }

        public static string ParseToTakeLastDigits(this string text, int nrDigits) { return string.Concat(text.Reverse().Take(nrDigits).Reverse()); }

        public static bool ParseHasJustLetters(this string t) { return new Regex(@"^[a-zA-Z áãâäàéêëèíîïìóõôöòúûüùçÁÃÂÄÀÉÊËÈÍÎÏÌÓÕÔÖÒÚÛÜÙÇ]+$").IsMatch(t); }

        public static bool ParseHasJustNumbersWithZero(this string t) { return new Regex(@"^[0-9]+$").IsMatch(t); }

        public static bool ParseHasJustEmail(this string t) { return new Regex(@"^[a-zA-Z0-9@.-_]+$").IsMatch(t); }

        public static bool ParseIsValidCnpj(this string cnpj)
        {
            int[] m1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] m2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.ParseToRemoveFormats();

            if (cnpj.Length != 14)
                return false;

            var tCnpj = cnpj.Substring(0, 12);

            var soma = 0;
            for (var i = 0; i < 12; i++)
                soma += tCnpj[i].ParseToString().ParseToInt() * m1[i];

            var resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;

            var digito = resto.ToString();

            tCnpj = tCnpj + digito;

            soma = 0;
            for (var i = 0; i < 13; i++)
                soma += tCnpj[i].ParseToString().ParseToInt() * m2[i];

            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;

            digito = digito + resto;

            return cnpj.EndsWith(digito);
        }

        public static bool ParseIsValidCpf(this string nrCpf)
        {
            nrCpf = nrCpf.ParseRemoveFormatRgCpfCpnj();

            if (nrCpf.Length != 11)
                return false;

            var igual = true;

            for (var i = 1; i < 11 && igual; i++)
                if (nrCpf[i] != nrCpf[0])
                    igual = false;

            if (igual || nrCpf.Contains("123456789") || nrCpf.Trim('0').ParseIsNullOrEmpty() || nrCpf.Trim('1').ParseIsNullOrEmpty() || nrCpf.Trim('2').ParseIsNullOrEmpty() || nrCpf.Trim('3').ParseIsNullOrEmpty() || nrCpf.Trim('4').ParseIsNullOrEmpty() || nrCpf.Trim('5').ParseIsNullOrEmpty() || nrCpf.Trim('6').ParseIsNullOrEmpty() || nrCpf.Trim('7').ParseIsNullOrEmpty() || nrCpf.Trim('8').ParseIsNullOrEmpty() || nrCpf.Trim('9').ParseIsNullOrEmpty())
                return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            var tempCpf = nrCpf.Substring(0, 9);

            var soma = 0;
            for (var i = 0; i < 9; i++)
                soma += tempCpf[i].ParseToString().ParseToInt() * multiplicador1[i];

            var resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            var digito = resto.ParseToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (var i = 0; i < 10; i++)
                soma += tempCpf[i].ParseToString().ParseToInt() * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito = digito + resto;

            return nrCpf.EndsWith(digito);
        }

        public static string ParseRemoveAccent(this string text)
        {
            const string comAcento = "ÁÇÉÍÓÚÀÈÌÒÙÂÊÎÔÛÃÕËÜáçéíóúàèìòùâêîôûãõëü";
            const string semAcento = "ACEIOUAEIOUAEIOUAOEUaceiouaeiouaeiouaoeu";

            for (var i = 0; i < comAcento.Length; i++)
                text = text.Replace(comAcento[i], semAcento[i]);

            return text;
        }

        public static bool IsEqualDateTimeYMDHM(DateTime v1, DateTime v2)
        {
            return v1.Year == v2.Year
                && v1.Month == v2.Month
                && v1.Day == v2.Day
                && v1.Hour == v2.Hour
                && v1.Minute == v2.Minute;
        }

        public static bool IsEqualDateTimeYMDHMS(this DateTime v1, DateTime v2)
        {
            return v1.Year == v2.Year
                && v1.Month == v2.Month
                && v1.Day == v2.Day
                && v1.Hour == v2.Hour
                && v1.Minute == v2.Minute
                && v1.Second == v2.Second;
        }

        public static bool IsEqualDateTimeMinMaxYMDHMS(this DateTime dt) { return dt.IsEqualDateTimeYMDHMS(DateTime.MinValue) || dt.IsEqualDateTimeYMDHMS(DateTime.MaxValue); }

        public static string ParseToRemoveDateTimeNullFormat(this string t) { return t.Replace("--/--/----", "").Replace("--:--:--", ""); }

        public static string ParseToActiveInactive(this bool b) { return b ? "A" : "I"; }

        public static string ParseToRemoveBadLetterDiretoria(this string p) { return p.ToUpper().Replace("DIRETORIA ENSINO", string.Empty).Replace("DIRETORIA DE ENSINO", string.Empty).Replace("DIRET.ENSINO-", string.Empty).Replace("RG.", string.Empty).Replace("REG.", string.Empty).Replace("REGIAO DE", string.Empty).Replace("REGIAO", string.Empty).Trim().TrimStart('-').ParseRemoveDoubleString(); }

        public static Tuple<int, int, int> ParseToTupleFromDate(this DateTime p) { return p == DateTime.MinValue ? new Tuple<int, int, int>(0, 0, 0) : new Tuple<int, int, int>(p.Day, p.Month, p.Year); }

        public static DateTime ParseToDateFromTuple(this Tuple<int, int, int> p) { return p.Item1 > 0 && p.Item2 > 0 && p.Item3 > 0 ? new DateTime(p.Item3, p.Item2, p.Item1) : DateTime.MinValue; }

        public static DateTime ParseToLastDateInMonth(int year, int month) { return new DateTime(year, month, DateTime.DaysInMonth(year, month)); }

        public static string ParseToSqlDateTimeString(this DateTime d)
        {
            try
            {
                if (d.IsEqualDateTimeMinMaxYMDHMS())
                    return " NULL ";

                return string.Format(" CONVERT(DATETIME, '{2}-{1}-{0} {3}:{4}:{5}:{6}', 121) ",
                    d.Day.ParseToString().PadLeft(2, '0'),
                    d.Month.ParseToString().PadLeft(2, '0'),
                    d.Year.ParseToString().PadLeft(4, '0'),
                    d.Hour.ParseToString().PadLeft(2, '0'),
                    d.Minute.ParseToString().PadLeft(2, '0'),
                    d.Second.ParseToString().PadLeft(2, '0'),
                    d.Millisecond.ParseToString().PadLeft(3, '0'));
            }
            catch (Exception) { return " NULL "; }
        }

        public static long ParseJustNumericDigits(this string s) { return new string(s.Where(char.IsDigit).ToArray()).ParseToLong(); }

        public static string ParseToSqlFilterIn(this List<string> p) { return p.Aggregate(string.Empty, (current, item) => current + string.Format("'{0}',", item)).TrimEnd(','); }

        public static string ParseToDsFlag(this string value) { return value.ParseToString().ToUpper().Trim() == "S" ? "Sim" : "Não"; }

        public static string ParseToRemoveLastName(this string v)
        {
            if (v.Contains(" "))
            {
                var sWord = v.Split(' ');
                return sWord.Except(new[] { sWord.LastOrDefault() }).Aggregate((a, b) => string.Format("{0} {1}", a, b));
            }

            return v;
        }

        public static string ParseToNomeSobrenome(this string nmCompleto)
        {
            if (nmCompleto.ParseIsNullOrEmpty())
                return string.Empty;

            var qNome = nmCompleto.Trim().Split(' ');
            return nmCompleto.IndexOf(' ') >= 0 ? qNome[0] + " " + qNome[qNome.Count() - 1] : qNome[0];
        }

        public static string ParseToConcatStrings(this string s1, string s2, string s = "-") { return (!s1.ParseToStringZero().ParseIsNullOrEmpty() ? (!s2.ParseIsNullOrEmpty() ? string.Format("{0} {1} {2}", s1, s, s2) : s1) : (!s2.ParseIsNullOrEmpty() ? s2 : string.Empty)).ParseRemoveDoubleString(); }

        public static bool ParseToDateConcomitante(DateTime i1, DateTime f1, DateTime i2, DateTime f2, bool cEIguais = false)
        {
            if (cEIguais)
            {
                f1 = f1.AddSeconds(-1);
                f2 = f2.AddSeconds(-1);
            }

            return (i2 <= i1 && f2 >= i1) || (i2 >= i1 && f2 <= f1) || (i2 <= f1 && f2 >= f1);
        }

        public static bool ParseToDateBetween(this DateTime dt, DateTime i1, DateTime f1) { return (i1.Date <= dt.Date && f1.Date >= dt.Date); }

        public static bool ParseToBetween(this int num, long min, long max) { return ((long)num).ParseToBetween(min, max); }

        public static bool ParseToBetween(this long num, long min, long max) { return !(num > max || num < min); }

        public static bool ParseToBetween(this double num, double min, double max) { return !(num > max || num < min); }

        public static bool ParseToTimeConcomitante(TimeSpan i1, TimeSpan f1, TimeSpan i2, TimeSpan f2, bool cEIguais = false)
        {
            if (cEIguais)
            {
                f1 = f1.Add(new TimeSpan(0, 0, -1));
                f2 = f2.Add(new TimeSpan(0, 0, -1));
            }

            return (i2 <= i1 && f2 >= i1) || (i2 >= i1 && f2 <= f1) || (i2 <= f1 && f2 >= f1);
        }

        public static List<DateTime> GetListDates(DateTime i, DateTime f)
        {
            var lR = new List<DateTime>();
            var mC = f.Subtract(i).Days + 1;
            while (lR.Count < mC)
                lR.Add(i.AddDays(lR.Count));
            return lR;
        }

        /*
        public static string ParseToSqlIn(this List<int> v, IDataBase db, ref int nSeq)
        {
            var qR = new StringBuilder();
            for (var i = 0; i < v.Count; i++)
            {
                qR.Append(string.Format("@XYZ{0},", i + nSeq));
                db.AddParameter(string.Format("@XYZ{0}", i + nSeq), v[i]);
            }
            nSeq += v.Count;
            return qR.ToString().Trim(',');
        }

        public static string ParseToSqlIn(this List<string> v, IDataBase db, ref int nSeq)
        {
            var qR = new StringBuilder();
            for (var i = 0; i < v.Count; i++)
            {
                qR.Append(string.Format("@XYZ{0},", i + nSeq));
                db.AddParameter(string.Format("@XYZ{0}", i + nSeq), v[i], DbType.AnsiString);
            }
            nSeq += v.Count;
            return qR.ToString().Trim(',');
        }
        */

        public static string ParseToRemoveNumbers(this string s) { return new Regex(@"[0-9]").Replace(s, string.Empty); }

        public static string ParseToSqlLike(this string s) { return string.Format("%{0}%", s); }

        public static Tuple<DateTime, DateTime> ParseToRangeWeek(this DateTime dt)
        {
            DateTime dtI = dt, dtF = dt;

            if (dt.DayOfWeek == DayOfWeek.Sunday)
                dtI = dt;
            else
                do dtI = dtI.AddDays(-1); while (dtI.DayOfWeek != DayOfWeek.Sunday);

            if (dt.DayOfWeek == DayOfWeek.Saturday)
                dtF = dt;
            else
                do dtF = dtF.AddDays(1); while (dtF.DayOfWeek != DayOfWeek.Saturday);

            return new Tuple<DateTime, DateTime>(dtI, dtF);
        }

        public static string ParseToRemoveLineBreak(this string s) { return s?.Replace("\n", string.Empty); }

        public static string ParseToConcat(this List<string> lS, string c)
        {
            lS.RemoveAll(i => i.ParseIsNullOrEmpty());

            var sR = string.Empty;
            for (var i = 0; i < lS.Count; i++)
            {
                sR += lS[i];
                if (i + 1 < lS.Count)
                    sR += c;
            }
            return sR;
        }

        public static bool ParseToLastBusinessDayInMonth(this DateTime d, List<Tuple<DateTime, DateTime>> lF = null)
        {
            var lD = GetListDates(new DateTime(d.Year, d.Month, 1), new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month)));
            return lF != null
                ? !lD.Any(i => i.Date > d.Date && !new[] { DayOfWeek.Sunday, DayOfWeek.Saturday }.Contains(i.DayOfWeek) && !lF.Any(j => i.ParseToDateBetween(j.Item1, j.Item2)))
                : !lD.Any(i => i.Date > d.Date && !new[] { DayOfWeek.Sunday, DayOfWeek.Saturday }.Contains(i.DayOfWeek));
        }

        public static void SetFirstIndex(this ComboBox cBox) { cBox.SelectedIndex = cBox.Items.Count > 0 ? 0 : -1; }
    }
}