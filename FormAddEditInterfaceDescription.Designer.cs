namespace Schnittstellen
{
    partial class FormAddEditInterfaceDescription
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.editInterfaceDescriptionPropertiesView1 = new Schnittstellen.View.EditInterfaceDescriptionPropertiesView();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(174, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // editInterfaceDescriptionPropertiesView1
            // 
            this.editInterfaceDescriptionPropertiesView1.AvailableDevices = null;
            this.editInterfaceDescriptionPropertiesView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editInterfaceDescriptionPropertiesView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.editInterfaceDescriptionPropertiesView1.Enabled = false;
            this.editInterfaceDescriptionPropertiesView1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInterfaceDescriptionPropertiesView1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editInterfaceDescriptionPropertiesView1.Location = new System.Drawing.Point(0, 0);
            this.editInterfaceDescriptionPropertiesView1.Name = "editInterfaceDescriptionPropertiesView1";
            this.editInterfaceDescriptionPropertiesView1.Size = new System.Drawing.Size(342, 165);
            this.editInterfaceDescriptionPropertiesView1.TabIndex = 0;
            // 
            // FormAddEditInterfaceDescription
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(342, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.editInterfaceDescriptionPropertiesView1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddEditInterfaceDescription";
            this.Text = "Neue Schnittstelle";
            this.ResumeLayout(false);

        }

        #endregion

        private View.EditInterfaceDescriptionPropertiesView editInterfaceDescriptionPropertiesView1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}