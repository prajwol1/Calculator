using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {

        float num=0, result=0;
        char choice;
        Boolean operationDone = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button(object sender, EventArgs e)
        {
            if (TextBox.Text == "0" || operationDone)
                TextBox.Clear();
            Button button = (Button)sender;
            TextBox.Text = TextBox.Text + button.Text;
            operationDone = false;
        }
        private void operatorClick(object sender, EventArgs e)
        {
            operation();
            Button button = (Button)sender;
            num = float.Parse(TextBox.Text);
            TextBox.Clear();

            choice = Convert.ToChar(button.Text);
            label1.Text = num.ToString() + choice;
            operationDone = true;
        }

        private void operation()
        {                       
            switch (choice)
            {
                case '+':
                    result = num + float.Parse(TextBox.Text);
                    TextBox.Text = result.ToString();
                    break;

                case '-':
                    result = num - float.Parse(TextBox.Text);
                    TextBox.Text = result.ToString();
                    break;
                    
                case 'X':
                    result = num * float.Parse(TextBox.Text);
                    TextBox.Text = result.ToString();
                    break;

                case '/':
                    result = num / float.Parse(TextBox.Text);
                    TextBox.Text = result.ToString();
                    break;
                default:
                    break;
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }      

        private void equals(object sender, EventArgs e)
        {
            operation();
            num = 0;
            result = 0;
            label1.Text = "";
            choice = '=';
            operationDone = true;
           
        }
        private void percent(object sender, EventArgs e)
        {
            num = float.Parse(TextBox.Text);
            TextBox.Clear();
            num = num / 100;
            TextBox.Text = num.ToString();
        }

        private void delete(object sender, EventArgs e)
        {
            int length = TextBox.TextLength;
            string text = TextBox.Text;
            TextBox.Clear();
            for (int i = 0; i< length - 1; i++) 
                TextBox.Text = TextBox.Text + text[i];
            if (length == 1)
                TextBox.Text = "0";
            operationDone = false;
        }

        private void clear(object sender, EventArgs e)
        {
            TextBox.Text="0";
            label1.Text = "";
            num = 0;
            result = 0;
            operationDone = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }      

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prajwol Shrestha");

        }

       
    }
}
