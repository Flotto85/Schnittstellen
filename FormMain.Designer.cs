namespace Schnittstellen
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektöffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektspeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenschaftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.projectExplorerViewMain = new Schnittstellen.View.ProjectExplorerView();
            this.interfaceDescriptionEditorView1 = new Schnittstellen.View.InterfaceDescriptionEditorView();
            this.panelSpacer = new System.Windows.Forms.Panel();
            this.panelSpacerBottom = new System.Windows.Forms.Panel();
            this.geräteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStripMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.projektToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1234, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateiToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesProjektToolStripMenuItem,
            this.projektöffnenToolStripMenuItem,
            this.projektspeichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuesProjektToolStripMenuItem
            // 
            this.neuesProjektToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.neuesProjektToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.neuesProjektToolStripMenuItem.Name = "neuesProjektToolStripMenuItem";
            this.neuesProjektToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.neuesProjektToolStripMenuItem.Text = "&Neues Projekt";
            // 
            // projektöffnenToolStripMenuItem
            // 
            this.projektöffnenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.projektöffnenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.projektöffnenToolStripMenuItem.Name = "projektöffnenToolStripMenuItem";
            this.projektöffnenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.projektöffnenToolStripMenuItem.Text = "Projekt &öffnen";
            // 
            // projektspeichernToolStripMenuItem
            // 
            this.projektspeichernToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.projektspeichernToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.projektspeichernToolStripMenuItem.Name = "projektspeichernToolStripMenuItem";
            this.projektspeichernToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.projektspeichernToolStripMenuItem.Text = "Projekt &speichern";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.beendenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // projektToolStripMenuItem
            // 
            this.projektToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.projektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geräteToolStripMenuItem,
            this.eigenschaftenToolStripMenuItem});
            this.projektToolStripMenuItem.Name = "projektToolStripMenuItem";
            this.projektToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.projektToolStripMenuItem.Text = "&Projekt";
            // 
            // eigenschaftenToolStripMenuItem
            // 
            this.eigenschaftenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eigenschaftenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eigenschaftenToolStripMenuItem.Name = "eigenschaftenToolStripMenuItem";
            this.eigenschaftenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eigenschaftenToolStripMenuItem.Text = "&Eigenschaften";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStripMain.Location = new System.Drawing.Point(0, 716);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1234, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.projectExplorerViewMain);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.interfaceDescriptionEditorView1);
            this.splitContainerMain.Panel2MinSize = 500;
            this.splitContainerMain.Size = new System.Drawing.Size(1234, 692);
            this.splitContainerMain.SplitterDistance = 277;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 3;
            // 
            // projectExplorerViewMain
            // 
            this.projectExplorerViewMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.projectExplorerViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectExplorerViewMain.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectExplorerViewMain.Location = new System.Drawing.Point(0, 0);
            this.projectExplorerViewMain.Name = "projectExplorerViewMain";
            this.projectExplorerViewMain.Size = new System.Drawing.Size(277, 692);
            this.projectExplorerViewMain.TabIndex = 0;
            // 
            // interfaceDescriptionEditorView1
            // 
            this.interfaceDescriptionEditorView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.interfaceDescriptionEditorView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interfaceDescriptionEditorView1.Location = new System.Drawing.Point(0, 0);
            this.interfaceDescriptionEditorView1.Name = "interfaceDescriptionEditorView1";
            this.interfaceDescriptionEditorView1.Size = new System.Drawing.Size(952, 692);
            this.interfaceDescriptionEditorView1.TabIndex = 0;
            // 
            // panelSpacer
            // 
            this.panelSpacer.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer.Location = new System.Drawing.Point(0, 24);
            this.panelSpacer.Name = "panelSpacer";
            this.panelSpacer.Size = new System.Drawing.Size(1234, 1);
            this.panelSpacer.TabIndex = 4;
            // 
            // panelSpacerBottom
            // 
            this.panelSpacerBottom.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelSpacerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSpacerBottom.Location = new System.Drawing.Point(0, 715);
            this.panelSpacerBottom.Name = "panelSpacerBottom";
            this.panelSpacerBottom.Size = new System.Drawing.Size(1234, 1);
            this.panelSpacerBottom.TabIndex = 5;
            // 
            // geräteToolStripMenuItem
            // 
            this.geräteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.geräteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.geräteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.geräteToolStripMenuItem.Name = "geräteToolStripMenuItem";
            this.geräteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.geräteToolStripMenuItem.Text = "&Geräte";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1234, 738);
            this.Controls.Add(this.panelSpacerBottom);
            this.Controls.Add(this.panelSpacer);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Schnittstellen";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private View.ProjectExplorerView projectExplorerViewMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesProjektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektöffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektspeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenschaftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Panel panelSpacer;
        private System.Windows.Forms.Panel panelSpacerBottom;
        private View.InterfaceDescriptionEditorView interfaceDescriptionEditorView1;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
    }
}

