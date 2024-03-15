
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModelidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModelidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarModelidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirModelidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.modelidadeToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarLoginToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // modelidadeToolStripMenuItem
            // 
            this.modelidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModelidadeToolStripMenuItem,
            this.consultarModelidadeToolStripMenuItem,
            this.atualizarModelidadeToolStripMenuItem,
            this.excluirModelidadeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem1});
            this.modelidadeToolStripMenuItem.Name = "modelidadeToolStripMenuItem";
            this.modelidadeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.modelidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarModelidadeToolStripMenuItem
            // 
            this.cadastrarModelidadeToolStripMenuItem.Name = "cadastrarModelidadeToolStripMenuItem";
            this.cadastrarModelidadeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarModelidadeToolStripMenuItem.Text = "Cadastrar Modalidade";
            this.cadastrarModelidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarModelidadeToolStripMenuItem_Click);
            // 
            // consultarModelidadeToolStripMenuItem
            // 
            this.consultarModelidadeToolStripMenuItem.Name = "consultarModelidadeToolStripMenuItem";
            this.consultarModelidadeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarModelidadeToolStripMenuItem.Text = "Consultar Modalidade";
            this.consultarModelidadeToolStripMenuItem.Click += new System.EventHandler(this.consultarModelidadeToolStripMenuItem_Click);
            // 
            // atualizarModelidadeToolStripMenuItem
            // 
            this.atualizarModelidadeToolStripMenuItem.Name = "atualizarModelidadeToolStripMenuItem";
            this.atualizarModelidadeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.atualizarModelidadeToolStripMenuItem.Text = "Atualizar Modalidade";
            this.atualizarModelidadeToolStripMenuItem.Click += new System.EventHandler(this.atualizarModelidadeToolStripMenuItem_Click);
            // 
            // excluirModelidadeToolStripMenuItem
            // 
            this.excluirModelidadeToolStripMenuItem.Name = "excluirModelidadeToolStripMenuItem";
            this.excluirModelidadeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.excluirModelidadeToolStripMenuItem.Text = "Excluir Modalidade";
            this.excluirModelidadeToolStripMenuItem.Click += new System.EventHandler(this.excluirModelidadeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sairToolStripMenuItem2});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.turmasToolStripMenuItem.Text = "Turmas";
           
            // 
            // cadastrarTurmaToolStripMenuItem
            // 
            this.cadastrarTurmaToolStripMenuItem.Name = "cadastrarTurmaToolStripMenuItem";
            this.cadastrarTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarTurmaToolStripMenuItem.Text = "Cadastrar Turma";
            this.cadastrarTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTurmaToolStripMenuItem_Click);
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(91, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModelidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarModelidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarModelidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirModelidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
    }
}

