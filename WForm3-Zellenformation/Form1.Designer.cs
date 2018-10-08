namespace WForm3_Zellenformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1di = new System.Windows.Forms.Label();
            this.tb1di = new System.Windows.Forms.TextBox();
            this.btn1draw = new System.Windows.Forms.Button();
            this.btn2ng = new System.Windows.Forms.Button();
            this.btn3pg = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2alive = new System.Windows.Forms.Label();
            this.label3dead = new System.Windows.Forms.Label();
            this.label4pattern = new System.Windows.Forms.Label();
            this.label5gc = new System.Windows.Forms.Label();
            this.tb2gc = new System.Windows.Forms.TextBox();
            this.btn4sp = new System.Windows.Forms.Button();
            this.btn5dp = new System.Windows.Forms.Button();
            this.btn6cg = new System.Windows.Forms.Button();
            this.label5stst = new System.Windows.Forms.Label();
            this.cb1stst = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 1002);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // label1di
            // 
            this.label1di.AutoSize = true;
            this.label1di.Location = new System.Drawing.Point(1148, 35);
            this.label1di.Name = "label1di";
            this.label1di.Size = new System.Drawing.Size(113, 25);
            this.label1di.TabIndex = 1;
            this.label1di.Text = "Dimension";
            // 
            // tb1di
            // 
            this.tb1di.Location = new System.Drawing.Point(1055, 72);
            this.tb1di.Name = "tb1di";
            this.tb1di.Size = new System.Drawing.Size(296, 31);
            this.tb1di.TabIndex = 2;
            this.tb1di.Text = "10";
            this.tb1di.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1draw
            // 
            this.btn1draw.Location = new System.Drawing.Point(1055, 119);
            this.btn1draw.Name = "btn1draw";
            this.btn1draw.Size = new System.Drawing.Size(296, 55);
            this.btn1draw.TabIndex = 3;
            this.btn1draw.Text = "Draw Grid";
            this.btn1draw.UseVisualStyleBackColor = true;
            this.btn1draw.Click += new System.EventHandler(this.Btn1draw_Click);
            this.btn1draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn1draw_MouseDown);
            // 
            // btn2ng
            // 
            this.btn2ng.Location = new System.Drawing.Point(1055, 252);
            this.btn2ng.Name = "btn2ng";
            this.btn2ng.Size = new System.Drawing.Size(296, 55);
            this.btn2ng.TabIndex = 4;
            this.btn2ng.Text = "Next Gen";
            this.btn2ng.UseVisualStyleBackColor = true;
            // 
            // btn3pg
            // 
            this.btn3pg.Location = new System.Drawing.Point(1055, 493);
            this.btn3pg.Name = "btn3pg";
            this.btn3pg.Size = new System.Drawing.Size(296, 55);
            this.btn3pg.TabIndex = 5;
            this.btn3pg.Text = "Previous Gen";
            this.btn3pg.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LawnGreen;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1055, 570);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(40, 40);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1055, 636);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(40, 40);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1055, 754);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2alive
            // 
            this.label2alive.AutoSize = true;
            this.label2alive.Location = new System.Drawing.Point(1146, 585);
            this.label2alive.Name = "label2alive";
            this.label2alive.Size = new System.Drawing.Size(59, 25);
            this.label2alive.TabIndex = 9;
            this.label2alive.Text = "Alive";
            // 
            // label3dead
            // 
            this.label3dead.AutoSize = true;
            this.label3dead.Location = new System.Drawing.Point(1146, 651);
            this.label3dead.Name = "label3dead";
            this.label3dead.Size = new System.Drawing.Size(63, 25);
            this.label3dead.TabIndex = 10;
            this.label3dead.Text = "Dead";
            // 
            // label4pattern
            // 
            this.label4pattern.AutoSize = true;
            this.label4pattern.Location = new System.Drawing.Point(1136, 712);
            this.label4pattern.Name = "label4pattern";
            this.label4pattern.Size = new System.Drawing.Size(92, 25);
            this.label4pattern.TabIndex = 11;
            this.label4pattern.Text = "Patterns";
            // 
            // label5gc
            // 
            this.label5gc.AutoSize = true;
            this.label5gc.Location = new System.Drawing.Point(1136, 399);
            this.label5gc.Name = "label5gc";
            this.label5gc.Size = new System.Drawing.Size(134, 25);
            this.label5gc.TabIndex = 12;
            this.label5gc.Text = "Gen Counter";
            // 
            // tb2gc
            // 
            this.tb2gc.Enabled = false;
            this.tb2gc.Location = new System.Drawing.Point(1055, 445);
            this.tb2gc.Name = "tb2gc";
            this.tb2gc.Size = new System.Drawing.Size(296, 31);
            this.tb2gc.TabIndex = 13;
            this.tb2gc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn4sp
            // 
            this.btn4sp.Location = new System.Drawing.Point(1055, 809);
            this.btn4sp.Name = "btn4sp";
            this.btn4sp.Size = new System.Drawing.Size(296, 55);
            this.btn4sp.TabIndex = 14;
            this.btn4sp.Text = "Save Pattern";
            this.btn4sp.UseVisualStyleBackColor = true;
            // 
            // btn5dp
            // 
            this.btn5dp.Location = new System.Drawing.Point(1055, 881);
            this.btn5dp.Name = "btn5dp";
            this.btn5dp.Size = new System.Drawing.Size(296, 55);
            this.btn5dp.TabIndex = 15;
            this.btn5dp.Text = "Delete Pattern";
            this.btn5dp.UseVisualStyleBackColor = true;
            // 
            // btn6cg
            // 
            this.btn6cg.Location = new System.Drawing.Point(1055, 186);
            this.btn6cg.Name = "btn6cg";
            this.btn6cg.Size = new System.Drawing.Size(296, 55);
            this.btn6cg.TabIndex = 16;
            this.btn6cg.Text = "Clear Grid";
            this.btn6cg.UseVisualStyleBackColor = true;
            this.btn6cg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn6cg_MouseDown);
            // 
            // label5stst
            // 
            this.label5stst.AutoSize = true;
            this.label5stst.Location = new System.Drawing.Point(1136, 319);
            this.label5stst.Name = "label5stst";
            this.label5stst.Size = new System.Drawing.Size(119, 25);
            this.label5stst.TabIndex = 17;
            this.label5stst.Text = "Start / Stop";
            // 
            // cb1stst
            // 
            this.cb1stst.AutoSize = true;
            this.cb1stst.Location = new System.Drawing.Point(1177, 357);
            this.cb1stst.Name = "cb1stst";
            this.cb1stst.Size = new System.Drawing.Size(28, 27);
            this.cb1stst.TabIndex = 18;
            this.cb1stst.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 1029);
            this.Controls.Add(this.cb1stst);
            this.Controls.Add(this.label5stst);
            this.Controls.Add(this.btn6cg);
            this.Controls.Add(this.btn5dp);
            this.Controls.Add(this.btn4sp);
            this.Controls.Add(this.tb2gc);
            this.Controls.Add(this.label5gc);
            this.Controls.Add(this.label4pattern);
            this.Controls.Add(this.label3dead);
            this.Controls.Add(this.label2alive);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn3pg);
            this.Controls.Add(this.btn2ng);
            this.Controls.Add(this.btn1draw);
            this.Controls.Add(this.tb1di);
            this.Controls.Add(this.label1di);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Zellenformation";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1di;
        public System.Windows.Forms.TextBox tb1di;
        private System.Windows.Forms.Button btn1draw;
        private System.Windows.Forms.Button btn2ng;
        private System.Windows.Forms.Button btn3pg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn5dp;
        private System.Windows.Forms.Button btn4sp;
        public System.Windows.Forms.TextBox tb2gc;
        private System.Windows.Forms.Label label5gc;
        private System.Windows.Forms.Label label4pattern;
        private System.Windows.Forms.Label label3dead;
        private System.Windows.Forms.Label label2alive;
        private System.Windows.Forms.Button btn6cg;
        public System.Windows.Forms.CheckBox cb1stst;
        private System.Windows.Forms.Label label5stst;
    }
}

