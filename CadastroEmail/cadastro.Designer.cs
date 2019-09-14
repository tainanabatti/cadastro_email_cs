namespace CadastroEmail
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            System.Windows.Forms.Label email_origemLabel;
            System.Windows.Forms.Label email_destinoLabel;
            System.Windows.Forms.Label nome_origemLabel;
            System.Windows.Forms.Label nome_destinoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label mensagemLabel;
            System.Windows.Forms.Label statusLabel;
            this.envio_emailDataSet = new CadastroEmail.envio_emailDataSet();
            this.emailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTableAdapter = new CadastroEmail.envio_emailDataSetTableAdapters.emailTableAdapter();
            this.tableAdapterManager = new CadastroEmail.envio_emailDataSetTableAdapters.TableAdapterManager();
            this.emailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.emailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.email_origemTextBox = new System.Windows.Forms.TextBox();
            this.email_destinoTextBox = new System.Windows.Forms.TextBox();
            this.nome_origemTextBox = new System.Windows.Forms.TextBox();
            this.nome_destinoTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.mensagemTextBox = new System.Windows.Forms.TextBox();
            this.emailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            email_origemLabel = new System.Windows.Forms.Label();
            email_destinoLabel = new System.Windows.Forms.Label();
            nome_origemLabel = new System.Windows.Forms.Label();
            nome_destinoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            mensagemLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.envio_emailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingNavigator)).BeginInit();
            this.emailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // envio_emailDataSet
            // 
            this.envio_emailDataSet.DataSetName = "envio_emailDataSet";
            this.envio_emailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailBindingSource
            // 
            this.emailBindingSource.DataMember = "email";
            this.emailBindingSource.DataSource = this.envio_emailDataSet;
            // 
            // emailTableAdapter
            // 
            this.emailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.emailTableAdapter = this.emailTableAdapter;
            this.tableAdapterManager.UpdateOrder = CadastroEmail.envio_emailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emailBindingNavigator
            // 
            this.emailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emailBindingNavigator.BindingSource = this.emailBindingSource;
            this.emailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.emailBindingNavigatorSaveItem});
            this.emailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emailBindingNavigator.Name = "emailBindingNavigator";
            this.emailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emailBindingNavigator.Size = new System.Drawing.Size(705, 25);
            this.emailBindingNavigator.TabIndex = 0;
            this.emailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // emailBindingNavigatorSaveItem
            // 
            this.emailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emailBindingNavigatorSaveItem.Image")));
            this.emailBindingNavigatorSaveItem.Name = "emailBindingNavigatorSaveItem";
            this.emailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.emailBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.emailBindingNavigatorSaveItem.Click += new System.EventHandler(this.emailBindingNavigatorSaveItem_Click);
            // 
            // email_origemLabel
            // 
            email_origemLabel.AutoSize = true;
            email_origemLabel.Location = new System.Drawing.Point(12, 45);
            email_origemLabel.Name = "email_origemLabel";
            email_origemLabel.Size = new System.Drawing.Size(68, 13);
            email_origemLabel.TabIndex = 1;
            email_origemLabel.Text = "email origem:";
            // 
            // email_origemTextBox
            // 
            this.email_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "email_origem", true));
            this.email_origemTextBox.Location = new System.Drawing.Point(86, 42);
            this.email_origemTextBox.Name = "email_origemTextBox";
            this.email_origemTextBox.Size = new System.Drawing.Size(224, 20);
            this.email_origemTextBox.TabIndex = 2;
            this.email_origemTextBox.TextChanged += new System.EventHandler(this.email_origemTextBox_TextChanged);
            // 
            // email_destinoLabel
            // 
            email_destinoLabel.AutoSize = true;
            email_destinoLabel.Location = new System.Drawing.Point(331, 45);
            email_destinoLabel.Name = "email_destinoLabel";
            email_destinoLabel.Size = new System.Drawing.Size(71, 13);
            email_destinoLabel.TabIndex = 3;
            email_destinoLabel.Text = "email destino:";
            // 
            // email_destinoTextBox
            // 
            this.email_destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "email_destino", true));
            this.email_destinoTextBox.Location = new System.Drawing.Point(408, 42);
            this.email_destinoTextBox.Name = "email_destinoTextBox";
            this.email_destinoTextBox.Size = new System.Drawing.Size(248, 20);
            this.email_destinoTextBox.TabIndex = 4;
            // 
            // nome_origemLabel
            // 
            nome_origemLabel.AutoSize = true;
            nome_origemLabel.Location = new System.Drawing.Point(10, 86);
            nome_origemLabel.Name = "nome_origemLabel";
            nome_origemLabel.Size = new System.Drawing.Size(70, 13);
            nome_origemLabel.TabIndex = 5;
            nome_origemLabel.Text = "nome origem:";
            // 
            // nome_origemTextBox
            // 
            this.nome_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "nome_origem", true));
            this.nome_origemTextBox.Location = new System.Drawing.Point(86, 83);
            this.nome_origemTextBox.Name = "nome_origemTextBox";
            this.nome_origemTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_origemTextBox.TabIndex = 6;
            // 
            // nome_destinoLabel
            // 
            nome_destinoLabel.AutoSize = true;
            nome_destinoLabel.Location = new System.Drawing.Point(199, 86);
            nome_destinoLabel.Name = "nome_destinoLabel";
            nome_destinoLabel.Size = new System.Drawing.Size(73, 13);
            nome_destinoLabel.TabIndex = 7;
            nome_destinoLabel.Text = "nome destino:";
            nome_destinoLabel.Click += new System.EventHandler(this.nome_destinoLabel_Click);
            // 
            // nome_destinoTextBox
            // 
            this.nome_destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "nome_destino", true));
            this.nome_destinoTextBox.Location = new System.Drawing.Point(278, 83);
            this.nome_destinoTextBox.Name = "nome_destinoTextBox";
            this.nome_destinoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_destinoTextBox.TabIndex = 8;
            this.nome_destinoTextBox.TextChanged += new System.EventHandler(this.nome_destinoTextBox_TextChanged);
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(396, 86);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(47, 13);
            assuntoLabel.TabIndex = 9;
            assuntoLabel.Text = "assunto:";
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(449, 83);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(100, 20);
            this.assuntoTextBox.TabIndex = 10;
            // 
            // mensagemLabel
            // 
            mensagemLabel.AutoSize = true;
            mensagemLabel.Location = new System.Drawing.Point(10, 130);
            mensagemLabel.Name = "mensagemLabel";
            mensagemLabel.Size = new System.Drawing.Size(61, 13);
            mensagemLabel.TabIndex = 11;
            mensagemLabel.Text = "mensagem:";
            // 
            // mensagemTextBox
            // 
            this.mensagemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "mensagem", true));
            this.mensagemTextBox.Location = new System.Drawing.Point(86, 127);
            this.mensagemTextBox.Multiline = true;
            this.mensagemTextBox.Name = "mensagemTextBox";
            this.mensagemTextBox.Size = new System.Drawing.Size(570, 60);
            this.mensagemTextBox.TabIndex = 12;
            // 
            // emailDataGridView
            // 
            this.emailDataGridView.AutoGenerateColumns = false;
            this.emailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.emailDataGridView.DataSource = this.emailBindingSource;
            this.emailDataGridView.Location = new System.Drawing.Point(15, 207);
            this.emailDataGridView.Name = "emailDataGridView";
            this.emailDataGridView.Size = new System.Drawing.Size(641, 220);
            this.emailDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email_destino";
            this.dataGridViewTextBoxColumn3.HeaderText = "email_destino";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome_origem";
            this.dataGridViewTextBoxColumn4.HeaderText = "nome_origem";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nome_destino";
            this.dataGridViewTextBoxColumn5.HeaderText = "nome_destino";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "assunto";
            this.dataGridViewTextBoxColumn6.HeaderText = "assunto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "mensagem";
            this.dataGridViewTextBoxColumn7.HeaderText = "mensagem";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn8.HeaderText = "status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(568, 86);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(612, 83);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(44, 20);
            this.statusTextBox.TabIndex = 15;
            this.statusTextBox.Tag = "0";
            this.statusTextBox.Text = "0";
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 447);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.emailDataGridView);
            this.Controls.Add(mensagemLabel);
            this.Controls.Add(this.mensagemTextBox);
            this.Controls.Add(assuntoLabel);
            this.Controls.Add(this.assuntoTextBox);
            this.Controls.Add(nome_destinoLabel);
            this.Controls.Add(this.nome_destinoTextBox);
            this.Controls.Add(nome_origemLabel);
            this.Controls.Add(this.nome_origemTextBox);
            this.Controls.Add(email_destinoLabel);
            this.Controls.Add(this.email_destinoTextBox);
            this.Controls.Add(email_origemLabel);
            this.Controls.Add(this.email_origemTextBox);
            this.Controls.Add(this.emailBindingNavigator);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.envio_emailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingNavigator)).EndInit();
            this.emailBindingNavigator.ResumeLayout(false);
            this.emailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private envio_emailDataSet envio_emailDataSet;
        private System.Windows.Forms.BindingSource emailBindingSource;
        private envio_emailDataSetTableAdapters.emailTableAdapter emailTableAdapter;
        private envio_emailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emailBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton emailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox email_origemTextBox;
        private System.Windows.Forms.TextBox email_destinoTextBox;
        private System.Windows.Forms.TextBox nome_origemTextBox;
        private System.Windows.Forms.TextBox nome_destinoTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox mensagemTextBox;
        private System.Windows.Forms.DataGridView emailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}