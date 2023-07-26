   using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; namespace knapsack_foodix 
{ 
    public partial class menu : Form 
    { 
        public menu() 
        { 
            InitializeComponent(); 
        }  
        private void button1_Click(object sender, EventArgs e) 
        { 
            placeorder pc = new placeorder();             pc.Show();             this.Hide(); 
 
        }  
        private void button2_Click(object sender, EventArgs e) 
        { 
            home h = new home();             h.Show();             this.Hide(); 
        }  
        private void menu_Load(object sender, EventArgs e) 
        { 
 
        }  
        private void pictureBox1_Click(object sender, EventArgs e) 
        { 
 
        } 
    } 
} 
