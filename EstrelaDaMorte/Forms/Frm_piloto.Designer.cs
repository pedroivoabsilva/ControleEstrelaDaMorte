
namespace EstrelaDaMorte
{
    partial class Frm_piloto
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label anoNascimentoLabel;
            System.Windows.Forms.Label idPilotoLabel;
            System.Windows.Forms.Label idPlanetaLabel;
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pilotosDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pilotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotosNavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPlanetaComboBox = new System.Windows.Forms.ComboBox();
            this.pilotosNavesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.planetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeLabel = new System.Windows.Forms.Label();
            anoNascimentoLabel = new System.Windows.Forms.Label();
            idPilotoLabel = new System.Windows.Forms.Label();
            idPlanetaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(246, 8);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // anoNascimentoLabel
            // 
            anoNascimentoLabel.AutoSize = true;
            anoNascimentoLabel.Location = new System.Drawing.Point(10, 35);
            anoNascimentoLabel.Name = "anoNascimentoLabel";
            anoNascimentoLabel.Size = new System.Drawing.Size(88, 13);
            anoNascimentoLabel.TabIndex = 5;
            anoNascimentoLabel.Text = "Ano Nascimento:";
            // 
            // idPilotoLabel
            // 
            idPilotoLabel.AutoSize = true;
            idPilotoLabel.Location = new System.Drawing.Point(9, 9);
            idPilotoLabel.Name = "idPilotoLabel";
            idPilotoLabel.Size = new System.Drawing.Size(48, 13);
            idPilotoLabel.TabIndex = 7;
            idPilotoLabel.Text = "Id Piloto:";
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "Nome", true));
            this.txt_nome.Location = new System.Drawing.Point(290, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(218, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_ano
            // 
            this.txt_ano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "AnoNascimento", true));
            this.txt_ano.Location = new System.Drawing.Point(104, 32);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(121, 20);
            this.txt_ano.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "IdPiloto", true));
            this.txt_id.Location = new System.Drawing.Point(104, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 8;
            // 
            // pilotosDataGridView
            // 
            this.pilotosDataGridView.AllowUserToAddRows = false;
            this.pilotosDataGridView.AllowUserToDeleteRows = false;
            this.pilotosDataGridView.AutoGenerateColumns = false;
            this.pilotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.pilotosDataGridView.DataSource = this.pilotosBindingSource;
            this.pilotosDataGridView.Location = new System.Drawing.Point(12, 92);
            this.pilotosDataGridView.Name = "pilotosDataGridView";
            this.pilotosDataGridView.ReadOnly = true;
            this.pilotosDataGridView.Size = new System.Drawing.Size(496, 253);
            this.pilotosDataGridView.TabIndex = 10;
            this.pilotosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilotosDataGridView_CellContentClick);
            this.pilotosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pilotosDataGridView_CellFormatting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pilotosBindingSource
            // 
            this.pilotosBindingSource.DataSource = typeof(Sistema.DAL.Pilotos);
            // 
            // pilotosNavesBindingSource
            // 
            this.pilotosNavesBindingSource.DataMember = "PilotosNaves";
            this.pilotosNavesBindingSource.DataSource = this.pilotosBindingSource;
            // 
            // idPlanetaLabel
            // 
            idPlanetaLabel.AutoSize = true;
            idPlanetaLabel.Location = new System.Drawing.Point(246, 39);
            idPlanetaLabel.Name = "idPlanetaLabel";
            idPlanetaLabel.Size = new System.Drawing.Size(46, 13);
            idPlanetaLabel.TabIndex = 14;
            idPlanetaLabel.Text = "Planeta:";
            // 
            // idPlanetaComboBox
            // 
            this.idPlanetaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilotosBindingSource, "IdPlaneta", true));
            this.idPlanetaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pilotosBindingSource, "IdPlaneta", true));
            this.idPlanetaComboBox.DataSource = this.planetasBindingSource;
            this.idPlanetaComboBox.DisplayMember = "Nome";
            this.idPlanetaComboBox.FormattingEnabled = true;
            this.idPlanetaComboBox.Location = new System.Drawing.Point(310, 36);
            this.idPlanetaComboBox.Name = "idPlanetaComboBox";
            this.idPlanetaComboBox.Size = new System.Drawing.Size(198, 21);
            this.idPlanetaComboBox.TabIndex = 15;
            this.idPlanetaComboBox.ValueMember = "IdPlaneta";
            // 
            // pilotosNavesBindingSource1
            // 
            this.pilotosNavesBindingSource1.DataMember = "PilotosNaves";
            this.pilotosNavesBindingSource1.DataSource = this.pilotosBindingSource;
            // 
            // planetasBindingSource
            // 
            this.planetasBindingSource.DataSource = typeof(Sistema.DAL.Planetas);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPiloto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnoNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano de Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Planetas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Planetas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Frm_piloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 358);
            this.Controls.Add(idPlanetaLabel);
            this.Controls.Add(this.idPlanetaComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pilotosDataGridView);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(anoNascimentoLabel);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(idPilotoLabel);
            this.Name = "Frm_piloto";
            this.Text = "Cadastro de Pilotos";
            this.Load += new System.EventHandler(this.Frm_piloto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotosNavesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pilotosBindingSource;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView pilotosDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource pilotosNavesBindingSource;
        private System.Windows.Forms.ComboBox idPlanetaComboBox;
        private System.Windows.Forms.BindingSource planetasBindingSource;
        private System.Windows.Forms.BindingSource pilotosNavesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}