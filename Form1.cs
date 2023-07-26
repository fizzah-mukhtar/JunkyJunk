     using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.Data.SqlClient; 
 
namespace knapsack_foodix 
{ 
    public partial class Form1 : Form     { 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NA5PEVO\SQLEXPRESS;Initial 
Catalog=Junky Junk;Integrated Security=True"); 
         
        public Form1() 
        { 
            InitializeComponent(); 
 
 private void textBox1_TextChanged(object sender, EventArgs e)         { 
 
        }  
        private void textBox1_MouseClick(object sender, MouseEventArgs e) 
        { 
            textBox1.Clear(); 
        }  
        private void textBox2_MouseClick(object sender, MouseEventArgs e) 
        { 
            textBox2.Clear(); 
            textBox2.PasswordChar = '*'; 
        }  
        private void label3_Click(object sender, EventArgs e) 
        { 
            signup s = new signup();             this.Hide(); 
            s.Show(); 
        }  
        private void button2_Click(object sender, EventArgs e) 
        { 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOPNA5PEVO\SQLEXPRESS;Initial Catalog=Junky Junk;Integrated Security=True");             con.Open(); 
            string newcom = "select * from SignUp where Email='" + textBox1.Text.Trim() + "'and 
Pass='" + textBox2.Text.Trim() + "'" ; 
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con); 
            //   DataSet ds = new DataSet();             DataTable dt = new DataTable();             adp.Fill(dt); 
            if (dt.Rows.Count == 1) 
            { 
                MessageBox.Show("login successfull");                 home h = new home();                  this.Hide(); 
                h.Show();             }             else 
            { 
                MessageBox.Show("invalid email or password"); 
            } 
                  }  
        private void label4_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void Form1_Load(object sender, EventArgs e) 
        { 
 
 private void button1_Click(object sender, EventArgs e) 
        { 
            con.Open(); 
            string newcom = "select * from Admin where Email='" + textBox1.Text.Trim() + "'and 
Pass='" + textBox2.Text.Trim() + "'"; 
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con); 
            //   DataSet ds = new DataSet();             DataTable dt = new DataTable();             adp.Fill(dt); 
            if (dt.Rows.Count == 1) 
            { 
                MessageBox.Show("Admin login successfull");                 home h = new home();                 this.Hide(); 
                h.Show();             }             else 
            { 
                MessageBox.Show("invalid email or password"); 
            } 
        } 
    } } 
