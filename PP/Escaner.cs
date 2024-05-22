using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        #region Atributos
        List<Documento> listaDocumentos;
        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }
        Departamento locacion;
        string marca = string.Empty;
        public enum TipoDoc
        {
            libro,
            mapa
        }
        TipoDoc tipo;
        #endregion

        #region Constructor
        public Escaner(string marca, TipoDoc tipo)
        {

            this.marca = marca;
            this.tipo = tipo;

            if (tipo == Escaner.TipoDoc.mapa)
            {
                locacion = Departamento.mapoteca;
            }
            else
            {
                locacion = Departamento.procesosTecnicos;
            }

            listaDocumentos = new List<Documento>();
        }
        #endregion

        #region Propiedades
        public List<Documento> ListaDocumentos
        {
            get => this.listaDocumentos;
        }

        public Departamento Locacion
        {
            get => this.locacion;
        }

        public string Marca
        {
            get => this.marca;
        }

        public TipoDoc Tipo
        {
            get => this.tipo;
        }
        #endregion

        #region Métodos
        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = true;

            if (d.Estado != Documento.Paso.Terminado)
            {
                d.AvanzarEstado();
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;

            foreach (Documento doc in e.listaDocumentos)
            {
                if (doc == d)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        public static bool operator +(Escaner e, Documento d)
        {
            bool retorno = false;

            if (e != d && d.Estado == Documento.Paso.Inicio)
            {
                d.AvanzarEstado();
                e.listaDocumentos.Add(d);
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}