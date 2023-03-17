namespace K_Means_Clustering_Solver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lbxPoints = new System.Windows.Forms.ListBox();
            this.txtYPoint = new System.Windows.Forms.TextBox();
            this.txtXPoint = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(12, 274);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(1012, 406);
            this.rtxtOutput.TabIndex = 0;
            this.rtxtOutput.Text = "";
            // 
            // btnSolve
            // 
            this.btnSolve.Enabled = false;
            this.btnSolve.Location = new System.Drawing.Point(835, 69);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(129, 55);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(442, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 53);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Data Point";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDataPoints);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.lbxPoints);
            this.panel1.Controls.Add(this.txtYPoint);
            this.panel1.Controls.Add(this.txtXPoint);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSolve);
            this.panel1.Location = new System.Drawing.Point(23, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 250);
            this.panel1.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(835, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrent.Location = new System.Drawing.Point(664, 188);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(86, 23);
            this.lblCurrent.TabIndex = 10;
            this.lblCurrent.Text = "Current: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(670, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max: 20";
            // 
            // lblDataPoints
            // 
            this.lblDataPoints.AutoSize = true;
            this.lblDataPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataPoints.Location = new System.Drawing.Point(644, 38);
            this.lblDataPoints.Name = "lblDataPoints";
            this.lblDataPoints.Size = new System.Drawing.Size(121, 28);
            this.lblDataPoints.TabIndex = 8;
            this.lblDataPoints.Text = "Data Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Y - Coordinate";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblX.Location = new System.Drawing.Point(75, 69);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(110, 20);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X - Coordinate";
            // 
            // lbxPoints
            // 
            this.lbxPoints.FormattingEnabled = true;
            this.lbxPoints.ItemHeight = 20;
            this.lbxPoints.Location = new System.Drawing.Point(631, 69);
            this.lbxPoints.Name = "lbxPoints";
            this.lbxPoints.Size = new System.Drawing.Size(148, 104);
            this.lbxPoints.TabIndex = 5;
            // 
            // txtYPoint
            // 
            this.txtYPoint.Location = new System.Drawing.Point(191, 133);
            this.txtYPoint.Name = "txtYPoint";
            this.txtYPoint.Size = new System.Drawing.Size(234, 27);
            this.txtYPoint.TabIndex = 4;
            // 
            // txtXPoint
            // 
            this.txtXPoint.Location = new System.Drawing.Point(191, 69);
            this.txtXPoint.Name = "txtXPoint";
            this.txtXPoint.Size = new System.Drawing.Size(234, 27);
            this.txtXPoint.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtOutput);
            this.Name = "Form1";
            this.Text = "Solver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtxtOutput;
        private Button btnSolve;
        private Button btnAdd;
        private Panel panel1;
        private ListBox lbxPoints;
        private TextBox txtYPoint;
        private TextBox txtXPoint;
        private Label label1;
        private Label lblX;
        private Label lblDataPoints;
        private Label lblCurrent;
        private Label label2;
        private Button btnReset;
    }
}