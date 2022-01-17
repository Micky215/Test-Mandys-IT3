namespace Test_Mandys_IT3
{
    partial class limitVyberiN
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.NumericUpDown limitVyberu;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vypisJmeno = new System.Windows.Forms.Label();
            this.vypisZustatek = new System.Windows.Forms.Label();
            this.vklad = new System.Windows.Forms.Button();
            this.vybrat = new System.Windows.Forms.Button();
            this.vkladCisla = new System.Windows.Forms.NumericUpDown();
            this.vyberCisla = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.limitPlatby = new System.Windows.Forms.Label();
            this.platba = new System.Windows.Forms.Button();
            this.limitPlatbyN = new System.Windows.Forms.NumericUpDown();
            this.platbaCisla = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            limitVyberu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(limitVyberu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkladCisla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyberCisla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPlatbyN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platbaCisla)).BeginInit();
            this.SuspendLayout();
            // 
            // limitVyberu
            // 
            limitVyberu.Location = new System.Drawing.Point(176, 199);
            limitVyberu.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            limitVyberu.Name = "limitVyberu";
            limitVyberu.Size = new System.Drawing.Size(120, 20);
            limitVyberu.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osobní účet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zůstatek";
            // 
            // vypisJmeno
            // 
            this.vypisJmeno.AutoSize = true;
            this.vypisJmeno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vypisJmeno.Location = new System.Drawing.Point(134, 49);
            this.vypisJmeno.Name = "vypisJmeno";
            this.vypisJmeno.Size = new System.Drawing.Size(10, 13);
            this.vypisJmeno.TabIndex = 6;
            this.vypisJmeno.Text = "-";
            // 
            // vypisZustatek
            // 
            this.vypisZustatek.AutoSize = true;
            this.vypisZustatek.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vypisZustatek.Location = new System.Drawing.Point(134, 72);
            this.vypisZustatek.Name = "vypisZustatek";
            this.vypisZustatek.Size = new System.Drawing.Size(10, 13);
            this.vypisZustatek.TabIndex = 9;
            this.vypisZustatek.Text = "-";
            // 
            // vklad
            // 
            this.vklad.AutoSize = true;
            this.vklad.Location = new System.Drawing.Point(47, 132);
            this.vklad.Name = "vklad";
            this.vklad.Size = new System.Drawing.Size(86, 23);
            this.vklad.TabIndex = 10;
            this.vklad.Text = "Vložit hotovost";
            this.vklad.UseVisualStyleBackColor = true;
            this.vklad.Click += new System.EventHandler(this.vklad_Click);
            // 
            // vybrat
            // 
            this.vybrat.AutoSize = true;
            this.vybrat.Location = new System.Drawing.Point(47, 161);
            this.vybrat.Name = "vybrat";
            this.vybrat.Size = new System.Drawing.Size(91, 23);
            this.vybrat.TabIndex = 11;
            this.vybrat.Text = "Vybrat hotovost";
            this.vybrat.UseVisualStyleBackColor = true;
            this.vybrat.Click += new System.EventHandler(this.vybrat_Click);
            // 
            // vkladCisla
            // 
            this.vkladCisla.Location = new System.Drawing.Point(176, 132);
            this.vkladCisla.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.vkladCisla.Name = "vkladCisla";
            this.vkladCisla.Size = new System.Drawing.Size(120, 20);
            this.vkladCisla.TabIndex = 12;
            // 
            // vyberCisla
            // 
            this.vyberCisla.Location = new System.Drawing.Point(176, 164);
            this.vyberCisla.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.vyberCisla.Name = "vyberCisla";
            this.vyberCisla.Size = new System.Drawing.Size(120, 20);
            this.vyberCisla.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Limit výběru";
            // 
            // limitPlatby
            // 
            this.limitPlatby.AutoSize = true;
            this.limitPlatby.Location = new System.Drawing.Point(389, 132);
            this.limitPlatby.Name = "limitPlatby";
            this.limitPlatby.Size = new System.Drawing.Size(59, 13);
            this.limitPlatby.TabIndex = 19;
            this.limitPlatby.Text = "Limit platby";
            // 
            // platba
            // 
            this.platba.AutoSize = true;
            this.platba.Location = new System.Drawing.Point(379, 164);
            this.platba.Name = "platba";
            this.platba.Size = new System.Drawing.Size(91, 23);
            this.platba.TabIndex = 20;
            this.platba.Text = "Zaplatit";
            this.platba.UseVisualStyleBackColor = true;
            this.platba.Click += new System.EventHandler(this.platba_Click);
            // 
            // limitPlatbyN
            // 
            this.limitPlatbyN.Location = new System.Drawing.Point(489, 130);
            this.limitPlatbyN.Name = "limitPlatbyN";
            this.limitPlatbyN.Size = new System.Drawing.Size(120, 20);
            this.limitPlatbyN.TabIndex = 21;
            // 
            // platbaCisla
            // 
            this.platbaCisla.Location = new System.Drawing.Point(489, 164);
            this.platbaCisla.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.platbaCisla.Name = "platbaCisla";
            this.platbaCisla.Size = new System.Drawing.Size(120, 20);
            this.platbaCisla.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Michal Mandys";
            // 
            // limitVyberiN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.platbaCisla);
            this.Controls.Add(this.limitPlatbyN);
            this.Controls.Add(this.platba);
            this.Controls.Add(this.limitPlatby);
            this.Controls.Add(limitVyberu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vyberCisla);
            this.Controls.Add(this.vkladCisla);
            this.Controls.Add(this.vybrat);
            this.Controls.Add(this.vklad);
            this.Controls.Add(this.vypisZustatek);
            this.Controls.Add(this.vypisJmeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "limitVyberiN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(limitVyberu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkladCisla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyberCisla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPlatbyN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platbaCisla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vypisJmeno;
        private System.Windows.Forms.Label vypisZustatek;
        private System.Windows.Forms.Button vklad;
        private System.Windows.Forms.Button vybrat;
        private System.Windows.Forms.NumericUpDown vkladCisla;
        private System.Windows.Forms.NumericUpDown vyberCisla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label limitPlatby;
        private System.Windows.Forms.Button platba;
        private System.Windows.Forms.NumericUpDown limitPlatbyN;
        private System.Windows.Forms.NumericUpDown platbaCisla;
        private System.Windows.Forms.Label label6;
    }
}

