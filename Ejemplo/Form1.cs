using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Ejemplo


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public class Base
        {
            public OracleConnection conexion = new OracleConnection("Data Source=xe ; User ID = system ; Password = Akame.Jpg;");
            public void conectar()
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar: " + ex.Message);
                }
            }
            public void desconectar()
            {
                conexion.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base a = new Base();
            a.conectar();
            OracleCommand comando = new OracleCommand("agregando", a.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ID", OracleDbType.Varchar2).Value = textBox1.Text;
            comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = textBox2.Text;
            comando.Parameters.Add("APELLIDO", OracleDbType.Varchar2).Value = textBox3.Text;
            comando.Parameters.Add("PRECIO", OracleDbType.Varchar2).Value = textBox4.Text;
            OracleDataAdapter da = new OracleDataAdapter(comando);
            comando.ExecuteNonQuery();
            a.desconectar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Base a = new Base();
            a.conectar();
            OracleCommand comando = new OracleCommand("select * from productos", a.conexion);
            OracleDataAdapter da = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            a.desconectar();
        }
    }
}