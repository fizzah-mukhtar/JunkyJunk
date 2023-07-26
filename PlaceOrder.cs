 using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.Data.SqlClient; using iTextSharp.text; using iTextSharp.text.pdf; using System.IO; namespace knapsack_foodix 
{ 
    public partial class placeorder : Form 
    {         double[] weight;         double[] benefit;         double[] ratio;         string[] ItemName;         double W; 
        double[] ben, wei;         int len;         double[] weightPercnt;         double[] benifitPercnt;         string[] ItemNam = new string[20];         double[] benq = new double[20];         double[] weie = new double[20];         public placeorder() 
        { 
            InitializeComponent(); 
        }         
        private void label2_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void button1_Click(object sender, EventArgs e) 
        { 
            menu m = new menu();             m.Show(); 
        }  
        private void button2_Click(object sender, EventArgs e) 
        {             
            label11.Text = "YOUR DEAL BOX IS READY!!";             dataGridView1.Rows.Clear();             button2.Visible = true;             dataGridView1.Refresh(); 
            
            dataGridView1.ColumnCount = 8;             dataGridView1.Columns[0].Name = "Items Name";             dataGridView1.Columns[1].Name = "Items Weights";             dataGridView1.Columns[2].Name = "Items Benifits";             dataGridView1.Columns[3].Name = "Items Ratio";             dataGridView1.Columns[4].Name = "Selected Weight";             dataGridView1.Columns[5].Name = "Selected Benifit";             dataGridView1.Columns[6].Name = "select Weight %";             dataGridView1.Columns[7].Name = "select Benifit %";             getcall(); 
            dataGridView1.ClearSelection(); 
        } 
        public void getcall() 
        {             try             {                 string input3 = textBox5.Text;                 ItemName = input3.Split(',').ToArray();                 string input1 = (textBox1.Text); 
                weight = input1.Split(',').Select(Double.Parse).ToArray();                 string input2 = (textBox2.Text); 
                benefit = input2.Split(',').Select(Double.Parse).ToArray(); 
                W = Convert.ToDouble(textBox3.Text);                 len = weight.Length; 
                ratio = new double[weight.Length]; //array                 for (int i = 0; i < weight.Length; ++i)                 { 
                    ratio[i] = benefit[i] / weight[i]; 
                }                 int k = 0; 
                while (k < len) // rows generate for table i.e gridview 
                { 
                    dataGridView1.Rows.Add();                     k++;                 }                 int j = 0;                 int v = len; 
                while (j < v) // putting values in grid view table 
                { 
                    dataGridView1.Rows[j].Cells[0].Value = ItemName[j];                     dataGridView1.Rows[j].Cells[1].Value = weight[j].ToString();                     dataGridView1.Rows[j].Cells[2].Value = benefit[j].ToString();                     dataGridView1.Rows[j].Cells[3].Value = ratio[j].ToString(); 
                     j++;                 }                 fill();             } 
            catch (Exception) 
            { 
                MessageBox.Show("Please make sure input is correct"); 
            }         } 
        public int getNext() 
        { // GIVE HIGHEST VALUE OF RATIO             double highest = 0;             int index = -1; 
            for (int i = 0; i < benefit.Length; ++i) 
            { 
                if (ratio[i] > highest)  
                { 
                    highest = ratio[i];                     index = i; 
                }             } 
            return index; 
        }          private void button3_Click(object sender, EventArgs e) 
        { 
           
        }  
        private void chart1_Click(object sender, EventArgs e) 
        { 
 
        }  
        private void button4_Click(object sender, EventArgs e) 
        {             this.Hide();             home h = new home();             h.Show(); 
 
        } 
 
        private void placeorder_Load(object sender, EventArgs e)         { 
 
        } 
 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)         { 
 
        } 
 
        private void button3_Click_1(object sender, EventArgs e)         { 
            Random r = new Random();             int ran = r.Next(89099, 999999); 
 
            Document doc = new Document(); 
            PdfWriter.GetInstance(doc, new FileStream("" + textBox12.Text + ".pdf", FileMode.Create));             doc.Open();  
            Paragraph a = new Paragraph("\n\n                                                          INVOICE"); 
            doc.Add(a);  
            Paragraph p = new Paragraph("                                             **** Junky Junk **** \n\n");             doc.Add(p); 
 
            Paragraph p1 = new Paragraph("                  Date  :  " + 
DateTime.Now.ToString("MM/dd/yyyy") + "\n");             doc.Add(p1); 
 
            Paragraph p2 = new Paragraph("                  Time  :  " + 
DateTime.Now.ToString("HH:mm:ss") + "\n");             doc.Add(p2); 
  
            Paragraph p90 = new Paragraph("                  Invoice number  :  " + ran + 
"\n\n"); 
            doc.Add(p90); 
 
            Paragraph p3 = new Paragraph("                  _____________________________________________  \n\n");             doc.Add(p3);  
            Paragraph p4 = new Paragraph("                  Customer " + textBox12.Text + "\n");             doc.Add(p4);  
            Paragraph po = new Paragraph("                  Product Name  :" + textBox5.Text + " 
\n"); 
            doc.Add(po); 
  
            Paragraph p7 = new Paragraph("                  Total amount  :  " + label6.Text + 
"\n\n"); 
            doc.Add(p7); 
 
            Paragraph p8 = new Paragraph("                  _____________________________________________\n\n");             doc.Add(p8);  
            Paragraph p9 = new Paragraph("                  Thanks for purchase from us ");             doc.Add(p9); 
  
   
  
            doc.Close(); 
            MessageBox.Show("success"); 
        }  
        private void textBox1_TextChanged(object sender, EventArgs e)         { 
 
        }  
        void fill() 
        { 
            double www, bbb; 
            //www save temperory weight of item which will add in array*(double[] wei)  & sum in last  
            //bbb save temperory benifit of item which will add in array*(double[] ben)  & sum in last             wei = new double[weight.Length];             //wei save value of weights             ben = new double[weight.Length];             //ben save value of benifits             double cW = 0; //current weight             double cB = 0; //current benefit              int index = 0; 
            int[] itemarray = new int[len];   // this save which item is selected  
            //  Console.WriteLine("\nItems considered: ");             while (cW < W) 
            {                 int item = getNext();        //next highest ratio                 if (item == -1) 
                { 
                    //No items left                     break;                 } 
                itemarray[index] = (item + 1);                 index++; 
                if (cW + weight[item] <= W) 
                {                     www = weight[item];                     wei[item] = www;                     bbb = benefit[item];                     ben[item] = bbb;                     cW += www;                     cB += bbb; 
                    //mark as used for the getNext() (ratio) function 
                    ratio[item] = 0; 
                }                 else 
                { 
                    Console.Beep();                     Console.Beep(); 
                    bbb = (ratio[item] * (W - cW));                     ben[item] = bbb;                     www = (W - cW);                     wei[item] = www;                     cB += bbb;                     cW += www; 
                    break;  //the knapsack is full 
                }             }             weightPercnt = new double[weight.Length];             benifitPercnt = new double[weight.Length];             for (int i = 0; i < len; i++) 
            {                 weightPercnt[i] = (wei[i] / cW) * 100;                 benifitPercnt[i] = (ben[i] / cB) * 100; 
            } 
            for (int i = 0; i < index; i++) 
            { 
                if (itemarray[i] != 0) 
                { 
                    string[] aaa = Array.ConvertAll(itemarray, element => element.ToString()).ToArray(); 
                    
                }             } 
            label6.Text = cB.ToString(); 
            
            for (int i = 0; i < len; i++) 
            {                 dataGridView1.Rows[i].Cells[4].Value = wei[i].ToString();                 dataGridView1.Rows[i].Cells[5].Value = ben[i].ToString();                 dataGridView1.Rows[i].Cells[7].Value = benifitPercnt[i].ToString();                 dataGridView1.Rows[i].Cells[6].Value = weightPercnt[i].ToString(); 
            } 
        } 
 
    }     } 
