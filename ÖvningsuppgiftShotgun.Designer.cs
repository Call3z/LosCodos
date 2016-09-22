namespace inlämningsuppgiftShotgun1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.txtBoxPlayer = new System.Windows.Forms.TextBox();
            this.txtBoxComp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(24, 125);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(105, 125);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(186, 125);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 2;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(105, 167);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 23);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // txtBoxPlayer
            // 
            this.txtBoxPlayer.Enabled = false;
            this.txtBoxPlayer.Location = new System.Drawing.Point(24, 88);
            this.txtBoxPlayer.Name = "txtBoxPlayer";
            this.txtBoxPlayer.Size = new System.Drawing.Size(75, 20);
            this.txtBoxPlayer.TabIndex = 7;
            this.txtBoxPlayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxComp
            // 
            this.txtBoxComp.Enabled = false;
            this.txtBoxComp.Location = new System.Drawing.Point(186, 88);
            this.txtBoxComp.Name = "txtBoxComp";
            this.txtBoxComp.Size = new System.Drawing.Size(75, 20);
            this.txtBoxComp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Ammo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Computer Ammo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxComp);
            this.Controls.Add(this.txtBoxPlayer);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Shotgun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.TextBox txtBoxPlayer;
        private System.Windows.Forms.TextBox txtBoxComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

