namespace main.Pantallas
{
    partial class Cambios_empleado
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtIDdepartamento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDempleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDepart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(190, 326);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 19;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtIDdepartamento
            // 
            this.txtIDdepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIDdepartamento.Location = new System.Drawing.Point(190, 262);
            this.txtIDdepartamento.Name = "txtIDdepartamento";
            this.txtIDdepartamento.Size = new System.Drawing.Size(100, 23);
            this.txtIDdepartamento.TabIndex = 18;
            this.txtIDdepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDdepartamento_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(190, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 23);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtIDempleado
            // 
            this.txtIDempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIDempleado.Location = new System.Drawing.Point(190, 72);
            this.txtIDempleado.MaxLength = 5;
            this.txtIDempleado.Name = "txtIDempleado";
            this.txtIDempleado.Size = new System.Drawing.Size(103, 26);
            this.txtIDempleado.TabIndex = 16;
            this.txtIDempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDempleado_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(91, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(85, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(91, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(84, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID empleado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(349, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCambiar.Location = new System.Drawing.Point(107, 392);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(123, 28);
            this.btnCambiar.TabIndex = 10;
            this.btnCambiar.Text = "Cambiar datos";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingrese ID empleado";
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnID.Location = new System.Drawing.Point(299, 73);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(35, 25);
            this.btnID.TabIndex = 21;
            this.btnID.Text = "...";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(131, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Datos a Cambiar";
            // 
            // btnDepart
            // 
            this.btnDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDepart.Location = new System.Drawing.Point(300, 261);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(31, 25);
            this.btnDepart.TabIndex = 23;
            this.btnDepart.Text = "...";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "\"pulsa ENTER para traer datos del empleado\"";
            // 
            // Cambios_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 487);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtIDdepartamento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDempleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Name = "Cambios_empleado";
            this.Text = "Cambios_empleado";
            this.Load += new System.EventHandler(this.Cambios_empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDepart;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtIDdepartamento;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIDempleado;
    }
}