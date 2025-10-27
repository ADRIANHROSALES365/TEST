using Microsoft.Data.SqlClient;
using System.Data;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Creating SQl Connection
            string database_conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ad_ri\\source\\repos\\TEST\\TEST\\Database1.mdf;Integrated Security=True";

            using (SqlConnection newconnection = new SqlConnection(database_conection))
            {
                try {
                    newconnection.Open();
                    MessageBox.Show("Conexion a bd exitosa");
                }
                catch(Exception e) { 
                                 MessageBox.Show(e.Message);      
                }
                
                string query_select = "select * from concurso";
                SqlCommand command = new SqlCommand(query_select);
                command.Connection=newconnection;

                //Creaating a SQL adapter

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Binding Offline data to DataGrindView.

                DGV01.DataSource = dataTable;
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_Agregar_01_Click(object sender, EventArgs e)
        {
            alta_concurso new_alta = new alta_concurso();
            new_alta.Show();
        }
    }
}
