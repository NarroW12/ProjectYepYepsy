using System.Drawing;
using System.Windows.Forms;

namespace YepYeps
{
    partial class Form3Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Helper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReturn = new System.Windows.Forms.Button();
            this.labelHelper = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bReturn);
            this.panel1.Location = new System.Drawing.Point(282, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 65);
            this.panel1.TabIndex = 0;
            // 
            // bReturn
            // 
            this.bReturn.BackColor = System.Drawing.Color.Transparent;
            this.bReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReturn.FlatAppearance.BorderSize = 0;
            this.bReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReturn.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bReturn.ForeColor = System.Drawing.Color.White;
            this.bReturn.Location = new System.Drawing.Point(0, 0);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(201, 65);
            this.bReturn.TabIndex = 0;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = false;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // labelHelper
            // 
            this.labelHelper.AutoSize = true;
            this.labelHelper.BackColor = System.Drawing.Color.Transparent;
            this.labelHelper.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHelper.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelper.ForeColor = System.Drawing.Color.White;
            this.labelHelper.Location = new System.Drawing.Point(0, 0);
            this.labelHelper.Name = "labelHelper";
            this.labelHelper.Size = new System.Drawing.Size(88, 38);
            this.labelHelper.TabIndex = 1;
            this.labelHelper.Text = "label1";
            this.labelHelper.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHelper);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3Helper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Helper";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bReturn;
        private Label labelHelper;
    }
}