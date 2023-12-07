using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]//esto lo hace visible
    public DataSet tblAlumno()
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();
        con.ConnectionString = "server = (local); database = alumno; user = ray; pwd = 123456";
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.Connection = con;
        ada.SelectCommand.CommandText = "select * from alumnoinfo";
        ada.SelectCommand.CommandType = CommandType.Text;
        ada.Fill(ds, "alumnoinfo");
        return ds;

    }
    [WebMethod]//esto lo hace visible
    public string agrega(string ci, string nombre,string apellido_pat,string apellido_mat,string nota_final)
    {
        try
        {
            SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
       
        con.ConnectionString = "server = (local); database = alumno; user = ray; pwd = 123456";
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.Connection = con;
        ada.SelectCommand.CommandText = "INSERT INTO alumnoinfo (ci, nombre, apellido_pat,apellido_mat,nota_final) VALUES (@ci,@nombre,@apellido_pat,@apellido_mat,@nota_final)";
        ada.SelectCommand.CommandType = CommandType.Text;
        ada.SelectCommand.Parameters.AddWithValue("@ci", ci);
        ada.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
        ada.SelectCommand.Parameters.AddWithValue("@apellido_pat", apellido_pat);
        ada.SelectCommand.Parameters.AddWithValue("@apellido_mat", apellido_mat);
        ada.SelectCommand.Parameters.AddWithValue("@nota_final", nota_final);
        con.Open();
        ada.SelectCommand.ExecuteNonQuery(); // Ejecutar la consulta
        con.Close();

        return "Alumno agregado con éxito";
        }
        catch (Exception ex)
        {
            return "Error al agregar alumno: " + ex.Message;
        }
    }

    [WebMethod]//esto lo hace visible
    public string modificaralumno(string ci,string nombre,string apellido_pat,string apellido_mat,string nota_final)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter ada = new SqlDataAdapter();

            con.ConnectionString = "server = (local); database = alumno; user = ray; pwd = 123456";
            ada.SelectCommand = new SqlCommand();
            ada.SelectCommand.Connection = con;
            ada.SelectCommand.CommandText = "UPDATE alumnoinfo SET nombre=@nombre, apellido_pat=@apellido_pat,apellido_mat=@apellido_mat,nota_final=@nota_final WHERE ci=@ci";
            ada.SelectCommand.CommandType = CommandType.Text;
            ada.SelectCommand.Parameters.AddWithValue("@ci", ci);
            ada.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
            ada.SelectCommand.Parameters.AddWithValue("@apellido_pat", apellido_pat);
            ada.SelectCommand.Parameters.AddWithValue("@apellido_mat", apellido_mat);
            ada.SelectCommand.Parameters.AddWithValue("@nota_final", nota_final);
            con.Open();
            ada.SelectCommand.ExecuteNonQuery(); // Ejecutar la consulta
            con.Close();

            return "Datos modificados de alumno";
        }
        catch (Exception ex)
        {
            return "Error al modificar datos de alumno: " + ex.Message;
        }
    }

    [WebMethod]//esto lo hace visible
    public string borralumno(string ci)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter ada = new SqlDataAdapter();

            con.ConnectionString = "server = (local); database = alumno; user = ray; pwd = 123456";
            ada.SelectCommand = new SqlCommand();
            ada.SelectCommand.Connection = con;
            ada.SelectCommand.CommandText = "DELETE from alumnoinfo WHERE ci=@ci";
            ada.SelectCommand.CommandType = CommandType.Text;
            ada.SelectCommand.Parameters.AddWithValue("@ci", ci);
            con.Open();
            ada.SelectCommand.ExecuteNonQuery(); // Ejecutar la consulta
            con.Close();

            return "Alumno eliminado";
        }
        catch (Exception ex)
        {
            return "No se pudo eliminar al alumno: " + ex.Message;
        }
    }
}
