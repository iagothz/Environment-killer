namespace Game_Killer
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
            cbox_ativo = new CheckBox();
            lbl_status = new Label();
            label2 = new Label();
            label3 = new Label();
            check_jogos = new CheckBox();
            check_video = new CheckBox();
            check_musica = new CheckBox();
            cbox_horario = new CheckBox();
            combo_horaInicio = new ComboBox();
            combo_minutoInicio = new ComboBox();
            combo_minutoFim = new ComboBox();
            combo_horaFim = new ComboBox();
            lbl_info1 = new Label();
            lbl_info2 = new Label();
            lbl_info3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cbox_ativo
            // 
            cbox_ativo.AutoSize = true;
            cbox_ativo.Location = new Point(12, 12);
            cbox_ativo.Name = "cbox_ativo";
            cbox_ativo.Size = new Size(121, 19);
            cbox_ativo.TabIndex = 0;
            cbox_ativo.Text = "Ativar Modo Foco";
            cbox_ativo.UseVisualStyleBackColor = true;
            cbox_ativo.CheckStateChanged += cbox_ativo_CheckStateChanged;
            // 
            // lbl_status
            // 
            lbl_status.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(293, 9);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(56, 15);
            lbl_status.TabIndex = 1;
            lbl_status.Text = "lbl_status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 80);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 7;
            label2.Text = "até";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Ativar para:";
            // 
            // check_jogos
            // 
            check_jogos.AutoSize = true;
            check_jogos.Location = new Point(23, 137);
            check_jogos.Name = "check_jogos";
            check_jogos.Size = new Size(56, 19);
            check_jogos.TabIndex = 9;
            check_jogos.Text = "Jogos";
            check_jogos.UseVisualStyleBackColor = true;
            check_jogos.CheckedChanged += check_jogos_CheckedChanged;
            // 
            // check_video
            // 
            check_video.AutoSize = true;
            check_video.Location = new Point(23, 162);
            check_video.Name = "check_video";
            check_video.Size = new Size(61, 19);
            check_video.TabIndex = 10;
            check_video.Text = "Videos";
            check_video.UseVisualStyleBackColor = true;
            check_video.CheckedChanged += check_video_CheckedChanged;
            // 
            // check_musica
            // 
            check_musica.AutoSize = true;
            check_musica.Location = new Point(23, 187);
            check_musica.Name = "check_musica";
            check_musica.Size = new Size(69, 19);
            check_musica.TabIndex = 11;
            check_musica.Text = "Músicas";
            check_musica.UseVisualStyleBackColor = true;
            check_musica.CheckedChanged += check_musica_CheckedChanged;
            // 
            // cbox_horario
            // 
            cbox_horario.AutoSize = true;
            cbox_horario.Location = new Point(12, 52);
            cbox_horario.Name = "cbox_horario";
            cbox_horario.Size = new Size(119, 19);
            cbox_horario.TabIndex = 12;
            cbox_horario.Text = "Ativar por horário";
            cbox_horario.UseVisualStyleBackColor = true;
            cbox_horario.CheckStateChanged += cbox_horario_CheckStateChanged;
            // 
            // combo_horaInicio
            // 
            combo_horaInicio.FormattingEnabled = true;
            combo_horaInicio.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            combo_horaInicio.Location = new Point(12, 77);
            combo_horaInicio.Name = "combo_horaInicio";
            combo_horaInicio.Size = new Size(50, 23);
            combo_horaInicio.TabIndex = 13;
            // 
            // combo_minutoInicio
            // 
            combo_minutoInicio.FormattingEnabled = true;
            combo_minutoInicio.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            combo_minutoInicio.Location = new Point(68, 77);
            combo_minutoInicio.Name = "combo_minutoInicio";
            combo_minutoInicio.Size = new Size(50, 23);
            combo_minutoInicio.TabIndex = 14;
            // 
            // combo_minutoFim
            // 
            combo_minutoFim.FormattingEnabled = true;
            combo_minutoFim.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            combo_minutoFim.Location = new Point(207, 77);
            combo_minutoFim.Name = "combo_minutoFim";
            combo_minutoFim.Size = new Size(50, 23);
            combo_minutoFim.TabIndex = 16;
            // 
            // combo_horaFim
            // 
            combo_horaFim.FormattingEnabled = true;
            combo_horaFim.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            combo_horaFim.Location = new Point(151, 77);
            combo_horaFim.Name = "combo_horaFim";
            combo_horaFim.Size = new Size(50, 23);
            combo_horaFim.TabIndex = 15;
            // 
            // lbl_info1
            // 
            lbl_info1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_info1.AutoSize = true;
            lbl_info1.Location = new Point(12, 221);
            lbl_info1.Name = "lbl_info1";
            lbl_info1.Size = new Size(38, 15);
            lbl_info1.TabIndex = 17;
            lbl_info1.Text = "label1";
            lbl_info1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_info2
            // 
            lbl_info2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_info2.AutoSize = true;
            lbl_info2.Location = new Point(12, 252);
            lbl_info2.Name = "lbl_info2";
            lbl_info2.Size = new Size(38, 15);
            lbl_info2.TabIndex = 18;
            lbl_info2.Text = "label1";
            lbl_info2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_info3
            // 
            lbl_info3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_info3.AutoSize = true;
            lbl_info3.Location = new Point(12, 284);
            lbl_info3.Name = "lbl_info3";
            lbl_info3.Size = new Size(38, 15);
            lbl_info3.TabIndex = 19;
            lbl_info3.Text = "label1";
            lbl_info3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(197, 133);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 321);
            Controls.Add(numericUpDown1);
            Controls.Add(lbl_info3);
            Controls.Add(lbl_info2);
            Controls.Add(lbl_info1);
            Controls.Add(combo_minutoFim);
            Controls.Add(combo_horaFim);
            Controls.Add(combo_minutoInicio);
            Controls.Add(combo_horaInicio);
            Controls.Add(cbox_horario);
            Controls.Add(check_musica);
            Controls.Add(check_video);
            Controls.Add(check_jogos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_status);
            Controls.Add(cbox_ativo);
            Name = "Form1";
            Text = "Enternainment Killer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbox_ativo;
        private Label lbl_status;
        private Label label2;
        private Label label3;
        private CheckBox check_jogos;
        private CheckBox check_video;
        private CheckBox check_musica;
        private CheckBox cbox_horario;
        private ComboBox combo_horaInicio;
        private ComboBox combo_minutoInicio;
        private ComboBox combo_minutoFim;
        private ComboBox combo_horaFim;
        private Label lbl_info1;
        private Label lbl_info2;
        private Label lbl_info3;
        private NumericUpDown numericUpDown1;
    }
}
