using System;
using System.Drawing;
using System.IO;

namespace Asnsf.AdmPersonalizadora.Lib.Auxiliar
{
    public static class ImagemPlugin
    {
        public static string ConverterParaString(Image imagem)
        {
            try
            {
                if (imagem.ParseIsNullOrEmpty())
                    return string.Empty;

                using (var mStream = new MemoryStream())
                {
                    imagem.Save(mStream, imagem.RawFormat);
                    return Convert.ToBase64String(mStream.ToArray());
                }
            }
            catch (Exception) { return string.Empty; }
        }

        public static Image ConverterParaImagem(string imagemEmTexto)
        {
            try
            {
                return imagemEmTexto.ParseIsNullOrEmpty()
                    ? null
                    : Image.FromStream(new MemoryStream(Convert.FromBase64String(imagemEmTexto)));
            }
            catch (Exception) { return null; }
        }
    }
}