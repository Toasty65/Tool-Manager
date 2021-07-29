
namespace Tool_Manager
{
    partial class ToolManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolManager));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tCtrl_scripts = new System.Windows.Forms.TabPage();
            this.tCtrl_tools = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tCtrl_scripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tCtrl_scripts);
            this.tabControl.Controls.Add(this.tCtrl_tools);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(583, 415);
            this.tabControl.TabIndex = 0;
            // 
            // tCtrl_scripts
            // 
            this.tCtrl_scripts.Controls.Add(this.groupBox2);
            this.tCtrl_scripts.Controls.Add(this.groupBox1);
            this.tCtrl_scripts.Location = new System.Drawing.Point(4, 22);
            this.tCtrl_scripts.Name = "tCtrl_scripts";
            this.tCtrl_scripts.Padding = new System.Windows.Forms.Padding(3);
            this.tCtrl_scripts.Size = new System.Drawing.Size(575, 389);
            this.tCtrl_scripts.TabIndex = 0;
            this.tCtrl_scripts.Text = "Scripts";
            this.tCtrl_scripts.UseVisualStyleBackColor = true;
            // 
            // tCtrl_tools
            // 
            this.tCtrl_tools.Location = new System.Drawing.Point(4, 22);
            this.tCtrl_tools.Name = "tCtrl_tools";
            this.tCtrl_tools.Padding = new System.Windows.Forms.Padding(3);
            this.tCtrl_tools.Size = new System.Drawing.Size(575, 389);
            this.tCtrl_tools.TabIndex = 1;
            this.tCtrl_tools.Text = "Tools";
            this.tCtrl_tools.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Powershell";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(285, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CMD";
            // 
            // ToolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolManager";
            this.Text = "Tool Manager";
            this.tabControl.ResumeLayout(false);
            this.tCtrl_scripts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tCtrl_scripts;
        private System.Windows.Forms.TabPage tCtrl_tools;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

