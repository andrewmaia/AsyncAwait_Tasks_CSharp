namespace WindowsForm
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
            this.btnPrepararAsync = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnPrepararSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrepararAsync
            // 
            this.btnPrepararAsync.Location = new System.Drawing.Point(34, 63);
            this.btnPrepararAsync.Name = "btnPrepararAsync";
            this.btnPrepararAsync.Size = new System.Drawing.Size(243, 29);
            this.btnPrepararAsync.TabIndex = 0;
            this.btnPrepararAsync.Text = "Preparar  Café da Manhã Async";
            this.btnPrepararAsync.UseVisualStyleBackColor = true;
            this.btnPrepararAsync.Click += new System.EventHandler(this.btnPrepararAsync_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 108);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(307, 145);
            this.txtResultado.TabIndex = 1;
            // 
            // btnPrepararSync
            // 
            this.btnPrepararSync.Location = new System.Drawing.Point(34, 28);
            this.btnPrepararSync.Name = "btnPrepararSync";
            this.btnPrepararSync.Size = new System.Drawing.Size(243, 29);
            this.btnPrepararSync.TabIndex = 2;
            this.btnPrepararSync.Text = "Preparar  Café da Manhã Sync";
            this.btnPrepararSync.UseVisualStyleBackColor = true;
            this.btnPrepararSync.Click += new System.EventHandler(this.btnPrepararSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.btnPrepararSync);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnPrepararAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPrepararAsync;
        private TextBox txtResultado;
        private Button btnPrepararSync;
    }
}