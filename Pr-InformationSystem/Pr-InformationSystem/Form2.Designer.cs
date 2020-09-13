namespace Pr_InformationSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1tüm = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2cls = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(12, 64);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(1104, 589);
            this.listBox4.TabIndex = 0;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label1tüm
            // 
            this.label1tüm.AutoSize = true;
            this.label1tüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1tüm.Location = new System.Drawing.Point(12, 26);
            this.label1tüm.Name = "label1tüm";
            this.label1tüm.Size = new System.Drawing.Size(113, 24);
            this.label1tüm.TabIndex = 14;
            this.label1tüm.Text = "Tüm Kayıtlar";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2cls);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 663);
            this.panel4.TabIndex = 23;
            // 
            // button2cls
            // 
            this.button2cls.FlatAppearance.BorderSize = 0;
            this.button2cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2cls.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2cls.Image = global::Pr_InformationSystem.Properties.Resources.icons8_power_off_button_20;
            this.button2cls.Location = new System.Drawing.Point(1098, 4);
            this.button2cls.Name = "button2cls";
            this.button2cls.Size = new System.Drawing.Size(23, 25);
            this.button2cls.TabIndex = 13;
            this.button2cls.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2cls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2cls.UseVisualStyleBackColor = true;
            this.button2cls.Click += new System.EventHandler(this.button2cls_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1128, 664);
            this.ControlBox = false;
            this.Controls.Add(this.label1tüm);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tüm Kayıtlar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button2cls;
        private System.Windows.Forms.Label label1tüm;
        private System.Windows.Forms.Panel panel4;
    }
}