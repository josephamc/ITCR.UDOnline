#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFCURSO'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: viernes 18 de enero de 2013, 11:31:46 a.m.
// Dado que esta clase implementa IDispose, las clases derivadas no deben hacerlo.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDOnline.Base;

namespace ITCR.UDOnline.Datos
{
    /// <summary>
    /// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFCURSO'.
    /// </summary>
    public class cUDGDFCURSODatos : cUDGDFCURSOBase
    {


        /// <summary>
        /// Propósito: Constructor de la clase.
        /// </summary>
        public cUDGDFCURSODatos()
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
        ///		 <LI>NOM_PROFESOR</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>NOM_CURSO. May be SqlString.Null</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>ID_CURSO</LI>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Insertar()
        {
            return base.Insertar();
        }


        /// <summary>
        /// Propósito: Método Update. Actualiza una fila existente en la base de datos.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_CURSO</LI>
        ///		 <LI>NOM_PROFESOR</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>NOM_CURSO. May be SqlString.Null</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public override bool Actualizar()
        {
            return base.Actualizar();
        }


        /// <summary>
        /// Propósito: Método Eliminar. Borra una fila en la base de datos, basado en la llave primaria.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_CURSO</LI>
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
        /// Propósito: Método SELECT. Este método hace Select de una fila existente en la base de datos, basado en la llave primaria.
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>ID_CURSO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        ///		 <LI>ID_CURSO</LI>
        ///		 <LI>NOM_PROFESOR</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>NOM_CURSO</LI>
        /// </UL>
        /// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
        /// </remarks>
        public override DataTable SeleccionarUno()
        {
            return base.SeleccionarUno();
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
        ///		 <LI>ID_CURSO</LI>
        ///		 <LI>NOM_PROFESOR</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>NOM_CURSO. May be SqlString.Null</LI>
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

        //=========================================================================
        //                          Métodos agregados
        //=========================================================================
        
        /// <summary>
        /// Selecciona toda la tabla de cursos de manera detallada
        /// </summary>
        /// <returns></returns>
        public virtual DataTable Seleccionar_Todo_Detallado()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFCURSO_Seleccionar_Todo_Detallado]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFCURSO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFCURSO_Seleccionar_Todo_Detallado' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFCURSOBase::Seleccionar_Todo_Detallado::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }

        /// <summary>
        /// Indica si el nombre se encuentra ocupado
        /// </summary>
        /// <param name="p_nombre">Nombre del curso</param>
        /// <returns>Boolean Object</returns>
        public virtual Boolean Comprobar_Nombre(String p_nombre)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFCURSO_Comprobar_Nombre]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            Int32 toReturn = -1;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sNombre", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, p_nombre));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iExistente", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, toReturn));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());
                toReturn = Int32.Parse(cmdAEjecutar.Parameters["@iExistente"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento almacenado 'pr_UDGDFCURSO_Comprobar_Nombre' reportó el error Código: " + _codError);
                }

                if (toReturn == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFCURSOBase::Comprobar_Nombre::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }

        /// <summary>
        /// Selecciona toda la informacion de un curso específico de manera detallada
        /// </summary>
        /// <param name="p_ID_EVENTO">Id del curso</param>
        /// <returns>DataTable Object</returns>
        public virtual DataTable Seleccionar_Con_ID(int p_ID_CURSO)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFCURSO_Seleccionar_Con_ID]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFCURSO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_CURSO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, p_ID_CURSO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFCURSO_Seleccionar_Con_ID' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::Seleccionar_Con_ID::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }
    } //class
} //namespace
