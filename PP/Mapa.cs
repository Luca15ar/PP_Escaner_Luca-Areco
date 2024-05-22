using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        #region Atributos
        int alto;
        int ancho;
        #endregion

        #region Constructor
        public Mapa(string titulo, string autor, int año, string barcode, int alto, int ancho) : base(titulo, autor, año, string.Empty, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        #endregion

        #region Propiedades
        public int Alto
        {
            get => this.alto;
        }

        public int Ancho
        {
            get => this.ancho;
        }

        public int Superficie
        {
            get => this.alto * this.ancho;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.ToString());
            texto.AppendLine($"Superficie: {this.Alto} * {this.Ancho} = {this.Superficie}cm2.");

            return texto.ToString();
        }

        public static bool operator ==(Mapa Mapa1, Mapa Mapa2)
        {
            bool retorno = false;

            if (Mapa1.Barcode == Mapa2.Barcode || (Mapa1.Titulo == Mapa2.Titulo && Mapa1.Autor == Mapa2.Autor && Mapa1.Año == Mapa2.Año && Mapa1.Superficie == Mapa2.Superficie))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Mapa Mapa1, Mapa Mapa2)
        {
            return !(Mapa1 == Mapa2);
        }
        #endregion
    }
}