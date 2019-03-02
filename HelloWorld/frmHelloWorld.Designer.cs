namespace HelloWorld
{
    partial class frmHelloWorld
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
            this.btnMensagen = new System.Windows.Forms.Button();
            this.lblMensagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMensagen
            // 
            this.btnMensagen.Location = new System.Drawing.Point(12, 12);
            this.btnMensagen.Name = "btnMensagen";
            this.btnMensagen.Size = new System.Drawing.Size(376, 38);
            this.btnMensagen.TabIndex = 0;
            this.btnMensagen.Text = "Click Aqui";
            this.btnMensagen.UseVisualStyleBackColor = true;
            this.btnMensagen.Click += new System.EventHandler(this.BtnMensagen_Click);
            // 
            // lblMensagen
            // 
            this.lblMensagen.BackColor = System.Drawing.Color.White;
            this.lblMensagen.CausesValidation = false;
            this.lblMensagen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensagen.Location = new System.Drawing.Point(0, 93);
            this.lblMensagen.Name = "lblMensagen";
            this.lblMensagen.Size = new System.Drawing.Size(400, 60);
            this.lblMensagen.TabIndex = 1;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 153);
            this.Controls.Add(this.lblMensagen);
            this.Controls.Add(this.btnMensagen);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensagen;
        private System.Windows.Forms.Label lblMensagen;
    }
}

