using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection("Data Source =DESKTOP-GSHP0S4; Initial Catalog = PRUEBAEJERCICIO; Integrated Security = true;");

                cnx.Open();    //Establecer conexion con la base de datos
                MessageBox.Show("OK, tabla creada");
                
                //SqlCommand cmd = new SqlCommand("select * from Articulos", cnx);
                //cmd.ExecuteNonQuery();
                string sql = (@"create table MiTabla (Id int identity (1,1),
                                                                        Nombre nvarchar (50),
                                                                        Apellido nvarchar(50),
                                                                        FechaNac date)");

                SqlCommand cmd = new SqlCommand(sql, cnx);
                sql = "insert into MiTabla values('Yaiza', 'Martos', '1995-10-07')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("OK, nueva linea creada");

                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                    MessageBox.Show("OK, desconectado");
                }



            }
            catch (Exception exception )
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + exception.Message);
            }
            
            
        }
    }
}
