using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.Data.Sql; using System.Data.SqlClient; using System.Text.RegularExpressions; 
 
namespace knapsack_foodix 
{ 
    public partial class signup : Form 
    { 
        public signup() 
        { 
            InitializeComponent(); 
        } 
 private void signup_Load(object sender, EventArgs e) { 
 
        } 
  
        private void button2_Click(object sender, EventArgs e) 
        { 
            if (tb1.Text != string.Empty && tb2.Text != string.Empty && tb3.Text != string.Empty && tb4.Text != string.Empty && tb5.Text != string.Empty && tb6.Text != string.Empty)             { 
                Regex p = new Regex("^[0-9]{10}");                 bool isvalid = p.IsMatch(tb3.Text); 
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-
9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",                 RegexOptions.CultureInvariant | RegexOptions.Singleline); 
                bool isValidEmail = regex.IsMatch(tb4.Text); 
                { 
                    if (isvalid && isValidEmail) 
                    {                         try 
                        { 
                            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-
NA5PEVO\SQLEXPRESS;Initial Catalog=Junky Junk;Integrated Security=True");                             con.Open(); 
                            string newcom = "insert into 
SignUp(Firstname,Lastname,Cell,Email,Pass) VALUES('" + tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + tb4.Text + "','" + tb5.Text + "')"; 
                            SqlCommand cmd = new SqlCommand(newcom, con);                             if (tb5.Text == tb6.Text) 
                            { 
                                cmd.ExecuteNonQuery(); 
                                MessageBox.Show("Registered Successfully"); 
                            }                             else 
                                Console.WriteLine("Passwords Dont Match"); 
                        } 
                        catch (Exception ex) 
                        { 
                            MessageBox.Show(ex.Message); 
                        } 
                        this.Hide(); 
                        Form1 m = new Form1(); 
                        m.Show();                     } 
                    else if  (!isvalid || !isValidEmail) 
                        { 
                        MessageBox.Show("Invalid phone number(10 digit number) or email.", 
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    } 
                }             }             else 
            { 
                MessageBox.Show("Please enter value in all field.", "Error", 
MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
 
} 
 
        private void label6_Click(object sender, EventArgs e) 
        { 
 
        }    
        private void tb1_TextChanged(object sender, EventArgs e) 
        { 
 
        }  
        private void tb2_TextChanged(object sender, EventArgs e) 
        { 
 
        } 
    } } 
