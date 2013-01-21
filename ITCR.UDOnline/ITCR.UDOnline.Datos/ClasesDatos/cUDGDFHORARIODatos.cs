
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDOnline.Base;

namespace ITCR.UDOnline.Datos
{
    /// <summary>
    /// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFHORARIO'.
    /// </summary>
    public class cUDGDFHORARIODatos : cUDGDFHORARIOBase
    {


        /// <summary>
        /// Propósito: Constructor de la clase.
        /// </summary>
        public cUDGDFHORARIODatos()
            : base()
        {
            // Agregar código aquí.
        }


        /// <summary>
        /// Propósito: Método Insertar. Este método inserta una fila nueva en la base de datos.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>HRA_INICIO</LI>
        ///		 <LI>HRA_FIN</LI>
        ///		 <LI>FKY_INSTALACION</LI>
        ///		 <LI>COD_DIA</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>ID_HORARIO</LI>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Insertar()
        {
            return base.Insertar();
        }

        /// <summary>
        /// Propósito: Método Eliminar. Este método elimina una fila nueva en la base de datos.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_HORARIO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Eliminar()
        {
            return base.Eliminar();
        }


        /// <summary>
        /// Propósito: Método SeleccionarTodos. Este método va a Hacer un SELECT All de tabla.
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override DataTable SeleccionarTodos()
        {
            return base.SeleccionarTodos();
        }


        /// <summary>
        /// Propósito: Método Buscar. Este método va a Hacer un SELECT de tabla.
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_HORARIO</LI>
        ///		 <LI>HRA_INICIO</LI>
        ///		 <LI>HRA_FIN</LI>
        ///		 <LI>FKY_INSTALACION</LI>
        ///		 <LI>COD_DIA</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override DataTable Buscar()
        {
            //TODO: agregar % para busqueda de campos string (varchar, etc.) con LIKE (el procedimiento ya lo hace), así:
            //if (!base.DescripcionCF.IsNull) {
            //    base.DescripcionCF = "{0}" + base.DescripcionCF + "{0}"; }
            return base.Buscar();
        }
    } //class
} //namespace
