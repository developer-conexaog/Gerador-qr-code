namespace Gerando_QRCode_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnGerarQRCode = new System.Windows.Forms.Button();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o texto";
            // 
            // txtDados
            // 
            this.txtDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDados.Location = new System.Drawing.Point(28, 39);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(358, 24);
            this.txtDados.TabIndex = 1;
            this.txtDados.Text = "http://www.macoratti.net";
            // 
            // btnGerarQRCode
            // 
            this.btnGerarQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarQRCode.Location = new System.Drawing.Point(28, 66);
            this.btnGerarQRCode.Name = "btnGerarQRCode";
            this.btnGerarQRCode.Size = new System.Drawing.Size(201, 44);
            this.btnGerarQRCode.TabIndex = 2;
            this.btnGerarQRCode.Text = "Gerar QRCode";
            this.btnGerarQRCode.UseVisualStyleBackColor = true;
            this.btnGerarQRCode.Click += new System.EventHandler(this.btnGerarQRCode_Click);
            // 
            // picQrCode
            // 
            this.picQrCode.BackColor = System.Drawing.Color.White;
            this.picQrCode.Location = new System.Drawing.Point(28, 117);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(201, 189);
            this.picQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQrCode.TabIndex = 3;
            this.picQrCode.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(262, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "http://www.macoratti.net";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(262, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 24);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "http://www.macoratti.net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(398, 318);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.btnGerarQRCode);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnGerarQRCode;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

