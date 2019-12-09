namespace Ucaksavar
{
    partial class AnaForm
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
            this.oyunPaneli = new System.Windows.Forms.Panel();
            this.oyunBaslatmaLabel = new System.Windows.Forms.Label();
            this.ucaksavarHareketLabel = new System.Windows.Forms.Label();
            this.atesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oyunPaneli
            // 
            this.oyunPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunPaneli.BackColor = System.Drawing.Color.DarkSlateGray;
            this.oyunPaneli.Location = new System.Drawing.Point(-1, 68);
            this.oyunPaneli.Name = "oyunPaneli";
            this.oyunPaneli.Size = new System.Drawing.Size(915, 569);
            this.oyunPaneli.TabIndex = 0;
            // 
            // oyunBaslatmaLabel
            // 
            this.oyunBaslatmaLabel.AutoSize = true;
            this.oyunBaslatmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunBaslatmaLabel.ForeColor = System.Drawing.Color.White;
            this.oyunBaslatmaLabel.Location = new System.Drawing.Point(12, 9);
            this.oyunBaslatmaLabel.Name = "oyunBaslatmaLabel";
            this.oyunBaslatmaLabel.Size = new System.Drawing.Size(323, 17);
            this.oyunBaslatmaLabel.TabIndex = 1;
            this.oyunBaslatmaLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.";
            // 
            // ucaksavarHareketLabel
            // 
            this.ucaksavarHareketLabel.AutoSize = true;
            this.ucaksavarHareketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucaksavarHareketLabel.ForeColor = System.Drawing.Color.White;
            this.ucaksavarHareketLabel.Location = new System.Drawing.Point(12, 26);
            this.ucaksavarHareketLabel.Name = "ucaksavarHareketLabel";
            this.ucaksavarHareketLabel.Size = new System.Drawing.Size(503, 17);
            this.ucaksavarHareketLabel.TabIndex = 2;
            this.ucaksavarHareketLabel.Text = "Uçaksavarı hareket ettirmek için SAĞ/SOL YÖN TUŞLARINI kullanın.";
            // 
            // atesLabel
            // 
            this.atesLabel.AutoSize = true;
            this.atesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atesLabel.ForeColor = System.Drawing.Color.White;
            this.atesLabel.Location = new System.Drawing.Point(12, 43);
            this.atesLabel.Name = "atesLabel";
            this.atesLabel.Size = new System.Drawing.Size(288, 17);
            this.atesLabel.TabIndex = 3;
            this.atesLabel.Text = "Ateş etmek için BOŞLUK tuşuna basın.";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(914, 637);
            this.Controls.Add(this.atesLabel);
            this.Controls.Add(this.ucaksavarHareketLabel);
            this.Controls.Add(this.oyunBaslatmaLabel);
            this.Controls.Add(this.oyunPaneli);
            this.KeyPreview = true;
            this.Name = "AnaForm";
            this.Text = "UÇAKSAVAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel oyunPaneli;
        private System.Windows.Forms.Label oyunBaslatmaLabel;
        private System.Windows.Forms.Label ucaksavarHareketLabel;
        private System.Windows.Forms.Label atesLabel;
    }
}

