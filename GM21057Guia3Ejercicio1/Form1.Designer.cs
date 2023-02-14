namespace GM21057Guia3Ejercicio1
{
    partial class Form1
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
            this.clean = new System.Windows.Forms.Button();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.textIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(151, 179);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 13;
            this.clean.Text = "Vaciar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(288, 56);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(75, 23);
            this.botonIngresar.TabIndex = 12;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // textSalida
            // 
            this.textSalida.Location = new System.Drawing.Point(151, 132);
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(172, 23);
            this.textSalida.TabIndex = 11;
            // 
            // textIngreso
            // 
            this.textIngreso.Location = new System.Drawing.Point(151, 55);
            this.textIngreso.Name = "textIngreso";
            this.textIngreso.Size = new System.Drawing.Size(120, 23);
            this.textIngreso.TabIndex = 10;
            this.textIngreso.TextChanged += new System.EventHandler(this.textIngreso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Respuesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese el numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "COMPROBAR SI UN NUMERO ES PAR O IMPAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 220);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.textIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "COMPROBACION DE NUMEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clean;
        private Button botonIngresar;
        private TextBox textSalida;
        private TextBox textIngreso;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}