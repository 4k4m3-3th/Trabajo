using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-178362N\\SQLEXPRESS;Database=Quiz;Trusted_Connection=True");
        public Form1()
        {
            InitializeComponent();

        }
        public class Base
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor, ingrese todos los datos.");
            }
            else
            {
                conexion.Open();
                String nombre = "INSERT INTO Productos VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "' )";
                SqlCommand comando = new SqlCommand(nombre, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados");
                conexion.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM Productos", conexion);
            MessageBox.Show("Consulta Realiza Con Exito.");
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            Tabla.DataSource = tabla;
            conexion.Close();
        }

        private void btoAct_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            conexion.Open();
            int id = Convert.ToInt32(Tabla.SelectedRows[0].Cells["ID"].Value);

            SqlCommand command = new SqlCommand("UPDATE Productos SET nombre_produc = @nombre, descripc_produc = @descripcion, precio_produc = @precio WHERE id = @id", conexion);


            command.Parameters.AddWithValue("@nombre", textBox2.Text);
            command.Parameters.AddWithValue("@descripcion", textBox3.Text);
            command.Parameters.AddWithValue("@precio", textBox4.Text);
            command.Parameters.AddWithValue("@id", textBox1.Text);


            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("El registro se actualizó correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro.");
            }
            conexion.Close();
        }

        private void btoEli_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Tabla.SelectedRows[0].Cells["ID"].Value);
                try
                {
                    using (SqlConnection connection = new SqlConnection("Server=DESKTOP-178362N\\SQLEXPRESS;Database=Quiz;Trusted_Connection=True"))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Productos WHERE id = @id", connection);
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            Tabla.Rows.RemoveAt(Tabla.SelectedRows[0].Index);
                            MessageBox.Show("El elemento se ha eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el elemento seleccionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el elemento seleccionado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un elemento para eliminar.");
            }
        }
        private void btoSal_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
