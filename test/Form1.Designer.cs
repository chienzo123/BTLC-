
namespace test
{
    partial class Form1
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
            this.btnaddweb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnaddweb
            // 
            this.btnaddweb.Location = new System.Drawing.Point(12, 8);
            this.btnaddweb.Name = "btnaddweb";
            this.btnaddweb.Size = new System.Drawing.Size(166, 23);
            this.btnaddweb.TabIndex = 0;
            this.btnaddweb.Text = "Add web brower";
            this.btnaddweb.UseVisualStyleBackColor = true;
            this.btnaddweb.Click += new System.EventHandler(this.btnaddweb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtweb
            // 
            this.txtweb.Location = new System.Drawing.Point(313, 11);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(475, 20);
            this.txtweb.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 405);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnaddweb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddweb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.Panel panel1;
    }
}

