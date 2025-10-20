using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    internal class Concurso
    {
        public string nombre_c;
        public string nombre_p;
        public string nombre_d;
        public int precio_c;
        public string status_c;
        public string calendar_c;
            public Concurso(string nombre_concurso, string persona, String dependencia, int precio, string status, string calendar)
        {
            nombre_c = nombre_concurso;
            nombre_p = persona;
            nombre_d = dependencia;
            precio_c = precio;
            status_c = status;
            calendar_c=calendar;
        }

        public void agregar_bd()
        {
            if (nombre_c != null && nombre_p != null&& nombre_d!=null&& precio_c>0&& status_c!=null&&calendar_c!=null)
            {
                string insert_query = "insert into concurso values('" + nombre_c + "','"+nombre_p+"','"+nombre_d+"',"+precio_c+",'"+status_c+",'"+calendar_c+"')";
                MessageBox.Show(insert_query);
            }
            else
            {
                MessageBox.Show("Porfavor completa todos los datos");
            };

            
        }


    }
}