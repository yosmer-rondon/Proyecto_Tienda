namespace Proyecto_Tienda__Diars_
{
    partial class Empleado
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
            this.Pago = new System.Windows.Forms.TabControl();
            this.Venta = new System.Windows.Forms.TabPage();
            this.txtvuelto1 = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.Label();
            this.txtmontorecibido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotalventa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numcantidadproducto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dbvdetalleventa = new System.Windows.Forms.DataGridView();
            this.txtsubtotaldetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecioproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmostrarproductos = new System.Windows.Forms.Button();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdniempleado = new System.Windows.Forms.TextBox();
            this.txtdnicliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pedido = new System.Windows.Forms.TabPage();
            this.Pago_ = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.Pago.SuspendLayout();
            this.Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcantidadproducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbvdetalleventa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pago
            // 
            this.Pago.Controls.Add(this.Venta);
            this.Pago.Controls.Add(this.Pedido);
            this.Pago.Controls.Add(this.Pago_);
            this.Pago.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pago.Location = new System.Drawing.Point(0, 1);
            this.Pago.Name = "Pago";
            this.Pago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pago.SelectedIndex = 0;
            this.Pago.Size = new System.Drawing.Size(1385, 856);
            this.Pago.TabIndex = 0;
            // 
            // Venta
            // 
            this.Venta.Controls.Add(this.button5);
            this.Venta.Controls.Add(this.txtvuelto1);
            this.Venta.Controls.Add(this.txt_a);
            this.Venta.Controls.Add(this.txtmontorecibido);
            this.Venta.Controls.Add(this.label9);
            this.Venta.Controls.Add(this.txttotalventa);
            this.Venta.Controls.Add(this.label10);
            this.Venta.Controls.Add(this.numcantidadproducto);
            this.Venta.Controls.Add(this.label8);
            this.Venta.Controls.Add(this.button7);
            this.Venta.Controls.Add(this.btnAgregarproducto);
            this.Venta.Controls.Add(this.groupBox3);
            this.Venta.Controls.Add(this.txtsubtotaldetalle);
            this.Venta.Controls.Add(this.label7);
            this.Venta.Controls.Add(this.txtprecioproducto);
            this.Venta.Controls.Add(this.label6);
            this.Venta.Controls.Add(this.label5);
            this.Venta.Controls.Add(this.txtidproducto);
            this.Venta.Controls.Add(this.label4);
            this.Venta.Controls.Add(this.txtventa);
            this.Venta.Controls.Add(this.label3);
            this.Venta.Controls.Add(this.groupBox2);
            this.Venta.Controls.Add(this.button2);
            this.Venta.Controls.Add(this.button1);
            this.Venta.Controls.Add(this.label1);
            this.Venta.Controls.Add(this.txtdniempleado);
            this.Venta.Controls.Add(this.txtdnicliente);
            this.Venta.Controls.Add(this.label2);
            this.Venta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Venta.Location = new System.Drawing.Point(4, 36);
            this.Venta.Name = "Venta";
            this.Venta.Padding = new System.Windows.Forms.Padding(3);
            this.Venta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Venta.Size = new System.Drawing.Size(1377, 816);
            this.Venta.TabIndex = 3;
            this.Venta.Text = "  🛒Venta  ";
            this.Venta.UseVisualStyleBackColor = true;
            // 
            // txtvuelto1
            // 
            this.txtvuelto1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvuelto1.Location = new System.Drawing.Point(189, 612);
            this.txtvuelto1.Name = "txtvuelto1";
            this.txtvuelto1.Size = new System.Drawing.Size(132, 29);
            this.txtvuelto1.TabIndex = 49;
            // 
            // txt_a
            // 
            this.txt_a.AutoSize = true;
            this.txt_a.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(24, 619);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(63, 22);
            this.txt_a.TabIndex = 48;
            this.txt_a.Text = "Vuelto";
            // 
            // txtmontorecibido
            // 
            this.txtmontorecibido.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontorecibido.Location = new System.Drawing.Point(189, 561);
            this.txtmontorecibido.Name = "txtmontorecibido";
            this.txtmontorecibido.Size = new System.Drawing.Size(132, 29);
            this.txtmontorecibido.TabIndex = 47;
            this.txtmontorecibido.TextChanged += new System.EventHandler(this.txtmontorecibido_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Monto Recibido";
            // 
            // txttotalventa
            // 
            this.txttotalventa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalventa.Location = new System.Drawing.Point(189, 509);
            this.txttotalventa.Name = "txttotalventa";
            this.txttotalventa.Size = new System.Drawing.Size(132, 29);
            this.txttotalventa.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 44;
            this.label10.Text = "Total";
            // 
            // numcantidadproducto
            // 
            this.numcantidadproducto.Location = new System.Drawing.Point(1257, 67);
            this.numcantidadproducto.Name = "numcantidadproducto";
            this.numcantidadproducto.Size = new System.Drawing.Size(71, 34);
            this.numcantidadproducto.TabIndex = 43;
            this.numcantidadproducto.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(223, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ingrese dni de cliente        ";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(27, 660);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 36);
            this.button7.TabIndex = 41;
            this.button7.Text = "💵 pagar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarproducto.Location = new System.Drawing.Point(907, 123);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(205, 36);
            this.btnAgregarproducto.TabIndex = 40;
            this.btnAgregarproducto.Text = "Agregar producto ";
            this.btnAgregarproducto.UseVisualStyleBackColor = true;
            this.btnAgregarproducto.Click += new System.EventHandler(this.btnAgregarproducto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dbvdetalleventa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 334);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de venta";
            // 
            // dbvdetalleventa
            // 
            this.dbvdetalleventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbvdetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvdetalleventa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbvdetalleventa.Location = new System.Drawing.Point(3, 21);
            this.dbvdetalleventa.Name = "dbvdetalleventa";
            this.dbvdetalleventa.Size = new System.Drawing.Size(640, 310);
            this.dbvdetalleventa.TabIndex = 10;
            // 
            // txtsubtotaldetalle
            // 
            this.txtsubtotaldetalle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotaldetalle.Location = new System.Drawing.Point(1096, 72);
            this.txtsubtotaldetalle.Name = "txtsubtotaldetalle";
            this.txtsubtotaldetalle.Size = new System.Drawing.Size(132, 29);
            this.txtsubtotaldetalle.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(960, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Sub total";
            // 
            // txtprecioproducto
            // 
            this.txtprecioproducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioproducto.Location = new System.Drawing.Point(1096, 28);
            this.txtprecioproducto.Name = "txtprecioproducto";
            this.txtprecioproducto.Size = new System.Drawing.Size(132, 29);
            this.txtprecioproducto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(960, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Precio unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1253, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cantidad";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproducto.Location = new System.Drawing.Point(816, 76);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(132, 29);
            this.txtidproducto.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID Producto";
            // 
            // txtventa
            // 
            this.txtventa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventa.Location = new System.Drawing.Point(816, 31);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(132, 29);
            this.txtventa.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID orden venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmostrarproductos);
            this.groupBox2.Controls.Add(this.dgvproducto);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(684, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 334);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostra producto";
            // 
            // btnmostrarproductos
            // 
            this.btnmostrarproductos.Location = new System.Drawing.Point(229, 79);
            this.btnmostrarproductos.Name = "btnmostrarproductos";
            this.btnmostrarproductos.Size = new System.Drawing.Size(109, 21);
            this.btnmostrarproductos.TabIndex = 10;
            this.btnmostrarproductos.Text = "Mostrar";
            this.btnmostrarproductos.UseVisualStyleBackColor = true;
            this.btnmostrarproductos.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(6, 114);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(638, 213);
            this.dgvproducto.TabIndex = 9;
            this.dgvproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtbuscarproducto);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar producto";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 21);
            this.button4.TabIndex = 8;
            this.button4.Text = "Buscar (nombre)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(6, 21);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(200, 22);
            this.txtbuscarproducto.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar (ID)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "Genera orden de compra ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dni cliente";
            // 
            // txtdniempleado
            // 
            this.txtdniempleado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdniempleado.Location = new System.Drawing.Point(179, 88);
            this.txtdniempleado.MaxLength = 8;
            this.txtdniempleado.Name = "txtdniempleado";
            this.txtdniempleado.Size = new System.Drawing.Size(200, 29);
            this.txtdniempleado.TabIndex = 26;
            this.txtdniempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdniempleado_KeyPress);
            // 
            // txtdnicliente
            // 
            this.txtdnicliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdnicliente.Location = new System.Drawing.Point(179, 39);
            this.txtdnicliente.MaxLength = 8;
            this.txtdnicliente.Name = "txtdnicliente";
            this.txtdnicliente.Size = new System.Drawing.Size(200, 29);
            this.txtdnicliente.TabIndex = 24;
            this.txtdnicliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dni empleado";
            // 
            // Pedido
            // 
            this.Pedido.Location = new System.Drawing.Point(4, 36);
            this.Pedido.Name = "Pedido";
            this.Pedido.Padding = new System.Windows.Forms.Padding(3);
            this.Pedido.Size = new System.Drawing.Size(1377, 816);
            this.Pedido.TabIndex = 1;
            this.Pedido.Text = "  📦Pedido   ";
            this.Pedido.UseVisualStyleBackColor = true;
            // 
            // Pago_
            // 
            this.Pago_.Location = new System.Drawing.Point(4, 36);
            this.Pago_.Name = "Pago_";
            this.Pago_.Padding = new System.Windows.Forms.Padding(3);
            this.Pago_.Size = new System.Drawing.Size(1377, 816);
            this.Pago_.TabIndex = 2;
            this.Pago_.Text = "   💰Pago   ";
            this.Pago_.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tomato;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(147, 660);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 36);
            this.button5.TabIndex = 50;
            this.button5.Text = "❌ Anular";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.Pago);
            this.Name = "Empleado";
            this.Text = " ";
            this.Pago.ResumeLayout(false);
            this.Venta.ResumeLayout(false);
            this.Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcantidadproducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbvdetalleventa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pago;
        private System.Windows.Forms.TabPage Pedido;
        private System.Windows.Forms.TabPage Pago_;
        private System.Windows.Forms.TabPage Venta;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dbvdetalleventa;
        private System.Windows.Forms.TextBox txtsubtotaldetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecioproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmostrarproductos;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdniempleado;
        private System.Windows.Forms.TextBox txtdnicliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numcantidadproducto;
        private System.Windows.Forms.TextBox txtmontorecibido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotalventa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvuelto1;
        private System.Windows.Forms.Label txt_a;
        private System.Windows.Forms.Button button5;
    }
}