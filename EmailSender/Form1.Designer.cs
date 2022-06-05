namespace EmailSender
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(109, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(255, 31);
            this.txtAddress.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(109, 123);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(255, 31);
            this.txtSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asunto";
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(109, 194);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailBody.Size = new System.Drawing.Size(255, 157);
            this.txtEmailBody.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuerpo";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(162, 376);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(147, 38);
            this.BtnEnviar.TabIndex = 6;
            this.BtnEnviar.Text = "Enviar Correo";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 439);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAddress;
        private TextBox txtSubject;
        private Label label2;
        private TextBox txtEmailBody;
        private Label label3;
        private Button BtnEnviar;
    }
}