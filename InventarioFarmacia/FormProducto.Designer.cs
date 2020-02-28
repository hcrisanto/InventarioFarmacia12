namespace InventarioFarmacia
{
    partial class FormProducto
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label literaLabel;
            System.Windows.Forms.Label medicamentoLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            this.listaProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.listaProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.literaTextBox = new System.Windows.Forms.TextBox();
            this.medicamentoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            descripcionLabel = new System.Windows.Forms.Label();
            disponibleLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            literaLabel = new System.Windows.Forms.Label();
            medicamentoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).BeginInit();
            this.listaProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 91);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 52;
            descripcionLabel.Text = "Descripcion:";
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(12, 192);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 54;
            disponibleLabel.Text = "Disponible:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(12, 166);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 56;
            existenciaLabel.Text = "Existencia:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 58;
            idLabel.Text = "Id:";
            // 
            // literaLabel
            // 
            literaLabel.AutoSize = true;
            literaLabel.Location = new System.Drawing.Point(12, 140);
            literaLabel.Name = "literaLabel";
            literaLabel.Size = new System.Drawing.Size(36, 13);
            literaLabel.TabIndex = 60;
            literaLabel.Text = "Litera:";
            // 
            // medicamentoLabel
            // 
            medicamentoLabel.AutoSize = true;
            medicamentoLabel.Location = new System.Drawing.Point(9, 61);
            medicamentoLabel.Name = "medicamentoLabel";
            medicamentoLabel.Size = new System.Drawing.Size(74, 13);
            medicamentoLabel.TabIndex = 62;
            medicamentoLabel.Text = "Medicamento:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(12, 114);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 64;
            precioLabel.Text = "Precio:";
            // 
            // listaProductosBindingNavigator
            // 
            this.listaProductosBindingNavigator.AddNewItem = null;
            this.listaProductosBindingNavigator.BindingSource = this.listaProductosBindingSource;
            this.listaProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductosBindingNavigator.DeleteItem = null;
            this.listaProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaProductosBindingNavigatorSaveItem,
            this.Cancelar});
            this.listaProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductosBindingNavigator.Name = "listaProductosBindingNavigator";
            this.listaProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductosBindingNavigator.Size = new System.Drawing.Size(791, 25);
            this.listaProductosBindingNavigator.TabIndex = 0;
            this.listaProductosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(BL.InventarioFarmacia.Producto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
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
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaProductosBindingNavigatorSaveItem
            // 
            this.listaProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProductosBindingNavigatorSaveItem.Image")));
            this.listaProductosBindingNavigatorSaveItem.Name = "listaProductosBindingNavigatorSaveItem";
            this.listaProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaProductosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorSaveItem_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(57, 22);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.ToolTipText = "toolStripButton1";
            this.Cancelar.Visible = false;
            // 
            // listaProductosDataGridView
            // 
            this.listaProductosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaProductosDataGridView.AutoGenerateColumns = false;
            this.listaProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.listaProductosDataGridView.DataSource = this.listaProductosBindingSource;
            this.listaProductosDataGridView.Location = new System.Drawing.Point(0, 268);
            this.listaProductosDataGridView.Name = "listaProductosDataGridView";
            this.listaProductosDataGridView.Size = new System.Drawing.Size(791, 290);
            this.listaProductosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Medicamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medicamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Litera";
            this.dataGridViewTextBoxColumn5.HeaderText = "Litera";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Existencia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Existencia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disponible";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disponible";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(101, 84);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descripcionTextBox.TabIndex = 53;
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(104, 192);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disponibleCheckBox.TabIndex = 55;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Existencia", true));
            this.existenciaTextBox.Location = new System.Drawing.Point(101, 166);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(104, 20);
            this.existenciaTextBox.TabIndex = 57;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(101, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 59;
            // 
            // literaTextBox
            // 
            this.literaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Litera", true));
            this.literaTextBox.Location = new System.Drawing.Point(101, 140);
            this.literaTextBox.Name = "literaTextBox";
            this.literaTextBox.Size = new System.Drawing.Size(104, 20);
            this.literaTextBox.TabIndex = 61;
            // 
            // medicamentoTextBox
            // 
            this.medicamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Medicamento", true));
            this.medicamentoTextBox.Location = new System.Drawing.Point(101, 58);
            this.medicamentoTextBox.Name = "medicamentoTextBox";
            this.medicamentoTextBox.Size = new System.Drawing.Size(104, 20);
            this.medicamentoTextBox.TabIndex = 63;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(101, 114);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(104, 20);
            this.precioTextBox.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(12, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 570);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(literaLabel);
            this.Controls.Add(this.literaTextBox);
            this.Controls.Add(medicamentoLabel);
            this.Controls.Add(this.medicamentoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listaProductosDataGridView);
            this.Controls.Add(this.listaProductosBindingNavigator);
            this.Name = "FormProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).EndInit();
            this.listaProductosBindingNavigator.ResumeLayout(false);
            this.listaProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listaProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listaProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox literaTextBox;
        private System.Windows.Forms.TextBox medicamentoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripButton Cancelar;
    }
}