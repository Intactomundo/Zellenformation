namespace WForm3_Zellenformation
{
    partial class Window
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
            this._mainBoard = new System.Windows.Forms.Panel();
            this._label1 = new System.Windows.Forms.Label();
            this._drawGrid = new System.Windows.Forms.Button();
            this._nextGen = new System.Windows.Forms.Button();
            this._previousGen = new System.Windows.Forms.Button();
            this._tableAlive = new System.Windows.Forms.TableLayoutPanel();
            this._tableDead = new System.Windows.Forms.TableLayoutPanel();
            this._patternList = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._label4 = new System.Windows.Forms.Label();
            this._label5 = new System.Windows.Forms.Label();
            this._label6 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            this._genCounter = new System.Windows.Forms.TextBox();
            this._savePattern = new System.Windows.Forms.Button();
            this._deletePattern = new System.Windows.Forms.Button();
            this._label2 = new System.Windows.Forms.Label();
            this._startStopNextGen = new System.Windows.Forms.CheckBox();
            this._dimensions = new System.Windows.Forms.NumericUpDown();
            this._myTimer = new System.Windows.Forms.Timer(this.components);
            this._loadPattern = new System.Windows.Forms.Button();
            this._label7 = new System.Windows.Forms.Label();
            this._livingCellCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimensions)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainBoard
            // 
            this._mainBoard.Location = new System.Drawing.Point(25, 35);
            this._mainBoard.Name = "_mainBoard";
            this._mainBoard.Size = new System.Drawing.Size(1002, 1002);
            this._mainBoard.TabIndex = 0;
            this._mainBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainBoard_MouseClick);
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(1148, 35);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(113, 25);
            this._label1.TabIndex = 1;
            this._label1.Text = "Dimension";
            // 
            // _drawGrid
            // 
            this._drawGrid.Location = new System.Drawing.Point(1055, 119);
            this._drawGrid.Name = "_drawGrid";
            this._drawGrid.Size = new System.Drawing.Size(296, 55);
            this._drawGrid.TabIndex = 3;
            this._drawGrid.Text = "Clear Grid";
            this._drawGrid.UseVisualStyleBackColor = true;
            this._drawGrid.Click += new System.EventHandler(this.DrawGrid_Click);
            // 
            // _nextGen
            // 
            this._nextGen.Location = new System.Drawing.Point(1055, 200);
            this._nextGen.Name = "_nextGen";
            this._nextGen.Size = new System.Drawing.Size(296, 55);
            this._nextGen.TabIndex = 4;
            this._nextGen.Text = "Next Gen";
            this._nextGen.UseVisualStyleBackColor = true;
            this._nextGen.Click += new System.EventHandler(this.NextGen_Click);
            // 
            // _previousGen
            // 
            this._previousGen.Enabled = false;
            this._previousGen.Location = new System.Drawing.Point(1055, 509);
            this._previousGen.Name = "_previousGen";
            this._previousGen.Size = new System.Drawing.Size(296, 55);
            this._previousGen.TabIndex = 5;
            this._previousGen.Text = "Previous Gen";
            this._previousGen.UseVisualStyleBackColor = true;
            // 
            // _tableAlive
            // 
            this._tableAlive.BackColor = System.Drawing.Color.LawnGreen;
            this._tableAlive.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this._tableAlive.ColumnCount = 1;
            this._tableAlive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this._tableAlive.Location = new System.Drawing.Point(1055, 586);
            this._tableAlive.Name = "_tableAlive";
            this._tableAlive.RowCount = 1;
            this._tableAlive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this._tableAlive.Size = new System.Drawing.Size(40, 40);
            this._tableAlive.TabIndex = 6;
            // 
            // _tableDead
            // 
            this._tableDead.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this._tableDead.ColumnCount = 1;
            this._tableDead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this._tableDead.Location = new System.Drawing.Point(1055, 644);
            this._tableDead.Name = "_tableDead";
            this._tableDead.RowCount = 1;
            this._tableDead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this._tableDead.Size = new System.Drawing.Size(40, 40);
            this._tableDead.TabIndex = 7;
            // 
            // _patternList
            // 
            this._patternList.FormattingEnabled = true;
            this._patternList.Location = new System.Drawing.Point(1055, 751);
            this._patternList.Name = "_patternList";
            this._patternList.Size = new System.Drawing.Size(296, 33);
            this._patternList.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // _label4
            // 
            this._label4.AutoSize = true;
            this._label4.Location = new System.Drawing.Point(1146, 601);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(59, 25);
            this._label4.TabIndex = 9;
            this._label4.Text = "Alive";
            // 
            // _label5
            // 
            this._label5.AutoSize = true;
            this._label5.Location = new System.Drawing.Point(1146, 659);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(63, 25);
            this._label5.TabIndex = 10;
            this._label5.Text = "Dead";
            // 
            // _label6
            // 
            this._label6.AutoSize = true;
            this._label6.Location = new System.Drawing.Point(1148, 714);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(92, 25);
            this._label6.TabIndex = 11;
            this._label6.Text = "Patterns";
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Location = new System.Drawing.Point(1136, 350);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(134, 25);
            this._label3.TabIndex = 12;
            this._label3.Text = "Gen Counter";
            // 
            // _genCounter
            // 
            this._genCounter.Enabled = false;
            this._genCounter.Location = new System.Drawing.Point(1055, 378);
            this._genCounter.Name = "_genCounter";
            this._genCounter.Size = new System.Drawing.Size(296, 31);
            this._genCounter.TabIndex = 13;
            this._genCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _savePattern
            // 
            this._savePattern.Location = new System.Drawing.Point(1055, 808);
            this._savePattern.Name = "_savePattern";
            this._savePattern.Size = new System.Drawing.Size(296, 55);
            this._savePattern.TabIndex = 14;
            this._savePattern.Text = "Save Pattern";
            this._savePattern.UseVisualStyleBackColor = true;
            this._savePattern.Click += new System.EventHandler(this.SavePattern_Click);
            // 
            // _deletePattern
            // 
            this._deletePattern.Location = new System.Drawing.Point(1055, 880);
            this._deletePattern.Name = "_deletePattern";
            this._deletePattern.Size = new System.Drawing.Size(296, 55);
            this._deletePattern.TabIndex = 15;
            this._deletePattern.Text = "Delete Pattern";
            this._deletePattern.UseVisualStyleBackColor = true;
            this._deletePattern.Click += new System.EventHandler(this.DeletePattern_Click);
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Location = new System.Drawing.Point(1136, 267);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(119, 25);
            this._label2.TabIndex = 17;
            this._label2.Text = "Start / Stop";
            // 
            // _startStopNextGen
            // 
            this._startStopNextGen.AutoSize = true;
            this._startStopNextGen.Location = new System.Drawing.Point(1177, 305);
            this._startStopNextGen.Name = "_startStopNextGen";
            this._startStopNextGen.Size = new System.Drawing.Size(28, 27);
            this._startStopNextGen.TabIndex = 18;
            this._startStopNextGen.UseVisualStyleBackColor = true;
            this._startStopNextGen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartStopNextGen_MouseClick);
            // 
            // _dimensions
            // 
            this._dimensions.Location = new System.Drawing.Point(1055, 73);
            this._dimensions.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._dimensions.Name = "_dimensions";
            this._dimensions.Size = new System.Drawing.Size(296, 31);
            this._dimensions.TabIndex = 19;
            this._dimensions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _myTimer
            // 
            this._myTimer.Interval = 500;
            this._myTimer.Tick += new System.EventHandler(this._myTimer_Tick);
            // 
            // _loadPattern
            // 
            this._loadPattern.Location = new System.Drawing.Point(1055, 952);
            this._loadPattern.Name = "_loadPattern";
            this._loadPattern.Size = new System.Drawing.Size(296, 55);
            this._loadPattern.TabIndex = 20;
            this._loadPattern.Text = "Load Pattern";
            this._loadPattern.UseVisualStyleBackColor = true;
            this._loadPattern.Click += new System.EventHandler(this.LoadPattern_Click);
            // 
            // _label7
            // 
            this._label7.AutoSize = true;
            this._label7.Location = new System.Drawing.Point(1093, 426);
            this._label7.Name = "_label7";
            this._label7.Size = new System.Drawing.Size(228, 25);
            this._label7.TabIndex = 12;
            this._label7.Text = "Number of Living Cells";
            // 
            // _livingCellCounter
            // 
            this._livingCellCounter.Enabled = false;
            this._livingCellCounter.Location = new System.Drawing.Point(1055, 463);
            this._livingCellCounter.Name = "_livingCellCounter";
            this._livingCellCounter.Size = new System.Drawing.Size(296, 31);
            this._livingCellCounter.TabIndex = 13;
            this._livingCellCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 1029);
            this.Controls.Add(this._loadPattern);
            this.Controls.Add(this._dimensions);
            this.Controls.Add(this._startStopNextGen);
            this.Controls.Add(this._label2);
            this.Controls.Add(this._deletePattern);
            this.Controls.Add(this._savePattern);
            this.Controls.Add(this._livingCellCounter);
            this.Controls.Add(this._label7);
            this.Controls.Add(this._genCounter);
            this.Controls.Add(this._label3);
            this.Controls.Add(this._label6);
            this.Controls.Add(this._label5);
            this.Controls.Add(this._label4);
            this.Controls.Add(this._patternList);
            this.Controls.Add(this._tableDead);
            this.Controls.Add(this._tableAlive);
            this.Controls.Add(this._previousGen);
            this.Controls.Add(this._nextGen);
            this.Controls.Add(this._drawGrid);
            this.Controls.Add(this._label1);
            this.Controls.Add(this._mainBoard);
            this.Name = "Window";
            this.Text = "Zellenformation";
            this.Shown += new System.EventHandler(this.Window_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimensions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel _mainBoard;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Button _drawGrid;
        private System.Windows.Forms.Button _nextGen;
        private System.Windows.Forms.Button _previousGen;
        private System.Windows.Forms.TableLayoutPanel _tableAlive;
        private System.Windows.Forms.TableLayoutPanel _tableDead;
        public System.Windows.Forms.ComboBox _patternList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button _deletePattern;
        private System.Windows.Forms.Button _savePattern;
        public System.Windows.Forms.TextBox _genCounter;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.Label _label6;
        private System.Windows.Forms.Label _label5;
        private System.Windows.Forms.Label _label4;
        public System.Windows.Forms.CheckBox _startStopNextGen;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.NumericUpDown _dimensions;
        private System.Windows.Forms.Timer _myTimer;
        private System.Windows.Forms.Button _loadPattern;
        public System.Windows.Forms.TextBox _livingCellCounter;
        private System.Windows.Forms.Label _label7;
    }
}

