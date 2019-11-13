namespace Lottosorsolas
{
    partial class Form_Lottosorsolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lottosorsolas));
            this.panel_lottoszamok = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Sorsolas = new System.Windows.Forms.Button();
            this.label_Nyeroszamok = new System.Windows.Forms.Label();
            this.label_Megjatszott = new System.Windows.Forms.Label();
            this.label_Talalat = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lottoszamok
            // 
            this.panel_lottoszamok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_lottoszamok.Location = new System.Drawing.Point(0, 0);
            this.panel_lottoszamok.Name = "panel_lottoszamok";
            this.panel_lottoszamok.Padding = new System.Windows.Forms.Padding(20);
            this.panel_lottoszamok.Size = new System.Drawing.Size(800, 450);
            this.panel_lottoszamok.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Talalat);
            this.panel2.Controls.Add(this.label_Megjatszott);
            this.panel2.Controls.Add(this.label_Nyeroszamok);
            this.panel2.Controls.Add(this.button_Sorsolas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50);
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // button_Sorsolas
            // 
            this.button_Sorsolas.Image = global::Lottosorsolas.Properties.Resources.shamrock_lucky_icon;
            this.button_Sorsolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sorsolas.Location = new System.Drawing.Point(176, 37);
            this.button_Sorsolas.Name = "button_Sorsolas";
            this.button_Sorsolas.Size = new System.Drawing.Size(88, 35);
            this.button_Sorsolas.TabIndex = 0;
            this.button_Sorsolas.Text = "Sorsolás";
            this.button_Sorsolas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Sorsolas.UseVisualStyleBackColor = true;
            this.button_Sorsolas.Click += new System.EventHandler(this.button_Sorsolas_Click);
            // 
            // label_Nyeroszamok
            // 
            this.label_Nyeroszamok.AutoSize = true;
            this.label_Nyeroszamok.ForeColor = System.Drawing.Color.Green;
            this.label_Nyeroszamok.Location = new System.Drawing.Point(334, 21);
            this.label_Nyeroszamok.Name = "label_Nyeroszamok";
            this.label_Nyeroszamok.Size = new System.Drawing.Size(83, 13);
            this.label_Nyeroszamok.TabIndex = 1;
            this.label_Nyeroszamok.Text = "Nyerőszámok ->";
            // 
            // label_Megjatszott
            // 
            this.label_Megjatszott.AutoSize = true;
            this.label_Megjatszott.Location = new System.Drawing.Point(334, 48);
            this.label_Megjatszott.Name = "label_Megjatszott";
            this.label_Megjatszott.Size = new System.Drawing.Size(73, 13);
            this.label_Megjatszott.TabIndex = 2;
            this.label_Megjatszott.Text = "Megjátszott ->";
            // 
            // label_Talalat
            // 
            this.label_Talalat.AutoSize = true;
            this.label_Talalat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Talalat.Location = new System.Drawing.Point(334, 75);
            this.label_Talalat.Name = "label_Talalat";
            this.label_Talalat.Size = new System.Drawing.Size(51, 13);
            this.label_Talalat.TabIndex = 3;
            this.label_Talalat.Text = "Találat ->";
            // 
            // Form_Lottosorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_lottoszamok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form_Lottosorsolas";
            this.Text = "Lottósorsolás";
            this.Load += new System.EventHandler(this.Form_Lottosorsolas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lottoszamok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Sorsolas;
        private System.Windows.Forms.Label label_Nyeroszamok;
        private System.Windows.Forms.Label label_Megjatszott;
        private System.Windows.Forms.Label label_Talalat;
    }
}

