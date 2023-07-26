         using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; 
 
namespace knapsack_foodix 
{ 
    public partial class home : Form 
    { 
        public home() 
        { 
            InitializeComponent(); 
        }         private int imageNumber = 1;         private void LoadNextImage() 
        { 
            if (imageNumber==5) 
            { 
                imageNumber = 1; 
            } 
            pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg",imageNumber);             imageNumber++; 
        private void pictureBox1_Click(object sender, EventArgs e) {  
        }  
        private void timer1_Tick(object sender, EventArgs e) 
        { 
            LoadNextImage(); 
        }  
        private void button1_Click(object sender, EventArgs e) 
        { 
             
        }  
        private void button2_Click(object sender, EventArgs e) 
        { 
            
        }  
        private void button5_Click(object sender, EventArgs e) 
        { 
            Form1 f = new Form1(); 
            f.Show();             this.Hide(); 
        }  
        private void button3_Click(object sender, EventArgs e) 
        { 
            
 
        }  
        private void button4_Click(object sender, EventArgs e) 
        { 
        }  
        private void button6_Click(object sender, EventArgs e) 
        { 
            menu m = new menu();             m.Show();             this.Hide(); 
 
        }  
        private void button1_Click_1(object sender, EventArgs e) 
        { 
            placeorder pc = new placeorder();             this.Hide();             pc.Show(); 
 
        }  
        private void button3_Click_1(object sender, EventArgs e) 
        { 
 
            Verify v = new Verify(); 
 
            this.Hide(); 
            v.Show(); 
             
        }  
        private void button2_Click_1(object sender, EventArgs e) 
        { about ab = new about();             ab.Show();             this.Hide(); 
 
        }  
        private void pictureBox2_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void label1_Click_1(object sender, EventArgs e) 
        { 
 
        }  
        private void panel1_Paint(object sender, PaintEventArgs e) 
        { 
 
        } 
    } 
} 
