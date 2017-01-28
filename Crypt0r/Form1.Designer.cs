namespace Crypt0r
{
    partial class EBP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EBP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minbx = new System.Windows.Forms.Label();
            this.ebx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.HW_INIT_REGEX = new System.Windows.Forms.CheckBox();
            this.rand_arg1 = new System.Windows.Forms.CheckBox();
            this.SP = new System.Windows.Forms.TextBox();
            this.gen_pass = new System.Windows.Forms.Button();
            this.dynlink = new System.Windows.Forms.CheckBox();
            this.geosn0w = new System.Windows.Forms.Label();
            this.inco = new System.Windows.Forms.CheckBox();
            this.lng = new System.Windows.Forms.Label();
            this.exif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.minbx);
            this.panel1.Controls.Add(this.ebx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 29);
            this.panel1.TabIndex = 0;
            // 
            // minbx
            // 
            this.minbx.AutoSize = true;
            this.minbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minbx.Location = new System.Drawing.Point(520, 0);
            this.minbx.Name = "minbx";
            this.minbx.Size = new System.Drawing.Size(34, 30);
            this.minbx.TabIndex = 10;
            this.minbx.Text = "—";
            this.minbx.Click += new System.EventHandler(this.label5_Click);
            // 
            // ebx
            // 
            this.ebx.AutoSize = true;
            this.ebx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ebx.Location = new System.Drawing.Point(551, 0);
            this.ebx.Name = "ebx";
            this.ebx.Size = new System.Drawing.Size(27, 30);
            this.ebx.TabIndex = 8;
            this.ebx.Text = "×";
            this.ebx.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crypt0r - Truly STRONG RANDOM Passwords";
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc.Location = new System.Drawing.Point(12, 41);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(205, 21);
            this.pc.TabIndex = 1;
            this.pc.Text = "Generate a strong password";
            // 
            // HW_INIT_REGEX
            // 
            this.HW_INIT_REGEX.AutoSize = true;
            this.HW_INIT_REGEX.Checked = true;
            this.HW_INIT_REGEX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HW_INIT_REGEX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HW_INIT_REGEX.Location = new System.Drawing.Point(16, 65);
            this.HW_INIT_REGEX.Name = "HW_INIT_REGEX";
            this.HW_INIT_REGEX.Size = new System.Drawing.Size(183, 19);
            this.HW_INIT_REGEX.TabIndex = 2;
            this.HW_INIT_REGEX.Text = "Use Hardware Crypto Support";
            this.HW_INIT_REGEX.UseVisualStyleBackColor = true;
            // 
            // rand_arg1
            // 
            this.rand_arg1.AutoSize = true;
            this.rand_arg1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rand_arg1.Location = new System.Drawing.Point(16, 90);
            this.rand_arg1.Name = "rand_arg1";
            this.rand_arg1.Size = new System.Drawing.Size(156, 19);
            this.rand_arg1.TabIndex = 3;
            this.rand_arg1.Text = "Generate Long Password";
            this.rand_arg1.UseVisualStyleBackColor = true;
            this.rand_arg1.CheckedChanged += new System.EventHandler(this.rand_arg1_CheckedChanged);
            // 
            // SP
            // 
            this.SP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP.Location = new System.Drawing.Point(12, 171);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(552, 29);
            this.SP.TabIndex = 4;
            // 
            // gen_pass
            // 
            this.gen_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_pass.Location = new System.Drawing.Point(189, 217);
            this.gen_pass.Name = "gen_pass";
            this.gen_pass.Size = new System.Drawing.Size(198, 39);
            this.gen_pass.TabIndex = 5;
            this.gen_pass.Text = "Generate Password";
            this.gen_pass.UseVisualStyleBackColor = true;
            this.gen_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // dynlink
            // 
            this.dynlink.AutoSize = true;
            this.dynlink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynlink.Location = new System.Drawing.Point(16, 115);
            this.dynlink.Name = "dynlink";
            this.dynlink.Size = new System.Drawing.Size(107, 19);
            this.dynlink.TabIndex = 6;
            this.dynlink.Text = "Ultra Password ";
            this.dynlink.UseVisualStyleBackColor = true;
            this.dynlink.CheckedChanged += new System.EventHandler(this.dynlink_CheckedChanged);
            // 
            // geosn0w
            // 
            this.geosn0w.AutoSize = true;
            this.geosn0w.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geosn0w.Location = new System.Drawing.Point(1, 272);
            this.geosn0w.Name = "geosn0w";
            this.geosn0w.Size = new System.Drawing.Size(156, 21);
            this.geosn0w.TabIndex = 7;
            this.geosn0w.Text = "Created by GeoSn0w";
            this.geosn0w.Click += new System.EventHandler(this.label3_Click);
            // 
            // inco
            // 
            this.inco.AutoSize = true;
            this.inco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inco.Location = new System.Drawing.Point(16, 140);
            this.inco.Name = "inco";
            this.inco.Size = new System.Drawing.Size(144, 19);
            this.inco.TabIndex = 8;
            this.inco.Text = "Uncrackable Password";
            this.inco.UseVisualStyleBackColor = true;
            this.inco.CheckedChanged += new System.EventHandler(this.inco_CheckedChanged);
            // 
            // lng
            // 
            this.lng.AutoSize = true;
            this.lng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lng.Location = new System.Drawing.Point(478, 140);
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(92, 21);
            this.lng.TabIndex = 9;
            this.lng.Text = "Length: 220";
            this.lng.Visible = false;
            // 
            // exif
            // 
            this.exif.AutoSize = true;
            this.exif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exif.Location = new System.Drawing.Point(538, 272);
            this.exif.Name = "exif";
            this.exif.Size = new System.Drawing.Size(32, 21);
            this.exif.TabIndex = 10;
            this.exif.Text = "[ i ]";
            this.exif.Click += new System.EventHandler(this.label6_Click);
            // 
            // EBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 302);
            this.Controls.Add(this.exif);
            this.Controls.Add(this.lng);
            this.Controls.Add(this.inco);
            this.Controls.Add(this.geosn0w);
            this.Controls.Add(this.dynlink);
            this.Controls.Add(this.gen_pass);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.rand_arg1);
            this.Controls.Add(this.HW_INIT_REGEX);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EBP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt0r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.CheckBox HW_INIT_REGEX;
        private System.Windows.Forms.CheckBox rand_arg1;
        private System.Windows.Forms.TextBox SP;
        private System.Windows.Forms.Button gen_pass;
        private System.Windows.Forms.CheckBox dynlink;
        private System.Windows.Forms.Label geosn0w;
        private System.Windows.Forms.Label ebx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox inco;
        private System.Windows.Forms.Label lng;
        private System.Windows.Forms.Label minbx;
        private System.Windows.Forms.Label exif;
    }
}

