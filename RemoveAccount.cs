using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; 
using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.Data.SqlClient; 
 
namespace knapsack_foodix 
{ 
    public partial class removeacc : Form 
    { 
        public removeacc() 
        { 
         
            InitializeComponent(); 
        }  
        private void label1_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void button1_Click(object sender, EventArgs e) 
        { 
            if (textBox1.Text != string.Empty) 
            { 
                SqlConnection con;                 if (textBox1.Text != "") 
                { 
                    con = new SqlConnection(@"Data Source=DESKTOP-NA5PEVO\SQLEXPRESS;Initial 
Catalog=Junky Junk;Integrated Security=True"); 
                    con.Open(); 
                    SqlCommand cmd = new SqlCommand("delete from SignUp where Id='" + textBox1.Text + "'", con);                     cmd.ExecuteNonQuery(); //  ExecuteNonQuery used for executing queries that does not return any data. It is used to execute the sql statements like update, insert, delete etc. 
 
                    con.Close(); 
 
                    MessageBox.Show("success"); 
                }                 else 
                { 
                    MessageBox.Show("wrong Id "); 
                } 
 
                this.Hide(); 
                Form1 f = new Form1(); 
                f.Show();             }             else 
            { 
                MessageBox.Show("Please enter value in all field.", "Error", 
MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
        }    
private void button2_Click(object sender, EventArgs e) 
        {             this.Hide();             home h = new home();             h.Show(); 
        }  
        private void textBox1_MouseClick(object sender, MouseEventArgs e) 
        { 
            textBox1.Text = ""; 
        }  
        private void removeacc_Load(object sender, EventArgs e) 
        { 
 
        }  
        private void textBox1_TextChanged(object sender, EventArgs e) 
        { 
 
        }  
        private void textBox2_TextChanged(object sender, EventArgs e) 
        { 
 
        } 
 
         
    } 
 }  
