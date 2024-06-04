using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {
        #region Atributos
        int año;
        string autor = string.Empty;
        string barcode = string.Empty;
        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }
        Paso estado;
        string numNormalizado = string.Empty;
        string titulo = string.Empty;
        #endregion

        #region Constructor
        public Documento(string titulo, string autor, int año, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.año = año;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            estado = Paso.Inicio;
        }
        #endregion

        #region Propiedades
        public int Año
        {
            get => this.año;
        }

        public string Autor
        {
            get => this.autor;
        }

        public string Barcode
        {
            get => this.barcode;
        }

        public Paso Estado
        {
            get => this.estado;
            set => this.estado = value;
        }

        protected string NumNormalizado
        {
            get => this.numNormalizado;
        }
        public string Titulo
        {
            get => this.titulo;
        }
        #endregion

        #region Métodos
        public bool AvanzarEstado()
        {
            bool retorno = true;

            if (this.Estado == Paso.Terminado)
            {
                retorno = false;
            }
            else 
            {
                this.Estado++;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine($"Título: {this.Titulo}.");
            texto.AppendLine($"Autor: {this.Autor}.");
            texto.AppendLine($"Año: {this.Año}.");
            texto.AppendLine($"Cód. de barras: {this.Barcode}.");

            return texto.ToString();
        }
        #endregion
    }
}