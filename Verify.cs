  using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.Data.SqlClient; namespace knapsack_foodix 
{ 
    public partial class Verify : Form 
    { 
        public Verify() 
        { 
            InitializeComponent(); 
        }  
        private void Verify_Load(object sender, EventArgs e) 
        { 
 
        }  
        private void label1_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void textBox1_TextChanged(object sender, EventArgs e) 
        { 
             
        } 
 private void textBox1_MouseClick(object sender, MouseEventArgs e) { 
            textBox1.Clear(); 
        }  
        private void textBox2_MouseClick(object sender, MouseEventArgs e) 
        { 
            textBox2.Clear(); 
        }  
        private void button2_Click(object sender, EventArgs e) 
       { 
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)             { 
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOPNA5PEVO\SQLEXPRESS;Initial Catalog=Junky Junk;Integrated Security=True");                 con.Open();                 string newcom; 
                newcom = "select * from Admin where FirstName='" + textBox1.Text + "'and Id='" + int.Parse(textBox2.Text) + "'"; 
 
                SqlDataAdapter adp = new SqlDataAdapter(newcom, con); 
                DataTable dt = new DataTable();                 adp.Fill(dt); 
 
                if (dt.Rows.Count == 1) 
                { 
                    MessageBox.Show("verification  successfull");                     removeacc r = new removeacc();                     r.Show();                     this.Hide(); 
 
                }                 else 
                { 
                    MessageBox.Show("invalid Name or Id"); 
                }             } 
            else if(textBox1.Text == string.Empty || textBox2.Text == string.Empty)             { 
                MessageBox.Show("Please enter value in all field.", "Error", 
MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }         }         private void textBox2_TextChanged(object sender, EventArgs e)         { 
             
        } 
    } } 
