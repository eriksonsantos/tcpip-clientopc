namespace clienteTCPIP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Desligar = new System.Windows.Forms.RadioButton();
            this.Ligar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trabalho final de Sistemas Distruibuidos para Automação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Desligar);
            this.groupBox1.Controls.Add(this.Ligar);
            this.groupBox1.Location = new System.Drawing.Point(42, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Desligar
            // 
            this.Desligar.AutoSize = true;
            this.Desligar.Location = new System.Drawing.Point(20, 70);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(67, 19);
            this.Desligar.TabIndex = 1;
            this.Desligar.TabStop = true;
            this.Desligar.Text = "Desligar LED";
            this.Desligar.UseVisualStyleBackColor = true;
            // 
            // Ligar
            // 
            this.Ligar.AutoSize = true;
            this.Ligar.Location = new System.Drawing.Point(20, 22);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(51, 19);
            this.Ligar.TabIndex = 0;
            this.Ligar.TabStop = true;
            this.Ligar.Text = "Ligar LED";
            this.Ligar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(533, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Desligar;
        private System.Windows.Forms.RadioButton Ligar;
        private System.Windows.Forms.Button button1;
    }
}
