using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ITCR.UDSystem.Negocios;

namespace ITCR.UDOnline.Negocios
{
    public class cInstalacion
    {
        /// <summary>
        /// Calcula la distancia entre dos string
        /// </summary>
        /// <param name="s">String 1 a comparar</param>
        /// <param name="t">String 2 a comparar</param>
        /// <returns>Diferencia entre s y t</returns>
        private int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= m; j++)
                {
                    
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }

        /// <summary>
        /// Busca dentro de las instalaciones los nombres similares a @p_palabra
        /// </summary>
        /// <param name="p_palabra">String a buscar</param>
        /// <returns></returns>
        public DataTable search(String p_palabra)
        {
            DataTable dtReturn = new DataTable("Instalaciones");
            cUDGDFINSTALACIONNegocios cInstalaciones = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
            DataTable dtBase = cInstalaciones.SeleccionarTodos();
        
            foreach (DataRow drRow in dtBase.Rows)
            {
                if (this.Compute(drRow[2].ToString(), p_palabra) <= 2)
                    dtReturn.Rows.Add(drRow);
            }

            return dtReturn;
        }
    }// class
}// namespace
