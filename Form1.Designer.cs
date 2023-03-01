
namespace TAP_Intro
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbContainer1 = new System.Windows.Forms.GroupBox();
            this.gbBorder = new System.Windows.Forms.GroupBox();
            this.rb_SizableToolWindow = new System.Windows.Forms.RadioButton();
            this.rbFixedToolWindow = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbFixedD = new System.Windows.Forms.RadioButton();
            this.rdSizable = new System.Windows.Forms.RadioButton();
            this.rdNone = new System.Windows.Forms.RadioButton();
            this.bgColors = new System.Windows.Forms.GroupBox();
            this.gbNewForm = new System.Windows.Forms.GroupBox();
            this.cbTwoForms = new System.Windows.Forms.CheckBox();
            this.cbOneForm = new System.Windows.Forms.CheckBox();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.pbImagenIntro = new System.Windows.Forms.PictureBox();
            this.gbContainer1.SuspendLayout();
            this.gbBorder.SuspendLayout();
            this.bgColors.SuspendLayout();
            this.gbNewForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContainer1
            // 
            this.gbContainer1.BackColor = System.Drawing.Color.Transparent;
            this.gbContainer1.Controls.Add(this.gbNewForm);
            this.gbContainer1.Controls.Add(this.bgColors);
            this.gbContainer1.Controls.Add(this.gbBorder);
            this.gbContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbContainer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbContainer1.Font = new System.Drawing.Font("HP Simplified Hans", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContainer1.Location = new System.Drawing.Point(0, 0);
            this.gbContainer1.Name = "gbContainer1";
            this.gbContainer1.Size = new System.Drawing.Size(277, 753);
            this.gbContainer1.TabIndex = 2;
            this.gbContainer1.TabStop = false;
            this.gbContainer1.Text = "Opciones";
            // 
            // gbBorder
            // 
            this.gbBorder.Controls.Add(this.rb_SizableToolWindow);
            this.gbBorder.Controls.Add(this.rbFixedToolWindow);
            this.gbBorder.Controls.Add(this.radioButton4);
            this.gbBorder.Controls.Add(this.rbFixedD);
            this.gbBorder.Controls.Add(this.rdSizable);
            this.gbBorder.Controls.Add(this.rdNone);
            this.gbBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBorder.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBorder.Location = new System.Drawing.Point(3, 23);
            this.gbBorder.Name = "gbBorder";
            this.gbBorder.Size = new System.Drawing.Size(271, 261);
            this.gbBorder.TabIndex = 1;
            this.gbBorder.TabStop = false;
            this.gbBorder.Text = "Tipo de borde";
            this.gbBorder.Enter += new System.EventHandler(this.gbBorder_Enter);
            // 
            // rb_SizableToolWindow
            // 
            this.rb_SizableToolWindow.AutoSize = true;
            this.rb_SizableToolWindow.Location = new System.Drawing.Point(9, 167);
            this.rb_SizableToolWindow.Name = "rb_SizableToolWindow";
            this.rb_SizableToolWindow.Size = new System.Drawing.Size(148, 24);
            this.rb_SizableToolWindow.TabIndex = 5;
            this.rb_SizableToolWindow.TabStop = true;
            this.rb_SizableToolWindow.Text = "SizableToolWindow";
            this.rb_SizableToolWindow.UseVisualStyleBackColor = true;
            // 
            // rbFixedToolWindow
            // 
            this.rbFixedToolWindow.AutoSize = true;
            this.rbFixedToolWindow.Location = new System.Drawing.Point(9, 138);
            this.rbFixedToolWindow.Name = "rbFixedToolWindow";
            this.rbFixedToolWindow.Size = new System.Drawing.Size(139, 24);
            this.rbFixedToolWindow.TabIndex = 4;
            this.rbFixedToolWindow.TabStop = true;
            this.rbFixedToolWindow.Text = "FixedToolWindow";
            this.rbFixedToolWindow.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(139, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "FixedToolWindow";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbFixedD
            // 
            this.rbFixedD.AutoSize = true;
            this.rbFixedD.Location = new System.Drawing.Point(9, 80);
            this.rbFixedD.Name = "rbFixedD";
            this.rbFixedD.Size = new System.Drawing.Size(81, 24);
            this.rbFixedD.TabIndex = 2;
            this.rbFixedD.TabStop = true;
            this.rbFixedD.Text = "Fixed3D";
            this.rbFixedD.UseVisualStyleBackColor = true;
            this.rbFixedD.CheckedChanged += new System.EventHandler(this.rbFixedD_CheckedChanged);
            // 
            // rdSizable
            // 
            this.rdSizable.AutoSize = true;
            this.rdSizable.Checked = true;
            this.rdSizable.Location = new System.Drawing.Point(9, 51);
            this.rdSizable.Name = "rdSizable";
            this.rdSizable.Size = new System.Drawing.Size(86, 24);
            this.rdSizable.TabIndex = 1;
            this.rdSizable.TabStop = true;
            this.rdSizable.Text = "Ajustable";
            this.rdSizable.UseVisualStyleBackColor = true;
            this.rdSizable.CheckedChanged += new System.EventHandler(this.rdSizable_CheckedChanged);
            // 
            // rdNone
            // 
            this.rdNone.AutoSize = true;
            this.rdNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdNone.Location = new System.Drawing.Point(9, 25);
            this.rdNone.Name = "rdNone";
            this.rdNone.Size = new System.Drawing.Size(86, 24);
            this.rdNone.TabIndex = 0;
            this.rdNone.TabStop = true;
            this.rdNone.Text = "Sin borde";
            this.rdNone.UseVisualStyleBackColor = true;
            this.rdNone.CheckedChanged += new System.EventHandler(this.rdNone_CheckedChanged);
            // 
            // bgColors
            // 
            this.bgColors.Controls.Add(this.btnForeColor);
            this.bgColors.Controls.Add(this.btnColor);
            this.bgColors.Font = new System.Drawing.Font("IBM Plex Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgColors.Location = new System.Drawing.Point(3, 290);
            this.bgColors.Name = "bgColors";
            this.bgColors.Size = new System.Drawing.Size(268, 177);
            this.bgColors.TabIndex = 2;
            this.bgColors.TabStop = false;
            this.bgColors.Text = "Opciones de color";
            // 
            // gbNewForm
            // 
            this.gbNewForm.Controls.Add(this.cbTwoForms);
            this.gbNewForm.Controls.Add(this.cbOneForm);
            this.gbNewForm.Font = new System.Drawing.Font("IBM Plex Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewForm.Location = new System.Drawing.Point(3, 473);
            this.gbNewForm.Name = "gbNewForm";
            this.gbNewForm.Size = new System.Drawing.Size(268, 120);
            this.gbNewForm.TabIndex = 3;
            this.gbNewForm.TabStop = false;
            this.gbNewForm.Text = "Nuevo formulario";
            // 
            // cbTwoForms
            // 
            this.cbTwoForms.AutoSize = true;
            this.cbTwoForms.Image = global::TAP_Intro.Properties.Resources.baseline_refresh_black_18dp;
            this.cbTwoForms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTwoForms.Location = new System.Drawing.Point(9, 75);
            this.cbTwoForms.Name = "cbTwoForms";
            this.cbTwoForms.Size = new System.Drawing.Size(209, 25);
            this.cbTwoForms.TabIndex = 1;
            this.cbTwoForms.Text = "       Mostrar dos formularios";
            this.cbTwoForms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTwoForms.UseVisualStyleBackColor = true;
            this.cbTwoForms.CheckedChanged += new System.EventHandler(this.cbTwoForms_CheckedChanged);
            // 
            // cbOneForm
            // 
            this.cbOneForm.AutoSize = true;
            this.cbOneForm.Image = global::TAP_Intro.Properties.Resources.baseline_refresh_black_18dp;
            this.cbOneForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbOneForm.Location = new System.Drawing.Point(9, 28);
            this.cbOneForm.Name = "cbOneForm";
            this.cbOneForm.Size = new System.Drawing.Size(200, 25);
            this.cbOneForm.TabIndex = 0;
            this.cbOneForm.Text = "       Mostrar un formulario";
            this.cbOneForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOneForm.UseVisualStyleBackColor = true;
            this.cbOneForm.CheckedChanged += new System.EventHandler(this.cbOneForm_CheckedChanged);
            // 
            // btnForeColor
            // 
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Font = new System.Drawing.Font("IBM Plex Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForeColor.Image = global::TAP_Intro.Properties.Resources.baseline_perm_identity_black_18dp;
            this.btnForeColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForeColor.Location = new System.Drawing.Point(6, 91);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(256, 57);
            this.btnForeColor.TabIndex = 3;
            this.btnForeColor.Text = "Color de letra";
            this.btnForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForeColor.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("IBM Plex Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Image = global::TAP_Intro.Properties.Resources.baseline_perm_identity_black_18dp;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(6, 28);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(256, 57);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color de Fondo";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // pbImagenIntro
            // 
            this.pbImagenIntro.Image = global::TAP_Intro.Properties.Resources.UMR_TUTORIAL;
            this.pbImagenIntro.Location = new System.Drawing.Point(671, 631);
            this.pbImagenIntro.Name = "pbImagenIntro";
            this.pbImagenIntro.Size = new System.Drawing.Size(99, 110);
            this.pbImagenIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenIntro.TabIndex = 0;
            this.pbImagenIntro.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.gbContainer1);
            this.Controls.Add(this.pbImagenIntro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAP Intro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Click += new System.EventHandler(this.frmInicio_Click);
            this.DoubleClick += new System.EventHandler(this.frmInicio_DoubleClick);
            this.gbContainer1.ResumeLayout(false);
            this.gbBorder.ResumeLayout(false);
            this.gbBorder.PerformLayout();
            this.bgColors.ResumeLayout(false);
            this.gbNewForm.ResumeLayout(false);
            this.gbNewForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenIntro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbContainer1;
        private System.Windows.Forms.GroupBox gbBorder;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbFixedD;
        private System.Windows.Forms.RadioButton rdSizable;
        private System.Windows.Forms.RadioButton rdNone;
        private System.Windows.Forms.RadioButton rb_SizableToolWindow;
        private System.Windows.Forms.RadioButton rbFixedToolWindow;
        private System.Windows.Forms.GroupBox bgColors;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox gbNewForm;
        private System.Windows.Forms.CheckBox cbTwoForms;
        private System.Windows.Forms.CheckBox cbOneForm;
    }
}

