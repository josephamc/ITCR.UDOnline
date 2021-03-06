#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de LOGICA DE NEGOCIOS para tabla 'UDGDFEVENTO'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: viernes 18 de enero de 2013, 11:31:46 a.m.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDOnline.Base;
using ITCR.UDOnline.Datos;
//using ITCR.UDSystem.Negocios.wsSeguridad;

namespace ITCR.UDOnline.Negocios
{
    /// <summary>
    /// Propósito: Clase de lógica de negocios para tabla 'UDGDFEVENTO'.
    /// </summary>
    public class cUDGDFEVENTONegocios : cUDGDFEVENTODatos
    {
        #region Declaraciones de miembros de la clase
        private int _COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora;
        private string _ID_USUARIOBitacora, _COD_SEDEBitacora;
        #endregion


        /// <summary>
        /// Propósito: Constructor de la clase.
        /// </summary>
        public cUDGDFEVENTONegocios(int COD_APLICACIONBitacora, string COD_SEDEBitacora, int COD_FUNCIONALIDADBitacora, string ID_USUARIOBitacora)
            : base()
        {
            //asignacion de las propiedades privadas para manejo de bitacoras
            _COD_APLICACIONBitacora = COD_APLICACIONBitacora;
            _COD_SEDEBitacora = COD_SEDEBitacora;
            _COD_FUNCIONALIDADBitacora = COD_FUNCIONALIDADBitacora;
            _ID_USUARIOBitacora = ID_USUARIOBitacora;
        }


        /// <summary>
        /// Propósito: Método Insertar de la clase de negocios. Este método inserta una fila nueva en la base de datos.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Insertar()
        {
            string operacion;
            //Seguridad wsseg = new Seguridad();
            try
            {
                //Construir aqui el string a guardar en la bitacora.
                operacion = "Insertar cUDGDFEVENTO;"
                    + "DSC_EVENTO:" + DSC_EVENTO.ToString() + ";"
                    + "NOM_EVENTO:" + NOM_EVENTO.ToString() + ";"
                    + "FKY_CALENDARIO:" + FKY_CALENDARIO.ToString() + ";"
                    + "FKY_RESERVACION:" + FKY_RESERVACION.ToString() + ";"
                    + "COD_LUNES:" + COD_LUNES.ToString() + ";"
                    + "COD_MARTES:" + COD_MARTES.ToString() + ";"
                    + "COD_MIERCOLES:" + COD_MIERCOLES.ToString() + ";"
                    + "COD_JUEVES:" + COD_JUEVES.ToString() + ";"
                    + "COD_VIERNES:" + COD_VIERNES.ToString() + ";"
                    + "COD_SABADO:" + COD_SABADO.ToString() + ";"
                    + "COD_DOMINGO:" + COD_DOMINGO.ToString() + ";";
                //wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora, operacion);
                return base.Insertar();
            }
            catch (Exception ex)
            {
                //Construir el string a guardar en la bitácora en caso de error.
                operacion = "Error Insertar cUDGDFEVENTO;" + ex.Message;
                //wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora, operacion);
                throw ex;
            }
        }


        /// <summary>
        /// Propósito: Método Update. Actualiza una fila existente en la base de datos.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Actualizar()
        {
            string operacion;
            //Seguridad wsseg = new Seguridad();
            try
            {
                //Construir aqui el string a guardar en la bitacora.
                operacion = "Actualizar cUDGDFEVENTO;"
                    + "ID_EVENTO:" + ID_EVENTO.ToString() + ";"
                    + "DSC_EVENTO:" + DSC_EVENTO.ToString() + ";"
                    + "NOM_EVENTO:" + NOM_EVENTO.ToString() + ";"
                    + "FKY_CALENDARIO:" + FKY_CALENDARIO.ToString() + ";"
                    + "FKY_RESERVACION:" + FKY_RESERVACION.ToString() + ";"
                    + "COD_LUNES:" + COD_LUNES.ToString() + ";"
                    + "COD_MARTES:" + COD_MARTES.ToString() + ";"
                    + "COD_MIERCOLES:" + COD_MIERCOLES.ToString() + ";"
                    + "COD_JUEVES:" + COD_JUEVES.ToString() + ";"
                    + "COD_VIERNES:" + COD_VIERNES.ToString() + ";"
                    + "COD_SABADO:" + COD_SABADO.ToString() + ";"
                    + "COD_DOMINGO:" + COD_DOMINGO.ToString() + ";";
                //wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora, operacion);
                return base.Actualizar();
            }
            catch (Exception ex)
            {
                //Construir el string a guardar en la bitácora en caso de error.
                operacion = "Error Actualizar cUDGDFEVENTO;" + ex.Message;
                //wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora, operacion);
                throw ex;
            }
        }


        /// <summary>
        /// Propósito: Método Eliminar de lógica de negocios. Borra una fila en la base de datos, basado en la llave primaria.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Eliminar()
        {
            string operacion;
            // Seguridad wsseg = new Seguridad();
            try
            {
                //Construir aqui el string a guardar en la bitacora.
                operacion = "Eliminar cUDGDFEVENTO;"
                    + "ID_EVENTO:" + ID_EVENTO.ToString() + ";";
                // wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora, operacion);
                return base.Eliminar();
            }
            catch (Exception ex)
            {
                //Construir el string a guardar en la bitácora en caso de error.
                operacion = "Error Eliminar cUDGDFEVENTO;" + ex.Message;
                // wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora, operacion);
                throw ex;
            }
        }


        /// <summary>
        /// Propósito: Método SELECT. Este método hace Select de una fila existente en la base de datos, basado en la llave primaria.
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        /// </UL>
        /// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
        /// </remarks>
        public override DataTable SeleccionarUno()
        {
            try
            {
                return base.SeleccionarUno();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                return base.SeleccionarTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Propósito: Método Buscar. Este método va a Hacer un SELECT LIKE de tabla.
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override DataTable Buscar()
        {
            try
            {
                return base.Buscar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //======================================================================================
        //                              Métodos agregados
        //======================================================================================

        /// <summary>
        /// Selecciona todos los eventos con la información detallada de cada uno.
        /// </summary>
        /// <returns>DataTable Object</returns>
        public override DataTable Seleccionar_Todo_Detallado()
        {
            try
            {
                return base.Seleccionar_Todo_Detallado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Comprueba si el nombre se encuentra ocupado
        /// </summary>
        /// <param name="p_nombre">Nombre del evento</param>
        /// <returns>Boolean object</returns>
        public override bool Comprobar_Nombre(string p_nombre)
        {
            try
            {
                return base.Comprobar_Nombre(p_nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Selecciona toda la informacion de un evento específico de manera detallada
        /// </summary>
        /// <param name="p_ID_EVENTO">Id del evento</param>
        /// <returns>DataTable Object</returns>
        public override DataTable Seleccionar_Con_ID(int p_ID_EVENTO)
        {
            try
            {
                return base.Seleccionar_Con_ID(p_ID_EVENTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    } //class
} //namespace
