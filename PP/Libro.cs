using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        #region Atributos
        int numPaginas;
        #endregion

        #region Constructor
        public Libro(string titulo, string autor, int año, string numNormalizado, string barcode, int numPaginas) : base(titulo, autor, año, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }
        #endregion

        #region Propiedades
        public string ISBN
        {
            get => this.NumNormalizado;
        }

        public int NumPaginas
        {
            get => this.numPaginas;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            string textoPadre = base.ToString();
            int index = textoPadre.IndexOf("Cód. de barras:");

            texto.Append(textoPadre.Substring(0, index));
            texto.AppendLine($"ISBN: {this.ISBN}");
            texto.Append(textoPadre.Substring(index));
            texto.AppendLine($"Número de páginas: {this.NumPaginas}.");

            return texto.ToString();
        }

        public static bool operator ==(Libro Libro1, Libro Libro2)
        {
            bool retorno = false;

            if (Libro1.ISBN == Libro2.ISBN || Libro1.Barcode == Libro2.Barcode || (Libro1.Titulo == Libro2.Titulo && Libro1.Autor == Libro2.Autor))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro Libro1, Libro Libro2)
        {
            return (Libro1 == Libro2);
        }
        #endregion
    }
}