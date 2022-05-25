namespace PresentacionGuI
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTablaParametros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelPatrones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUnicapa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridPesos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLA DE CONTENIDO(E,S)";
            // 
            // dataGridTablaParametros
            // 
            this.dataGridTablaParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTablaParametros.Location = new System.Drawing.Point(12, 37);
            this.dataGridTablaParametros.Name = "dataGridTablaParametros";
            this.dataGridTablaParametros.RowHeadersWidth = 62;
            this.dataGridTablaParametros.RowTemplate.Height = 33;
            this.dataGridTablaParametros.Size = new System.Drawing.Size(776, 168);
            this.dataGridTablaParametros.TabIndex = 1;
            this.dataGridTablaParametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTablaParametros_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Entradas y Salidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(688, 604);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(112, 34);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelPatrones
            // 
            this.labelPatrones.AutoSize = true;
            this.labelPatrones.Location = new System.Drawing.Point(688, 216);
            this.labelPatrones.Margin = new System.Windows.Forms.Padding(6);
            this.labelPatrones.Name = "labelPatrones";
            this.labelPatrones.Size = new System.Drawing.Size(86, 25);
            this.labelPatrones.TabIndex = 5;
            this.labelPatrones.Text = "presionar";
            this.labelPatrones.Click += new System.EventHandler(this.labelPatrones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patrones:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonUnicapa
            // 
            this.buttonUnicapa.Location = new System.Drawing.Point(178, 266);
            this.buttonUnicapa.Name = "buttonUnicapa";
            this.buttonUnicapa.Size = new System.Drawing.Size(112, 34);
            this.buttonUnicapa.TabIndex = 7;
            this.buttonUnicapa.Text = "Unicapa";
            this.buttonUnicapa.UseVisualStyleBackColor = true;
            this.buttonUnicapa.Click += new System.EventHandler(this.buttonUnicapa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Multicapa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Por favor, seleccione:";
            // 
            // dataGridPesos
            // 
            this.dataGridPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPesos.Location = new System.Drawing.Point(12, 350);
            this.dataGridPesos.Name = "dataGridPesos";
            this.dataGridPesos.RowHeadersWidth = 62;
            this.dataGridPesos.RowTemplate.Height = 33;
            this.dataGridPesos.Size = new System.Drawing.Size(247, 288);
            this.dataGridPesos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Umbrales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(143, 148);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonUnicapa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPatrones);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridTablaParametros);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridTablaParametros;
        private Button button1;
        private Button buttonSalir;
        private Label labelPatrones;
        private Label label3;
        private Button buttonUnicapa;
        private Button button3;
        private Label label4;
        private DataGridView dataGridPesos;
        private Label label2;
        private Label label5;
        private DataGridView dataGridView1;
    }
}