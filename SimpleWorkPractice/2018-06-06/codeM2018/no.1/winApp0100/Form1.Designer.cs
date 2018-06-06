namespace winApp0100
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
            this.pdf2img = new System.Windows.Forms.Button();
            this.emf2pdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdf2img
            // 
            this.pdf2img.Location = new System.Drawing.Point(60, 45);
            this.pdf2img.Name = "pdf2img";
            this.pdf2img.Size = new System.Drawing.Size(75, 23);
            this.pdf2img.TabIndex = 0;
            this.pdf2img.Text = "pdf2img";
            this.pdf2img.UseVisualStyleBackColor = true;
            this.pdf2img.Click += new System.EventHandler(this.pdf2img_Click);
            // 
            // emf2pdf
            // 
            this.emf2pdf.Location = new System.Drawing.Point(186, 45);
            this.emf2pdf.Name = "emf2pdf";
            this.emf2pdf.Size = new System.Drawing.Size(75, 23);
            this.emf2pdf.TabIndex = 1;
            this.emf2pdf.Text = "emf2pdf";
            this.emf2pdf.UseVisualStyleBackColor = true;
            this.emf2pdf.Click += new System.EventHandler(this.emf2pdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 369);
            this.Controls.Add(this.emf2pdf);
            this.Controls.Add(this.pdf2img);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pdf2img;
        private System.Windows.Forms.Button emf2pdf;
    }
}

