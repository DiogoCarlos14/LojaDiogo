namespace LojaDiogo
{
    partial class Form6
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
            this.tools = new System.Windows.Forms.ToolStrip();
            this.tsAdicionar = new System.Windows.Forms.ToolStripButton();
            this.tsAnular = new System.Windows.Forms.ToolStripButton();
            this.tsValidar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsGuardarSair = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.grelha = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGarantia = new System.Windows.Forms.CheckBox();
            this.cbAvaria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tools.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdicionar,
            this.tsAnular,
            this.tsValidar,
            this.tsEliminar,
            this.tsGuardarSair});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1434, 37);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            this.tools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsAdicionar
            // 
            this.tsAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAdicionar.Image = global::LojaDiogo.Properties.Resources._303221911558424386_48;
            this.tsAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdicionar.Name = "tsAdicionar";
            this.tsAdicionar.Size = new System.Drawing.Size(34, 34);
            this.tsAdicionar.Text = "Adicionar";
            this.tsAdicionar.Click += new System.EventHandler(this.tsAdicionar_Click);
            // 
            // tsAnular
            // 
            this.tsAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAnular.Image = global::LojaDiogo.Properties.Resources._109625862716276583143772_128;
            this.tsAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAnular.Name = "tsAnular";
            this.tsAnular.Size = new System.Drawing.Size(34, 34);
            this.tsAnular.Text = "Anular";
            this.tsAnular.Click += new System.EventHandler(this.tsAnular_Click);
            // 
            // tsValidar
            // 
            this.tsValidar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsValidar.Image = global::LojaDiogo.Properties.Resources.Yes_icon;
            this.tsValidar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsValidar.Name = "tsValidar";
            this.tsValidar.Size = new System.Drawing.Size(34, 34);
            this.tsValidar.Text = "Validar";
            this.tsValidar.Click += new System.EventHandler(this.tsValidar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = global::LojaDiogo.Properties.Resources.close_111152;
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(34, 34);
            this.tsEliminar.Text = "Eliminar";
            // 
            // tsGuardarSair
            // 
            this.tsGuardarSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuardarSair.Image = global::LojaDiogo.Properties.Resources._18769148821543238916_48;
            this.tsGuardarSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardarSair.Name = "tsGuardarSair";
            this.tsGuardarSair.Size = new System.Drawing.Size(34, 34);
            this.tsGuardarSair.Text = "Guardar e Sair";
            this.tsGuardarSair.Click += new System.EventHandler(this.tsGuardarSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(189, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 38);
            this.txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Location = new System.Drawing.Point(874, 58);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(345, 38);
            this.dtData.TabIndex = 4;
            // 
            // grelha
            // 
            this.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha.Location = new System.Drawing.Point(6, 280);
            this.grelha.Name = "grelha";
            this.grelha.Size = new System.Drawing.Size(1314, 211);
            this.grelha.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGarantia);
            this.groupBox1.Controls.Add(this.cbAvaria);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grelha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 497);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkGarantia
            // 
            this.chkGarantia.AutoSize = true;
            this.chkGarantia.Location = new System.Drawing.Point(1025, 223);
            this.chkGarantia.Name = "chkGarantia";
            this.chkGarantia.Size = new System.Drawing.Size(137, 35);
            this.chkGarantia.TabIndex = 16;
            this.chkGarantia.Text = "Garantia";
            this.chkGarantia.UseVisualStyleBackColor = true;
            // 
            // cbAvaria
            // 
            this.cbAvaria.FormattingEnabled = true;
            this.cbAvaria.Location = new System.Drawing.Point(282, 221);
            this.cbAvaria.Name = "cbAvaria";
            this.cbAvaria.Size = new System.Drawing.Size(366, 39);
            this.cbAvaria.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descrição da avaria:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(619, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(626, 38);
            this.txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(189, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(275, 38);
            this.txtTelefone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(1072, 38);
            this.txtNome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMsg});
            this.status.Location = new System.Drawing.Point(0, 639);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1434, 22);
            this.status.TabIndex = 7;
            this.status.Text = "statusStrip1";
            // 
            // statusMsg
            // 
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(66, 17);
            this.statusMsg.Text = "Mensagem";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 661);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton tsAdicionar;
        private System.Windows.Forms.ToolStripButton tsAnular;
        private System.Windows.Forms.ToolStripButton tsValidar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.ToolStripButton tsGuardarSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DataGridView grelha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGarantia;
        private System.Windows.Forms.ComboBox cbAvaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusMsg;
    }
}