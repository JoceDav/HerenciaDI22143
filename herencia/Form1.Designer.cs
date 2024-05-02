
namespace herencia
{
    partial class Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.SUMAR = new System.Windows.Forms.Button();
            this.RESTAR = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1/ #A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2/#B";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(63, 162);
            this.Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(69, 16);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "Resultado";
            this.Resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // SUMAR
            // 
            this.SUMAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUMAR.Location = new System.Drawing.Point(393, 59);
            this.SUMAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SUMAR.Name = "SUMAR";
            this.SUMAR.Size = new System.Drawing.Size(100, 36);
            this.SUMAR.TabIndex = 3;
            this.SUMAR.Text = "Sumar";
            this.SUMAR.UseVisualStyleBackColor = true;
            this.SUMAR.Click += new System.EventHandler(this.SUMAR_Click);
            // 
            // RESTAR
            // 
            this.RESTAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESTAR.Location = new System.Drawing.Point(393, 102);
            this.RESTAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RESTAR.Name = "RESTAR";
            this.RESTAR.Size = new System.Drawing.Size(100, 28);
            this.RESTAR.TabIndex = 4;
            this.RESTAR.Text = "Restar";
            this.RESTAR.UseVisualStyleBackColor = true;
            this.RESTAR.Click += new System.EventHandler(this.RESTAR_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(393, 138);
            this.Multiplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(132, 28);
            this.Multiplicar.TabIndex = 5;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Dividir
            // 
            this.Dividir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(393, 174);
            this.Dividir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(100, 28);
            this.Dividir.TabIndex = 6;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPIAR.Location = new System.Drawing.Point(67, 197);
            this.LIMPIAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(100, 28);
            this.LIMPIAR.TabIndex = 7;
            this.LIMPIAR.Text = "Limpiar";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(227, 197);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(100, 28);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 156);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 11;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 279);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.RESTAR);
            this.Controls.Add(this.SUMAR);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button SUMAR;
        private System.Windows.Forms.Button RESTAR;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

