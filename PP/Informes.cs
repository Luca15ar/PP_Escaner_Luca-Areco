using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {
        #region Métodos
        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            List<Documento> documentosPorEstado = new List<Documento>();
            extension = 0;
            StringBuilder texto = new StringBuilder();

            foreach (Documento doc in e.ListaDocumentos)
            {
                if (doc.Estado == estado)
                {
                    documentosPorEstado.Add(doc);

                    if (doc is Libro libro)
                    {
                        extension += libro.NumPaginas;
                    }
                    else if (doc is Mapa mapa)
                    {
                        extension += mapa.Superficie;
                    }

                    texto.Append(doc.ToString());
                }
            }

            cantidad = documentosPorEstado.Count;

            resumen = texto.ToString();
        }

        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }
        #endregion
    }
}