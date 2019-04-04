namespace DatanormReader
{
    partial class SettingsForm
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
            this.lblSettingsPfad = new System.Windows.Forms.Label();
            this.txtSettingsPfad = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSettingsPfad
            // 
            this.lblSettingsPfad.AutoSize = true;
            this.lblSettingsPfad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsPfad.Location = new System.Drawing.Point(3, 19);
            this.lblSettingsPfad.Name = "lblSettingsPfad";
            this.lblSettingsPfad.Size = new System.Drawing.Size(127, 16);
            this.lblSettingsPfad.TabIndex = 1;
            this.lblSettingsPfad.Text = "Datanorm Log Pfad: ";
            // 
            // txtSettingsPfad
            // 
            this.txtSettingsPfad.Enabled = false;
            this.txtSettingsPfad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSettingsPfad.Location = new System.Drawing.Point(136, 16);
            this.txtSettingsPfad.Name = "txtSettingsPfad";
            this.txtSettingsPfad.Size = new System.Drawing.Size(234, 22);
            this.txtSettingsPfad.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::DatanormReader.Properties.Resources.iconfinder_opened_folder_172515;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(376, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 22);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DatanormReader.Properties.Resources.iconfinder_floppy_285657;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "save  ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSettingsPfad);
            this.Controls.Add(this.lblSettingsPfad);
            this.Controls.Add(this.btnSave);
            this.Name = "SettingsForm";
            this.Text = "Settings Datanorm Check";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSettingsPfad;
        private System.Windows.Forms.TextBox txtSettingsPfad;
        private System.Windows.Forms.Button btnBrowse;
    }
}