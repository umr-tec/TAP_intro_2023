
namespace TAP_Intro
{
    partial class SecondForm
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::TAP_Intro.Properties.Resources.UMR_TUTORIAL;
            this.pbImagen.Location = new System.Drawing.Point(155, 125);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(138, 131);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 412);
            this.Controls.Add(this.pbImagen);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondForm_FormClosing);
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.Click += new System.EventHandler(this.SecondForm_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecondForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
    }
}