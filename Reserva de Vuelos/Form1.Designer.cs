namespace Reserva_de_Vuelos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aerolineaLabel;
            System.Windows.Forms.Label claseLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaVueloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaVueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaVueloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aerolineaTextBox = new System.Windows.Forms.TextBox();
            this.claseTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.busquedaVueloBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaVueloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaVueloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aerolineaLabel = new System.Windows.Forms.Label();
            claseLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingNavigator)).BeginInit();
            this.listaVueloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaVueloBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aerolineaLabel
            // 
            aerolineaLabel.AutoSize = true;
            aerolineaLabel.Location = new System.Drawing.Point(307, 76);
            aerolineaLabel.Name = "aerolineaLabel";
            aerolineaLabel.Size = new System.Drawing.Size(54, 13);
            aerolineaLabel.TabIndex = 1;
            aerolineaLabel.Text = "Aerolinea:";
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new System.Drawing.Point(307, 103);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new System.Drawing.Size(36, 13);
            claseLabel.TabIndex = 5;
            claseLabel.Text = "Clase:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(307, 129);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // listaVueloBindingNavigator
            // 
            this.listaVueloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaVueloBindingNavigator.BindingSource = this.listaVueloBindingSource;
            this.listaVueloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaVueloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaVueloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaVueloBindingNavigatorSaveItem});
            this.listaVueloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaVueloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaVueloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaVueloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaVueloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaVueloBindingNavigator.Name = "listaVueloBindingNavigator";
            this.listaVueloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaVueloBindingNavigator.Size = new System.Drawing.Size(581, 25);
            this.listaVueloBindingNavigator.TabIndex = 0;
            this.listaVueloBindingNavigator.Text = "bindingNavigator1";
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
            // listaVueloBindingSource
            // 
            this.listaVueloBindingSource.AllowNew = true;
            this.listaVueloBindingSource.DataSource = typeof(Reserva_de_Vuelos.Modelos.BusquedaVuelo);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // listaVueloBindingNavigatorSaveItem
            // 
            this.listaVueloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaVueloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaVueloBindingNavigatorSaveItem.Image")));
            this.listaVueloBindingNavigatorSaveItem.Name = "listaVueloBindingNavigatorSaveItem";
            this.listaVueloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaVueloBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaVueloBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaVueloBindingNavigatorSaveItem_Click);
            // 
            // aerolineaTextBox
            // 
            this.aerolineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "Aerolinea", true));
            this.aerolineaTextBox.Location = new System.Drawing.Point(380, 73);
            this.aerolineaTextBox.Name = "aerolineaTextBox";
            this.aerolineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.aerolineaTextBox.TabIndex = 2;
            // 
            // claseTextBox
            // 
            this.claseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "Clase", true));
            this.claseTextBox.Location = new System.Drawing.Point(380, 100);
            this.claseTextBox.Name = "claseTextBox";
            this.claseTextBox.Size = new System.Drawing.Size(100, 20);
            this.claseTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(380, 129);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaVueloBindingSource, "CategoriaId", true));
            this.comboBox1.DataSource = this.listaCategoriaBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            // 
            // listaCategoriaBindingSource
            // 
            this.listaCategoriaBindingSource.DataSource = typeof(Reserva_de_Vuelos.Modelos.Categoria);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Aerolinea FLIGHT";
            // 
            // busquedaVueloBLBindingSource
            // 
            this.busquedaVueloBLBindingSource.DataSource = typeof(Reserva_de_Vuelos.BL.BusquedaVueloBL);
            // 
            // listaVueloBindingSource1
            // 
            this.listaVueloBindingSource1.DataMember = "ListaVuelo";
            this.listaVueloBindingSource1.DataSource = this.busquedaVueloBLBindingSource;
            // 
            // listaVueloDataGridView
            // 
            this.listaVueloDataGridView.AutoGenerateColumns = false;
            this.listaVueloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaVueloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.listaVueloDataGridView.DataSource = this.listaVueloBindingSource1;
            this.listaVueloDataGridView.Location = new System.Drawing.Point(112, 172);
            this.listaVueloDataGridView.Name = "listaVueloDataGridView";
            this.listaVueloDataGridView.Size = new System.Drawing.Size(339, 220);
            this.listaVueloDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Aerolinea";
            this.dataGridViewTextBoxColumn1.HeaderText = "Aerolinea";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Clase";
            this.dataGridViewTextBoxColumn5.HeaderText = "Clase";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 476);
            this.Controls.Add(this.listaVueloDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(aerolineaLabel);
            this.Controls.Add(this.aerolineaTextBox);
            this.Controls.Add(claseLabel);
            this.Controls.Add(this.claseTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaVueloBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingNavigator)).EndInit();
            this.listaVueloBindingNavigator.ResumeLayout(false);
            this.listaVueloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaVueloBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaVueloBindingSource;
        private System.Windows.Forms.BindingNavigator listaVueloBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaVueloBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox aerolineaTextBox;
        private System.Windows.Forms.TextBox claseTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource listaCategoriaBindingSource;
        private System.Windows.Forms.BindingSource busquedaVueloBLBindingSource;
        private System.Windows.Forms.BindingSource listaVueloBindingSource1;
        private System.Windows.Forms.DataGridView listaVueloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

