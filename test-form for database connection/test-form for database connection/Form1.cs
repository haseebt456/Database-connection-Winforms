using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_form_for_database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Data Source=Mylaptop;Initial Catalog=Projectdb;Integrated Security=True;";
            
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string name = textBox2.Text;
            int age = int.Parse(textBox1.Text);

            string query = "insert into temp values('"+name+"','"+age+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Succesul");

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
