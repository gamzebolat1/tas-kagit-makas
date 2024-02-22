using System;

namespace tasKagitMakas
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
            this.components = new System.ComponentModel.Container();
            this.btn_pctas = new System.Windows.Forms.Button();
            this.btn_pckagit = new System.Windows.Forms.Button();
            this.btn_pcmakas = new System.Windows.Forms.Button();
            this.btn_oyuncutas = new System.Windows.Forms.Button();
            this.btn_oyuncukagit = new System.Windows.Forms.Button();
            this.btn_oyuncumakas = new System.Windows.Forms.Button();
            this.lbl_skorpc = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_skoroyuncu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_pctas
            // 
            this.btn_pctas.BackColor = System.Drawing.Color.White;
            this.btn_pctas.Enabled = false;
            this.btn_pctas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pctas.Location = new System.Drawing.Point(281, 38);
            this.btn_pctas.Name = "btn_pctas";
            this.btn_pctas.Size = new System.Drawing.Size(128, 61);
            this.btn_pctas.TabIndex = 0;
            this.btn_pctas.Text = "Taş";
            this.btn_pctas.UseVisualStyleBackColor = false;
            // 
            // btn_pckagit
            // 
            this.btn_pckagit.BackColor = System.Drawing.Color.White;
            this.btn_pckagit.Enabled = false;
            this.btn_pckagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pckagit.Location = new System.Drawing.Point(281, 105);
            this.btn_pckagit.Name = "btn_pckagit";
            this.btn_pckagit.Size = new System.Drawing.Size(128, 61);
            this.btn_pckagit.TabIndex = 0;
            this.btn_pckagit.Text = "Kağıt";
            this.btn_pckagit.UseVisualStyleBackColor = false;
            // 
            // btn_pcmakas
            // 
            this.btn_pcmakas.BackColor = System.Drawing.Color.White;
            this.btn_pcmakas.Enabled = false;
            this.btn_pcmakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pcmakas.Location = new System.Drawing.Point(281, 172);
            this.btn_pcmakas.Name = "btn_pcmakas";
            this.btn_pcmakas.Size = new System.Drawing.Size(128, 61);
            this.btn_pcmakas.TabIndex = 0;
            this.btn_pcmakas.Text = "Makas";
            this.btn_pcmakas.UseVisualStyleBackColor = false;
            // 
            // btn_oyuncutas
            // 
            this.btn_oyuncutas.BackColor = System.Drawing.Color.White;
            this.btn_oyuncutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyuncutas.Location = new System.Drawing.Point(281, 312);
            this.btn_oyuncutas.Name = "btn_oyuncutas";
            this.btn_oyuncutas.Size = new System.Drawing.Size(128, 61);
            this.btn_oyuncutas.TabIndex = 0;
            this.btn_oyuncutas.Text = "Taş";
            this.btn_oyuncutas.UseVisualStyleBackColor = false;
            this.btn_oyuncutas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_oyuncukagit
            // 
            this.btn_oyuncukagit.BackColor = System.Drawing.Color.White;
            this.btn_oyuncukagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyuncukagit.Location = new System.Drawing.Point(281, 379);
            this.btn_oyuncukagit.Name = "btn_oyuncukagit";
            this.btn_oyuncukagit.Size = new System.Drawing.Size(128, 61);
            this.btn_oyuncukagit.TabIndex = 0;
            this.btn_oyuncukagit.Text = "Kağıt";
            this.btn_oyuncukagit.UseVisualStyleBackColor = false;
            this.btn_oyuncukagit.Click += new System.EventHandler(this.btn_oyuncukagit_Click);
            // 
            // btn_oyuncumakas
            // 
            this.btn_oyuncumakas.BackColor = System.Drawing.Color.White;
            this.btn_oyuncumakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyuncumakas.Location = new System.Drawing.Point(281, 446);
            this.btn_oyuncumakas.Name = "btn_oyuncumakas";
            this.btn_oyuncumakas.Size = new System.Drawing.Size(128, 61);
            this.btn_oyuncumakas.TabIndex = 0;
            this.btn_oyuncumakas.Text = "Makas";
            this.btn_oyuncumakas.UseVisualStyleBackColor = false;
            this.btn_oyuncumakas.Click += new System.EventHandler(this.btn_oyuncumakas_Click);
            // 
            // lbl_skorpc
            // 
            this.lbl_skorpc.AutoSize = true;
            this.lbl_skorpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_skorpc.Location = new System.Drawing.Point(584, 123);
            this.lbl_skorpc.Name = "lbl_skorpc";
            this.lbl_skorpc.Size = new System.Drawing.Size(23, 25);
            this.lbl_skorpc.TabIndex = 1;
            this.lbl_skorpc.Text = "0";
            this.lbl_skorpc.Click += new System.EventHandler(this.lbl_skorpc_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(285, 262);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(16, 22);
            this.lbl_sonuc.TabIndex = 2;
            this.lbl_sonuc.Text = "-";
            this.lbl_sonuc.Click += new System.EventHandler(this.lbl_sonuc_Click);
            // 
            // lbl_skoroyuncu
            // 
            this.lbl_skoroyuncu.AutoSize = true;
            this.lbl_skoroyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_skoroyuncu.Location = new System.Drawing.Point(584, 397);
            this.lbl_skoroyuncu.Name = "lbl_skoroyuncu";
            this.lbl_skoroyuncu.Size = new System.Drawing.Size(23, 25);
            this.lbl_skoroyuncu.TabIndex = 3;
            this.lbl_skoroyuncu.Text = "0";
            this.lbl_skoroyuncu.Click += new System.EventHandler(this.lbl_skoroyuncu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilgisayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oyuncu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_skoroyuncu);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_skorpc);
            this.Controls.Add(this.btn_oyuncumakas);
            this.Controls.Add(this.btn_oyuncukagit);
            this.Controls.Add(this.btn_oyuncutas);
            this.Controls.Add(this.btn_pcmakas);
            this.Controls.Add(this.btn_pckagit);
            this.Controls.Add(this.btn_pctas);
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbl_skoroyuncu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl_sonuc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl_skorpc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_pctas;
        private System.Windows.Forms.Button btn_pckagit;
        private System.Windows.Forms.Button btn_pcmakas;
        private System.Windows.Forms.Button btn_oyuncutas;
        private System.Windows.Forms.Button btn_oyuncukagit;
        private System.Windows.Forms.Button btn_oyuncumakas;
        private System.Windows.Forms.Label lbl_skorpc;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_skoroyuncu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

