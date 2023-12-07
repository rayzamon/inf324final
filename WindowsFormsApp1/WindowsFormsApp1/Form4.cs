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
    public partial class Form4 : Form
    {
        public Form4()
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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
                    
                    textBox1.Text = reader["ci"].ToString();
                    textBox2.Text = reader["nombre"].ToString();
                    textBox3.Text = reader["apellido_pat"].ToString();
                    textBox4.Text = reader["apellido_mat"].ToString();
                    textBox5.Text = reader["nota_final"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de la materia seleccionada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ci = textBox1.Text;
            string nombre = textBox2.Text;
            string apellido_pat = textBox3.Text;
            string apellido_mat = textBox4.Text;
            string nota_final = textBox5.Text;
            ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
            string resultado = ws.modificaralumno(ci, nombre, apellido_pat, apellido_mat, nota_final);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
