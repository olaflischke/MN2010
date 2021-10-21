
namespace EierfarmUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNeueGans = new System.Windows.Forms.Button();
            this.btnNeuesHuhn = new System.Windows.Forms.Button();
            this.btnFuettern = new System.Windows.Forms.Button();
            this.btnEiLegen = new System.Windows.Forms.Button();
            this.cbxTier = new System.Windows.Forms.ComboBox();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // btnNeueGans
            // 
            this.btnNeueGans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeueGans.Location = new System.Drawing.Point(259, 58);
            this.btnNeueGans.Name = "btnNeueGans";
            this.btnNeueGans.Size = new System.Drawing.Size(131, 40);
            this.btnNeueGans.TabIndex = 0;
            this.btnNeueGans.Text = "Gans";
            this.btnNeueGans.UseVisualStyleBackColor = true;
            this.btnNeueGans.Click += new System.EventHandler(this.btnNeueGans_Click);
            // 
            // btnNeuesHuhn
            // 
            this.btnNeuesHuhn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeuesHuhn.Location = new System.Drawing.Point(259, 12);
            this.btnNeuesHuhn.Name = "btnNeuesHuhn";
            this.btnNeuesHuhn.Size = new System.Drawing.Size(131, 40);
            this.btnNeuesHuhn.TabIndex = 1;
            this.btnNeuesHuhn.Text = "Huhn";
            this.btnNeuesHuhn.UseVisualStyleBackColor = true;
            this.btnNeuesHuhn.Click += new System.EventHandler(this.btnNeuesHuhn_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuettern.Location = new System.Drawing.Point(259, 171);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(131, 40);
            this.btnFuettern.TabIndex = 2;
            this.btnFuettern.Text = "Füttern";
            this.btnFuettern.UseVisualStyleBackColor = true;
            this.btnFuettern.Click += new System.EventHandler(this.btnFuettern_Click);
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEiLegen.Location = new System.Drawing.Point(259, 217);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(131, 40);
            this.btnEiLegen.TabIndex = 3;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // cbxTier
            // 
            this.cbxTier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTier.FormattingEnabled = true;
            this.cbxTier.Location = new System.Drawing.Point(25, 12);
            this.cbxTier.Name = "cbxTier";
            this.cbxTier.Size = new System.Drawing.Size(228, 38);
            this.cbxTier.TabIndex = 4;
            this.cbxTier.SelectedIndexChanged += new System.EventHandler(this.cbxTier_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgdTier.Location = new System.Drawing.Point(25, 56);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(228, 314);
            this.pgdTier.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxTier);
            this.Controls.Add(this.btnEiLegen);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnNeuesHuhn);
            this.Controls.Add(this.btnNeueGans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeueGans;
        private System.Windows.Forms.Button btnNeuesHuhn;
        private System.Windows.Forms.Button btnFuettern;
        private System.Windows.Forms.Button btnEiLegen;
        private System.Windows.Forms.ComboBox cbxTier;
        private System.Windows.Forms.PropertyGrid pgdTier;
    }
}

