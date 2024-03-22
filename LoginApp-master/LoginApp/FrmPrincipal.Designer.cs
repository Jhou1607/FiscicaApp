namespace LoginApp
{
    partial class FrmPrincipal
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
            label1 = new Label();
            menu = new MenuStrip();
            açoesToolStripMenuItem = new ToolStripMenuItem();
            aptSaudacoes = new ToolStripMenuItem();
            aptSobre = new ToolStripMenuItem();
            aptSair = new ToolStripMenuItem();
            EndSession = new ToolStripMenuItem();
            aptCalcIMC = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(283, 55);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 1;
            label1.Text = "Seja bem vindo(a)!";
            label1.Click += label1_Click;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { açoesToolStripMenuItem, aptSobre, aptSair, EndSession, aptCalcIMC });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // açoesToolStripMenuItem
            // 
            açoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aptSaudacoes });
            açoesToolStripMenuItem.Name = "açoesToolStripMenuItem";
            açoesToolStripMenuItem.Size = new Size(51, 20);
            açoesToolStripMenuItem.Text = "Açoes";
            // 
            // aptSaudacoes
            // 
            aptSaudacoes.Name = "aptSaudacoes";
            aptSaudacoes.Size = new Size(130, 22);
            aptSaudacoes.Text = "Saudações";
            aptSaudacoes.Click += aptSaudacoes_Click;
            // 
            // aptSobre
            // 
            aptSobre.Name = "aptSobre";
            aptSobre.Size = new Size(49, 20);
            aptSobre.Text = "Sobre";
            aptSobre.Click += aptSobre_Click;
            // 
            // aptSair
            // 
            aptSair.Name = "aptSair";
            aptSair.Size = new Size(38, 20);
            aptSair.Text = "Sair";
            aptSair.Click += aptSair_Click;
            // 
            // EndSession
            // 
            EndSession.Name = "EndSession";
            EndSession.Size = new Size(100, 20);
            EndSession.Text = "Encerrar Sessão";
            EndSession.Click += EndSession_Click;
            // 
            // aptCalcIMC
            // 
            aptCalcIMC.Name = "aptCalcIMC";
            aptCalcIMC.Size = new Size(107, 20);
            aptCalcIMC.Text = "Calculadora IMC";
            aptCalcIMC.Click += aptCalcIMC_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "FrmPrincipal";
            Text = "Tela Principal";
            FormClosed += FrmPrincipal_FormClosed;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menu;
        private ToolStripMenuItem açoesToolStripMenuItem;
        private ToolStripMenuItem aptSaudacoes;
        private ToolStripMenuItem aptSobre;
        private ToolStripMenuItem aptSair;
        private ToolStripMenuItem EndSession;
        private ToolStripMenuItem aptCalcIMC;
    }
}