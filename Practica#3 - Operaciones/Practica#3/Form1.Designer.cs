namespace Practica_3
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDivision = new System.Windows.Forms.RadioButton();
            this.btnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.btnResta = new System.Windows.Forms.RadioButton();
            this.btnSuma = new System.Windows.Forms.RadioButton();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(89, 41);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(317, 20);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Ingresa los valores y selecciona una opción:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnMultiplicacion);
            this.groupBox1.Controls.Add(this.btnResta);
            this.groupBox1.Controls.Add(this.btnSuma);
            this.groupBox1.Location = new System.Drawing.Point(93, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Location = new System.Drawing.Point(16, 162);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(88, 24);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.TabStop = true;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.AutoSize = true;
            this.btnMultiplicacion.Location = new System.Drawing.Point(16, 121);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(128, 24);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.TabStop = true;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Location = new System.Drawing.Point(16, 77);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(77, 24);
            this.btnResta.TabIndex = 1;
            this.btnResta.TabStop = true;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Location = new System.Drawing.Point(16, 37);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(76, 24);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.TabStop = true;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(109, 83);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 26);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(352, 83);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 26);
            this.txtNumero2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(572, 83);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 26);
            this.txtResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(266, 89);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(18, 20);
            this.lblOperacion.TabIndex = 6;
            this.lblOperacion.Text = "+";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(548, 337);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 36);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "Form1";
            this.Text = "Práctica de estructura if";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnDivision;
        private System.Windows.Forms.RadioButton btnMultiplicacion;
        private System.Windows.Forms.RadioButton btnResta;
        private System.Windows.Forms.RadioButton btnSuma;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnCalcular;
    }
}

