using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mathre
{
    [DesignerGenerated()]
    public partial class Frm00Mathre : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaseLayer = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTabs = new System.Windows.Forms.MenuStrip();
            this.mnuBaseLayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            this.mnuFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // mnuView
            // 
            this.mnuView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            // 
            // mnuBaseLayer
            // 
            this.mnuBaseLayer.BackColor = System.Drawing.SystemColors.Control;
            this.mnuBaseLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.mnuBaseLayer.Location = new System.Drawing.Point(0, 0);
            this.mnuBaseLayer.Name = "mnuBaseLayer";
            this.mnuBaseLayer.Padding = new System.Windows.Forms.Padding(0);
            this.mnuBaseLayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuBaseLayer.Size = new System.Drawing.Size(1284, 24);
            this.mnuBaseLayer.TabIndex = 0;
            this.mnuBaseLayer.Text = "Menu";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuTabs
            // 
            this.mnuTabs.AutoSize = false;
            this.mnuTabs.BackColor = System.Drawing.SystemColors.Control;
            this.mnuTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuTabs.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuTabs.Location = new System.Drawing.Point(0, 24);
            this.mnuTabs.Name = "mnuTabs";
            this.mnuTabs.Padding = new System.Windows.Forms.Padding(0);
            this.mnuTabs.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuTabs.Size = new System.Drawing.Size(140, 627);
            this.mnuTabs.TabIndex = 5;
            this.mnuTabs.Text = "Menu";
            // 
            // Frm00Mathre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 651);
            this.Controls.Add(this.mnuTabs);
            this.Controls.Add(this.mnuBaseLayer);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuBaseLayer;
            this.MinimumSize = new System.Drawing.Size(1230, 500);
            this.Name = "Frm00Mathre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathre";
            this.mnuBaseLayer.ResumeLayout(false);
            this.mnuBaseLayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal ToolStripMenuItem mnuView;
		public ToolStripMenuItem mnuFile;
		public MenuStrip mnuBaseLayer;
		internal ToolStripMenuItem mnuEdit;
		public MenuStrip mnuTabs;
	}
}
