namespace Pokemon
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
            this.btXao_47_Tung = new System.Windows.Forms.Button();
            this.btThoat_47_Tung = new System.Windows.Forms.Button();
            this.btRePlay_47_Tung = new System.Windows.Forms.Button();
            this.lbKQDiem_47_Tung = new System.Windows.Forms.Label();
            this.lbDiem_47_Tung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btXao_47_Tung
            // 
            this.btXao_47_Tung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXao_47_Tung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXao_47_Tung.Location = new System.Drawing.Point(665, 115);
            this.btXao_47_Tung.Name = "btXao_47_Tung";
            this.btXao_47_Tung.Size = new System.Drawing.Size(110, 40);
            this.btXao_47_Tung.TabIndex = 0;
            this.btXao_47_Tung.Text = "Xáo hình";
            this.btXao_47_Tung.UseVisualStyleBackColor = true;
            this.btXao_47_Tung.Click += new System.EventHandler(this.btXao_47_Tung_Click);
            // 
            // btThoat_47_Tung
            // 
            this.btThoat_47_Tung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat_47_Tung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat_47_Tung.Location = new System.Drawing.Point(665, 59);
            this.btThoat_47_Tung.Name = "btThoat_47_Tung";
            this.btThoat_47_Tung.Size = new System.Drawing.Size(110, 40);
            this.btThoat_47_Tung.TabIndex = 1;
            this.btThoat_47_Tung.Text = "Thoát";
            this.btThoat_47_Tung.UseVisualStyleBackColor = true;
            this.btThoat_47_Tung.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btRePlay_47_Tung
            // 
            this.btRePlay_47_Tung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRePlay_47_Tung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRePlay_47_Tung.Location = new System.Drawing.Point(665, 170);
            this.btRePlay_47_Tung.Name = "btRePlay_47_Tung";
            this.btRePlay_47_Tung.Size = new System.Drawing.Size(110, 40);
            this.btRePlay_47_Tung.TabIndex = 2;
            this.btRePlay_47_Tung.Text = "Chơi lại";
            this.btRePlay_47_Tung.UseVisualStyleBackColor = true;
            this.btRePlay_47_Tung.Click += new System.EventHandler(this.btRePlay_Click);
            // 
            // lbKQDiem_47_Tung
            // 
            this.lbKQDiem_47_Tung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKQDiem_47_Tung.AutoSize = true;
            this.lbKQDiem_47_Tung.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKQDiem_47_Tung.Location = new System.Drawing.Point(539, 150);
            this.lbKQDiem_47_Tung.Name = "lbKQDiem_47_Tung";
            this.lbKQDiem_47_Tung.Size = new System.Drawing.Size(0, 31);
            this.lbKQDiem_47_Tung.TabIndex = 4;
            // 
            // lbDiem_47_Tung
            // 
            this.lbDiem_47_Tung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiem_47_Tung.AutoSize = true;
            this.lbDiem_47_Tung.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem_47_Tung.Location = new System.Drawing.Point(539, 105);
            this.lbDiem_47_Tung.Name = "lbDiem_47_Tung";
            this.lbDiem_47_Tung.Size = new System.Drawing.Size(81, 31);
            this.lbDiem_47_Tung.TabIndex = 3;
            this.lbDiem_47_Tung.Text = "Điểm";
            this.lbDiem_47_Tung.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKQDiem_47_Tung);
            this.Controls.Add(this.lbDiem_47_Tung);
            this.Controls.Add(this.btRePlay_47_Tung);
            this.Controls.Add(this.btThoat_47_Tung);
            this.Controls.Add(this.btXao_47_Tung);
            this.Name = "Form1";
            this.Text = "GamePokemon_47_Tung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXao_47_Tung;
        private System.Windows.Forms.Button btThoat_47_Tung;
        private System.Windows.Forms.Button btRePlay_47_Tung;
        private System.Windows.Forms.Label lbKQDiem_47_Tung;
        private System.Windows.Forms.Label lbDiem_47_Tung;
    }
}

