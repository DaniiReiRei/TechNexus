namespace TechNexus_Daniel_Martim
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.mtxt_tarefa_inicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tarefa_fim = new System.Windows.Forms.MaskedTextBox();
            this.ckb_coordenador = new System.Windows.Forms.CheckBox();
            this.ckb_responsavel = new System.Windows.Forms.CheckBox();
            this.txt_tarefa = new System.Windows.Forms.TextBox();
            this.cmb_equipa = new System.Windows.Forms.ComboBox();
            this.cmb_funcionario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bold assumption";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(328, 277);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(328, 248);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 21;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(180, 220);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 20;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(466, 164);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(100, 22);
            this.txt_descricao.TabIndex = 19;
            // 
            // mtxt_tarefa_inicio
            // 
            this.mtxt_tarefa_inicio.Location = new System.Drawing.Point(180, 164);
            this.mtxt_tarefa_inicio.Name = "mtxt_tarefa_inicio";
            this.mtxt_tarefa_inicio.Size = new System.Drawing.Size(100, 22);
            this.mtxt_tarefa_inicio.TabIndex = 18;
            // 
            // mtxt_tarefa_fim
            // 
            this.mtxt_tarefa_fim.Location = new System.Drawing.Point(328, 164);
            this.mtxt_tarefa_fim.Name = "mtxt_tarefa_fim";
            this.mtxt_tarefa_fim.Size = new System.Drawing.Size(100, 22);
            this.mtxt_tarefa_fim.TabIndex = 17;
            // 
            // ckb_coordenador
            // 
            this.ckb_coordenador.AutoSize = true;
            this.ckb_coordenador.Location = new System.Drawing.Point(377, 107);
            this.ckb_coordenador.Name = "ckb_coordenador";
            this.ckb_coordenador.Size = new System.Drawing.Size(109, 20);
            this.ckb_coordenador.TabIndex = 16;
            this.ckb_coordenador.Text = "Coordenador";
            this.ckb_coordenador.UseVisualStyleBackColor = true;
            // 
            // ckb_responsavel
            // 
            this.ckb_responsavel.AutoSize = true;
            this.ckb_responsavel.Location = new System.Drawing.Point(510, 107);
            this.ckb_responsavel.Name = "ckb_responsavel";
            this.ckb_responsavel.Size = new System.Drawing.Size(110, 20);
            this.ckb_responsavel.TabIndex = 15;
            this.ckb_responsavel.Text = "Responsavel";
            this.ckb_responsavel.UseVisualStyleBackColor = true;
            // 
            // txt_tarefa
            // 
            this.txt_tarefa.Location = new System.Drawing.Point(369, 68);
            this.txt_tarefa.Name = "txt_tarefa";
            this.txt_tarefa.Size = new System.Drawing.Size(100, 22);
            this.txt_tarefa.TabIndex = 14;
            // 
            // cmb_equipa
            // 
            this.cmb_equipa.FormattingEnabled = true;
            this.cmb_equipa.Location = new System.Drawing.Point(180, 107);
            this.cmb_equipa.Name = "cmb_equipa";
            this.cmb_equipa.Size = new System.Drawing.Size(121, 24);
            this.cmb_equipa.TabIndex = 13;
            // 
            // cmb_funcionario
            // 
            this.cmb_funcionario.FormattingEnabled = true;
            this.cmb_funcionario.Location = new System.Drawing.Point(180, 66);
            this.cmb_funcionario.Name = "cmb_funcionario";
            this.cmb_funcionario.Size = new System.Drawing.Size(121, 24);
            this.cmb_funcionario.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.mtxt_tarefa_inicio);
            this.Controls.Add(this.mtxt_tarefa_fim);
            this.Controls.Add(this.ckb_coordenador);
            this.Controls.Add(this.ckb_responsavel);
            this.Controls.Add(this.txt_tarefa);
            this.Controls.Add(this.cmb_equipa);
            this.Controls.Add(this.cmb_funcionario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.MaskedTextBox mtxt_tarefa_inicio;
        private System.Windows.Forms.MaskedTextBox mtxt_tarefa_fim;
        private System.Windows.Forms.CheckBox ckb_coordenador;
        private System.Windows.Forms.CheckBox ckb_responsavel;
        private System.Windows.Forms.TextBox txt_tarefa;
        private System.Windows.Forms.ComboBox cmb_equipa;
        private System.Windows.Forms.ComboBox cmb_funcionario;
    }
}

