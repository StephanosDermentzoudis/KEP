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

namespace ErgasiaAleph
{
    public partial class Form: System.Windows.Forms.Form
    {

        public class clearer
        {
           public bool Cleared = false;
        }

        public class menu
        {
            public bool message = false;

        }



        public Form()
        {
            InitializeComponent();
            menu menu = new menu();
            MessageBox.Show("Καλώς ήρθατε στις υπηρεσίες μας!");
            menu.message = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // gaslight


        private void Clear_Click(object sender, EventArgs e)
        {
            clearer Clearer = new clearer();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            Clearer.Cleared = true;

        }

        private void SearchRequest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\30694\\OneDrive\\Έγγραφα\\stoixeiaformas.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Pinakas where Phone=@Phone", con);
            cmd.Parameters.AddWithValue("Phone", textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void NewRequest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\30694\\OneDrive\\Έγγραφα\\stoixeiaformas.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Pinakas values (@Name,@Surname,@Email,@Phone,@Adress,@DateofBirth,@Request,@DateTimeofRequest)", con);
            cmd.Parameters.AddWithValue("@Name", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Surname", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Email", (textBox3.Text));
            cmd.Parameters.AddWithValue("@Phone", (textBox4.Text));
            cmd.Parameters.AddWithValue("@Adress", (textBox5.Text));
            cmd.Parameters.AddWithValue("@DateofBirth", (textBox6.Text));
            cmd.Parameters.AddWithValue("@Request", (textBox7.Text));
            cmd.Parameters.AddWithValue("@DateTimeofRequest", (textBox8.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Αίτημα ελήφθη");
        }

        private void ModifyEntry_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\30694\\OneDrive\\Έγγραφα\\stoixeiaformas.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Pinakas set Name=@Name, Surname=@Surname, Email=@Email, Adress=@Adress, DateofBirth=@DateofBirth, Request=@Request, DateTimeofRequest=@DateTimeofRequest where Phone=@Phone", con);
            cmd.Parameters.AddWithValue("@Name", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Surname", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Email", (textBox3.Text));
            cmd.Parameters.AddWithValue("@Phone", (textBox4.Text));
            cmd.Parameters.AddWithValue("@Adress", (textBox5.Text));
            cmd.Parameters.AddWithValue("@DateofBirth", (textBox6.Text));
            cmd.Parameters.AddWithValue("@Request", (textBox7.Text));
            cmd.Parameters.AddWithValue("@DateTimeofRequest", (textBox8.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Τροποποίηση ολοκληρώθηκε");
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\30694\\OneDrive\\Έγγραφα\\stoixeiaformas.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Pinakas where Phone=@Phone", con);
            cmd.Parameters.AddWithValue("@Phone", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Εγγραφή Διεγράφη");

        }

        private void ShowAllRequests_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\30694\\OneDrive\\Έγγραφα\\stoixeiaformas.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Pinakas", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
