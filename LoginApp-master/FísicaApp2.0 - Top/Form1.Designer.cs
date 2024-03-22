namespace FísicaApp2._0___Top
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            DistVm = new Label();
            TempVm = new Label();
            Painelvmedia = new Panel();
            VmTemp = new NumericUpDown();
            VmDist = new NumericUpDown();
            PainelMU = new Panel();
            MUtemp = new NumericUpDown();
            MUvel = new NumericUpDown();
            MUspace = new NumericUpDown();
            TempMU = new Label();
            velocMU = new Label();
            IniSpaceMU = new Label();
            Painelxrl8 = new Panel();
            AceTemp = new NumericUpDown();
            AceVel = new NumericUpDown();
            TempAce = new Label();
            VelAce = new Label();
            Paineltorricelli = new Panel();
            TorrAce = new NumericUpDown();
            TorrDist = new NumericUpDown();
            TorrVel = new NumericUpDown();
            AccTorr = new Label();
            DisTorr = new Label();
            VInicTorr = new Label();
            Calcular = new Button();
            label11 = new Label();
            Result = new Label();
            lblResultado = new Label();
            groupBox1.SuspendLayout();
            Painelvmedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VmTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VmDist).BeginInit();
            PainelMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MUtemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MUvel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MUspace).BeginInit();
            Painelxrl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AceTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AceVel).BeginInit();
            Paineltorricelli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TorrAce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TorrDist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TorrVel).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(38, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caixa de seleção de cálculo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F);
            radioButton4.Location = new Point(622, 31);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(86, 25);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Torricelli";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F);
            radioButton3.Location = new Point(396, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(178, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Movimento Uniforme";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(229, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Aceleração";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(23, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(150, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Velocidade Média";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // DistVm
            // 
            DistVm.AutoSize = true;
            DistVm.Font = new Font("Segoe UI", 12F);
            DistVm.Location = new Point(3, 24);
            DistVm.Name = "DistVm";
            DistVm.Size = new Size(76, 21);
            DistVm.TabIndex = 1;
            DistVm.Text = "Distância:";
            // 
            // TempVm
            // 
            TempVm.AutoSize = true;
            TempVm.Font = new Font("Segoe UI", 12F);
            TempVm.Location = new Point(3, 63);
            TempVm.Name = "TempVm";
            TempVm.Size = new Size(59, 21);
            TempVm.TabIndex = 2;
            TempVm.Text = "Tempo:";
            TempVm.Click += label2_Click;
            // 
            // Painelvmedia
            // 
            Painelvmedia.Controls.Add(VmTemp);
            Painelvmedia.Controls.Add(VmDist);
            Painelvmedia.Controls.Add(DistVm);
            Painelvmedia.Controls.Add(TempVm);
            Painelvmedia.Location = new Point(18, 95);
            Painelvmedia.Name = "Painelvmedia";
            Painelvmedia.Size = new Size(158, 117);
            Painelvmedia.TabIndex = 4;
            // 
            // VmTemp
            // 
            VmTemp.Location = new Point(98, 66);
            VmTemp.Name = "VmTemp";
            VmTemp.Size = new Size(120, 23);
            VmTemp.TabIndex = 4;
            // 
            // VmDist
            // 
            VmDist.Location = new Point(98, 24);
            VmDist.Name = "VmDist";
            VmDist.Size = new Size(120, 23);
            VmDist.TabIndex = 3;
            // 
            // PainelMU
            // 
            PainelMU.Controls.Add(MUtemp);
            PainelMU.Controls.Add(MUvel);
            PainelMU.Controls.Add(MUspace);
            PainelMU.Controls.Add(TempMU);
            PainelMU.Controls.Add(velocMU);
            PainelMU.Controls.Add(IniSpaceMU);
            PainelMU.Location = new Point(434, 95);
            PainelMU.Name = "PainelMU";
            PainelMU.Size = new Size(161, 109);
            PainelMU.TabIndex = 6;
            // 
            // MUtemp
            // 
            MUtemp.Location = new Point(111, 77);
            MUtemp.Name = "MUtemp";
            MUtemp.Size = new Size(120, 23);
            MUtemp.TabIndex = 16;
            // 
            // MUvel
            // 
            MUvel.Location = new Point(111, 43);
            MUvel.Name = "MUvel";
            MUvel.Size = new Size(120, 23);
            MUvel.TabIndex = 15;
            // 
            // MUspace
            // 
            MUspace.Location = new Point(111, 14);
            MUspace.Name = "MUspace";
            MUspace.Size = new Size(120, 23);
            MUspace.TabIndex = 14;
            // 
            // TempMU
            // 
            TempMU.AutoSize = true;
            TempMU.Font = new Font("Segoe UI", 12F);
            TempMU.Location = new Point(3, 74);
            TempMU.Name = "TempMU";
            TempMU.Size = new Size(56, 21);
            TempMU.TabIndex = 11;
            TempMU.Text = "Tempo";
            // 
            // velocMU
            // 
            velocMU.AutoSize = true;
            velocMU.Font = new Font("Segoe UI", 12F);
            velocMU.Location = new Point(9, 45);
            velocMU.Name = "velocMU";
            velocMU.Size = new Size(85, 21);
            velocMU.TabIndex = 13;
            velocMU.Text = "Velocidade";
            // 
            // IniSpaceMU
            // 
            IniSpaceMU.AutoSize = true;
            IniSpaceMU.Font = new Font("Segoe UI", 12F);
            IniSpaceMU.Location = new Point(3, 12);
            IniSpaceMU.Name = "IniSpaceMU";
            IniSpaceMU.Size = new Size(102, 21);
            IniSpaceMU.TabIndex = 12;
            IniSpaceMU.Text = "Espaço Inicial";
            // 
            // Painelxrl8
            // 
            Painelxrl8.Controls.Add(AceTemp);
            Painelxrl8.Controls.Add(AceVel);
            Painelxrl8.Controls.Add(TempAce);
            Painelxrl8.Controls.Add(VelAce);
            Painelxrl8.Location = new Point(202, 95);
            Painelxrl8.Name = "Painelxrl8";
            Painelxrl8.Size = new Size(226, 109);
            Painelxrl8.TabIndex = 5;
            Painelxrl8.Paint += xrl8_Paint;
            // 
            // AceTemp
            // 
            AceTemp.Location = new Point(199, 63);
            AceTemp.Name = "AceTemp";
            AceTemp.Size = new Size(120, 23);
            AceTemp.TabIndex = 16;
            // 
            // AceVel
            // 
            AceVel.Location = new Point(199, 28);
            AceVel.Name = "AceVel";
            AceVel.Size = new Size(120, 23);
            AceVel.TabIndex = 15;
            // 
            // TempAce
            // 
            TempAce.AutoSize = true;
            TempAce.Font = new Font("Segoe UI", 12F);
            TempAce.Location = new Point(3, 65);
            TempAce.Name = "TempAce";
            TempAce.Size = new Size(141, 21);
            TempAce.TabIndex = 14;
            TempAce.Text = "Variação do Tempo";
            TempAce.Click += label10_Click;
            // 
            // VelAce
            // 
            VelAce.AutoSize = true;
            VelAce.Font = new Font("Segoe UI", 12F);
            VelAce.Location = new Point(0, 26);
            VelAce.Name = "VelAce";
            VelAce.Size = new Size(169, 21);
            VelAce.TabIndex = 7;
            VelAce.Text = "Variação da Velocidade";
            VelAce.Click += label3_Click;
            // 
            // Paineltorricelli
            // 
            Paineltorricelli.Controls.Add(TorrAce);
            Paineltorricelli.Controls.Add(TorrDist);
            Paineltorricelli.Controls.Add(TorrVel);
            Paineltorricelli.Controls.Add(AccTorr);
            Paineltorricelli.Controls.Add(DisTorr);
            Paineltorricelli.Controls.Add(VInicTorr);
            Paineltorricelli.Location = new Point(617, 95);
            Paineltorricelli.Name = "Paineltorricelli";
            Paineltorricelli.Size = new Size(148, 109);
            Paineltorricelli.TabIndex = 6;
            // 
            // TorrAce
            // 
            TorrAce.Location = new Point(165, 43);
            TorrAce.Name = "TorrAce";
            TorrAce.Size = new Size(120, 23);
            TorrAce.TabIndex = 13;
            // 
            // TorrDist
            // 
            TorrDist.Location = new Point(165, 72);
            TorrDist.Name = "TorrDist";
            TorrDist.Size = new Size(120, 23);
            TorrDist.TabIndex = 12;
            // 
            // TorrVel
            // 
            TorrVel.Location = new Point(165, 10);
            TorrVel.Name = "TorrVel";
            TorrVel.Size = new Size(120, 23);
            TorrVel.TabIndex = 11;
            // 
            // AccTorr
            // 
            AccTorr.AutoSize = true;
            AccTorr.Font = new Font("Segoe UI", 12F);
            AccTorr.Location = new Point(3, 45);
            AccTorr.Name = "AccTorr";
            AccTorr.Size = new Size(85, 21);
            AccTorr.TabIndex = 8;
            AccTorr.Text = "Aceleração";
            AccTorr.Click += label4_Click;
            // 
            // DisTorr
            // 
            DisTorr.AutoSize = true;
            DisTorr.Font = new Font("Segoe UI", 12F);
            DisTorr.Location = new Point(0, 74);
            DisTorr.Name = "DisTorr";
            DisTorr.Size = new Size(73, 21);
            DisTorr.TabIndex = 9;
            DisTorr.Text = "Distância";
            DisTorr.Click += label5_Click;
            // 
            // VInicTorr
            // 
            VInicTorr.AutoSize = true;
            VInicTorr.Font = new Font("Segoe UI", 12F);
            VInicTorr.Location = new Point(3, 12);
            VInicTorr.Name = "VInicTorr";
            VInicTorr.Size = new Size(133, 21);
            VInicTorr.TabIndex = 10;
            VInicTorr.Text = "Velocidade Inicial ";
            VInicTorr.Click += label6_Click;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 12F);
            Calcular.Location = new Point(61, 218);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(685, 38);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(61, 306);
            label11.Name = "label11";
            label11.Size = new Size(86, 21);
            label11.TabIndex = 8;
            label11.Text = "Resultado: ";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 12F);
            Result.Location = new Point(153, 306);
            Result.Name = "Result";
            Result.Size = new Size(0, 21);
            Result.TabIndex = 9;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(176, 306);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(Painelxrl8);
            Controls.Add(Paineltorricelli);
            Controls.Add(Result);
            Controls.Add(label11);
            Controls.Add(Calcular);
            Controls.Add(PainelMU);
            Controls.Add(Painelvmedia);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Fisica App 2.0 Top";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Painelvmedia.ResumeLayout(false);
            Painelvmedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VmTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)VmDist).EndInit();
            PainelMU.ResumeLayout(false);
            PainelMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MUtemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)MUvel).EndInit();
            ((System.ComponentModel.ISupportInitialize)MUspace).EndInit();
            Painelxrl8.ResumeLayout(false);
            Painelxrl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AceTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)AceVel).EndInit();
            Paineltorricelli.ResumeLayout(false);
            Paineltorricelli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TorrAce).EndInit();
            ((System.ComponentModel.ISupportInitialize)TorrDist).EndInit();
            ((System.ComponentModel.ISupportInitialize)TorrVel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label DistVm;
        private Label TempVm;
        private Panel Painelvmedia;
        private Panel Painelxrl8;
        private Panel PainelMU;
        private Panel Paineltorricelli;
        private Label AccTorr;
        private Label DisTorr;
        private Label VInicTorr;
        private Label TempMU;
        private Label IniSpaceMU;
        private Label velocMU;
        private Label TempAce;
        private Label VelAce;
        private Button Calcular;
        private Label label11;
        private Label Result;
        private NumericUpDown MUtemp;
        private NumericUpDown MUvel;
        private NumericUpDown MUspace;
        private NumericUpDown TorrAce;
        private NumericUpDown TorrDist;
        private NumericUpDown TorrVel;
        private NumericUpDown VmTemp;
        private NumericUpDown VmDist;
        private NumericUpDown AceTemp;
        private NumericUpDown AceVel;
        private Label lblResultado;
    }
}
