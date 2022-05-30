namespace TicTacToe_Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Player1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.btn_Tick1 = new System.Windows.Forms.Button();
            this.btn_Tick5 = new System.Windows.Forms.Button();
            this.btn_Tick9 = new System.Windows.Forms.Button();
            this.btn_Tick8 = new System.Windows.Forms.Button();
            this.btn_Tick6 = new System.Windows.Forms.Button();
            this.btn_Tick7 = new System.Windows.Forms.Button();
            this.btn_Tick4 = new System.Windows.Forms.Button();
            this.btn_Tick3 = new System.Windows.Forms.Button();
            this.btn_Tick2 = new System.Windows.Forms.Button();
            this.lbl_PlayerX = new System.Windows.Forms.Label();
            this.lbl_PlayerO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(120, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_Tick2);
            this.panel2.Controls.Add(this.btn_Tick3);
            this.panel2.Controls.Add(this.btn_Tick4);
            this.panel2.Controls.Add(this.btn_Tick7);
            this.panel2.Controls.Add(this.btn_Tick6);
            this.panel2.Controls.Add(this.btn_Tick8);
            this.panel2.Controls.Add(this.btn_Tick9);
            this.panel2.Controls.Add(this.btn_Tick5);
            this.panel2.Controls.Add(this.btn_Tick1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(120, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 338);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.lbl_PlayerO);
            this.panel3.Controls.Add(this.lbl_PlayerX);
            this.panel3.Controls.Add(this.Label_Player1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(510, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 337);
            this.panel3.TabIndex = 2;
            // 
            // Label_Player1
            // 
            this.Label_Player1.AutoSize = true;
            this.Label_Player1.BackColor = System.Drawing.Color.White;
            this.Label_Player1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label_Player1.Location = new System.Drawing.Point(5, 243);
            this.Label_Player1.Name = "Label_Player1";
            this.Label_Player1.Size = new System.Drawing.Size(68, 18);
            this.Label_Player1.TabIndex = 5;
            this.Label_Player1.Text = "Player 1 :";
            this.Label_Player1.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(4, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Player 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Player 1  -  X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Player 2  -  O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active Player:";
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.White;
            this.button_Reset.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(8, 114);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(162, 55);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "Reset Game";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // btn_Tick1
            // 
            this.btn_Tick1.BackColor = System.Drawing.Color.White;
            this.btn_Tick1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick1.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_Tick1.Location = new System.Drawing.Point(40, 31);
            this.btn_Tick1.Name = "btn_Tick1";
            this.btn_Tick1.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick1.TabIndex = 10;
            this.btn_Tick1.UseVisualStyleBackColor = false;
            this.btn_Tick1.Click += new System.EventHandler(this.btn_Tick1_Click);
            // 
            // btn_Tick5
            // 
            this.btn_Tick5.BackColor = System.Drawing.Color.White;
            this.btn_Tick5.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick5.ForeColor = System.Drawing.Color.White;
            this.btn_Tick5.Location = new System.Drawing.Point(136, 124);
            this.btn_Tick5.Name = "btn_Tick5";
            this.btn_Tick5.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick5.TabIndex = 11;
            this.btn_Tick5.UseVisualStyleBackColor = false;
            this.btn_Tick5.Click += new System.EventHandler(this.btn_Tick5_Click);
            // 
            // btn_Tick9
            // 
            this.btn_Tick9.BackColor = System.Drawing.Color.White;
            this.btn_Tick9.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick9.ForeColor = System.Drawing.Color.White;
            this.btn_Tick9.Location = new System.Drawing.Point(229, 221);
            this.btn_Tick9.Name = "btn_Tick9";
            this.btn_Tick9.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick9.TabIndex = 12;
            this.btn_Tick9.UseVisualStyleBackColor = false;
            this.btn_Tick9.Click += new System.EventHandler(this.btn_Tick9_Click);
            // 
            // btn_Tick8
            // 
            this.btn_Tick8.BackColor = System.Drawing.Color.White;
            this.btn_Tick8.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick8.ForeColor = System.Drawing.Color.White;
            this.btn_Tick8.Location = new System.Drawing.Point(136, 221);
            this.btn_Tick8.Name = "btn_Tick8";
            this.btn_Tick8.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick8.TabIndex = 13;
            this.btn_Tick8.UseVisualStyleBackColor = false;
            this.btn_Tick8.Click += new System.EventHandler(this.btn_Tick8_Click);
            // 
            // btn_Tick6
            // 
            this.btn_Tick6.BackColor = System.Drawing.Color.White;
            this.btn_Tick6.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick6.ForeColor = System.Drawing.Color.White;
            this.btn_Tick6.Location = new System.Drawing.Point(229, 124);
            this.btn_Tick6.Name = "btn_Tick6";
            this.btn_Tick6.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick6.TabIndex = 14;
            this.btn_Tick6.UseVisualStyleBackColor = false;
            this.btn_Tick6.Click += new System.EventHandler(this.btn_Tick6_Click);
            // 
            // btn_Tick7
            // 
            this.btn_Tick7.BackColor = System.Drawing.Color.White;
            this.btn_Tick7.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick7.ForeColor = System.Drawing.Color.White;
            this.btn_Tick7.Location = new System.Drawing.Point(40, 221);
            this.btn_Tick7.Name = "btn_Tick7";
            this.btn_Tick7.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick7.TabIndex = 15;
            this.btn_Tick7.UseVisualStyleBackColor = false;
            this.btn_Tick7.Click += new System.EventHandler(this.btn_Tick7_Click);
            // 
            // btn_Tick4
            // 
            this.btn_Tick4.BackColor = System.Drawing.Color.White;
            this.btn_Tick4.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick4.ForeColor = System.Drawing.Color.White;
            this.btn_Tick4.Location = new System.Drawing.Point(40, 124);
            this.btn_Tick4.Name = "btn_Tick4";
            this.btn_Tick4.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick4.TabIndex = 16;
            this.btn_Tick4.UseVisualStyleBackColor = false;
            this.btn_Tick4.Click += new System.EventHandler(this.btn_Tick4_Click);
            // 
            // btn_Tick3
            // 
            this.btn_Tick3.BackColor = System.Drawing.Color.White;
            this.btn_Tick3.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick3.ForeColor = System.Drawing.Color.White;
            this.btn_Tick3.Location = new System.Drawing.Point(229, 31);
            this.btn_Tick3.Name = "btn_Tick3";
            this.btn_Tick3.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick3.TabIndex = 17;
            this.btn_Tick3.UseVisualStyleBackColor = false;
            this.btn_Tick3.Click += new System.EventHandler(this.btn_Tick3_Click);
            // 
            // btn_Tick2
            // 
            this.btn_Tick2.BackColor = System.Drawing.Color.White;
            this.btn_Tick2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tick2.ForeColor = System.Drawing.Color.White;
            this.btn_Tick2.Location = new System.Drawing.Point(136, 31);
            this.btn_Tick2.Name = "btn_Tick2";
            this.btn_Tick2.Size = new System.Drawing.Size(71, 69);
            this.btn_Tick2.TabIndex = 18;
            this.btn_Tick2.UseVisualStyleBackColor = false;
            this.btn_Tick2.Click += new System.EventHandler(this.btn_Tick2_Click);
            // 
            // lbl_PlayerX
            // 
            this.lbl_PlayerX.AutoSize = true;
            this.lbl_PlayerX.BackColor = System.Drawing.Color.White;
            this.lbl_PlayerX.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerX.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_PlayerX.Location = new System.Drawing.Point(77, 243);
            this.lbl_PlayerX.Name = "lbl_PlayerX";
            this.lbl_PlayerX.Size = new System.Drawing.Size(16, 18);
            this.lbl_PlayerX.TabIndex = 7;
            this.lbl_PlayerX.Text = "0";
            // 
            // lbl_PlayerO
            // 
            this.lbl_PlayerO.AutoSize = true;
            this.lbl_PlayerO.BackColor = System.Drawing.Color.White;
            this.lbl_PlayerO.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_PlayerO.Location = new System.Drawing.Point(77, 272);
            this.lbl_PlayerO.Name = "lbl_PlayerO";
            this.lbl_PlayerO.Size = new System.Drawing.Size(16, 18);
            this.lbl_PlayerO.TabIndex = 8;
            this.lbl_PlayerO.Text = "0";
            this.lbl_PlayerO.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic_Tac_Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_Player1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button btn_Tick2;
        private System.Windows.Forms.Button btn_Tick3;
        private System.Windows.Forms.Button btn_Tick4;
        private System.Windows.Forms.Button btn_Tick7;
        private System.Windows.Forms.Button btn_Tick6;
        private System.Windows.Forms.Button btn_Tick8;
        private System.Windows.Forms.Button btn_Tick9;
        private System.Windows.Forms.Button btn_Tick5;
        private System.Windows.Forms.Button btn_Tick1;
        private System.Windows.Forms.Label lbl_PlayerO;
        private System.Windows.Forms.Label lbl_PlayerX;
    }
}

