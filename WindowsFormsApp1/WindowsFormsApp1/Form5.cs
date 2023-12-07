using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += alumnoseleccionado;
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataSet ds = new DataSet();

            con.ConnectionString = "server=(local);database=alumno;user=ray;pwd=123456";
            ada.SelectCommand = new SqlCommand();
            ada.SelectCommand.Connection = con;
            ada.SelectCommand.CommandText = "SELECT * FROM alumnoinfo";
            ada.SelectCommand.CommandType = CommandType.Text;
            con.Open();
            ada.Fill(ds, "alumnoinfo");
            con.Close();

            if (ds.Tables["alumnoinfo"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["alumnoinfo"].Rows)
                {
                    comboBox1.Items.Add(row["ci"].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
        }
        private void alumnoseleccionado(object sender, EventArgs e)
        {
            try
            {
                string alumnoSeleccionada = comboBox1.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("server=(local);database=alumno;user=ray;pwd=123456");
                SqlCommand cmd = new SqlCommand("SELECT * FROM alumnoinfo WHERE ci = @ci", con);
                cmd.Parameters.AddWithValue("@ci", alumnoSeleccionada);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    label4.Text = reader["ci"].ToString();
                    label5.Text = reader["nombre"].ToString();
                   
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de la materia seleccionada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ci = label4.Text;
          
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            string resultado = ws.borralumno(ci);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
