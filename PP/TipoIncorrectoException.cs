using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoIncorrectoException : Exception
    {
        #region Atributos
        string nombreClase;
        string nombreMetodo;
        #endregion

        #region Constructor
        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo) : base(mensaje)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        #endregion

        #region Propiedades
        public string NombreClase 
        {
            get => this.nombreClase;
        }

        public string NombreMetodo 
        {
            get => this.nombreMetodo;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine($"Excepción en el método {this.NombreMetodo} de la clase {this.NombreClase}.");
            texto.AppendLine("Algo salió mal, revisa los detalles.");
            texto.AppendLine($"Detalles: {this.InnerException}");
            texto.Append(base.ToString());

            return texto.ToString();
        }
        #endregion
    }
}
