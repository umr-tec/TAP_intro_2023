
namespace TAP_Intro
{
    partial class ThirdForm
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickMe.Font = new System.Drawing.Font("IBM Plex Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.Location = new System.Drawing.Point(239, 129);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(117, 58);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClickMe_MouseMove);
            // 
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 377);
            this.Controls.Add(this.btnClickMe);
            this.Name = "ThirdForm";
            this.Text = "ThirdForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
    }
}