namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equalsto = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.percentbuttom = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.Location = new System.Drawing.Point(1, 45);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(348, 31);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clear);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Teal;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Location = new System.Drawing.Point(4, 136);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(83, 54);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Teal;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Location = new System.Drawing.Point(95, 195);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(83, 54);
            this.five.TabIndex = 3;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Button);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Teal;
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dot.Location = new System.Drawing.Point(4, 309);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(83, 54);
            this.dot.TabIndex = 4;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.Button);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Teal;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Location = new System.Drawing.Point(4, 252);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(83, 54);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Teal;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.Location = new System.Drawing.Point(4, 195);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(83, 54);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Button);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Teal;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Location = new System.Drawing.Point(95, 136);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(83, 54);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Teal;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Location = new System.Drawing.Point(95, 252);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(83, 54);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Teal;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Location = new System.Drawing.Point(95, 309);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(83, 54);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button);
            // 
            // equalsto
            // 
            this.equalsto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.equalsto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.equalsto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.equalsto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.equalsto.Location = new System.Drawing.Point(185, 309);
            this.equalsto.Name = "equalsto";
            this.equalsto.Size = new System.Drawing.Size(83, 54);
            this.equalsto.TabIndex = 13;
            this.equalsto.Text = "=";
            this.equalsto.UseVisualStyleBackColor = false;
            this.equalsto.Click += new System.EventHandler(this.equals);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Teal;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Location = new System.Drawing.Point(185, 252);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(83, 54);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Teal;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Location = new System.Drawing.Point(185, 136);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(83, 54);
            this.seven.TabIndex = 11;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Teal;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Location = new System.Drawing.Point(185, 195);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(83, 54);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.division.Location = new System.Drawing.Point(277, 253);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(83, 54);
            this.division.TabIndex = 17;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.operatorClick);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplication.Location = new System.Drawing.Point(277, 196);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(83, 54);
            this.multiplication.TabIndex = 16;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.operatorClick);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addition.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addition.Location = new System.Drawing.Point(277, 80);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(83, 54);
            this.addition.TabIndex = 15;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.operatorClick);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtraction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subtraction.Location = new System.Drawing.Point(277, 139);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(83, 54);
            this.subtraction.TabIndex = 14;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.operatorClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button18.Location = new System.Drawing.Point(141, 79);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(127, 54);
            this.button18.TabIndex = 18;
            this.button18.Text = "DEL";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.delete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // percentbuttom
            // 
            this.percentbuttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percentbuttom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.percentbuttom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.percentbuttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentbuttom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.percentbuttom.Location = new System.Drawing.Point(277, 310);
            this.percentbuttom.Name = "percentbuttom";
            this.percentbuttom.Size = new System.Drawing.Size(83, 54);
            this.percentbuttom.TabIndex = 22;
            this.percentbuttom.Text = "%";
            this.percentbuttom.UseVisualStyleBackColor = false;
            this.percentbuttom.Click += new System.EventHandler(this.percent);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(372, 24);
            this.menuStrip2.TabIndex = 24;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.howToToolStripMenuItem.Text = "Close";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 372);
            this.Controls.Add(this.percentbuttom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.equalsto);
            this.Controls.Add(this.one);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.two);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.five);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equalsto;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button percentbuttom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

