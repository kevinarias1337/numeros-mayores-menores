namespace numeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numero1txt = new System.Windows.Forms.TextBox();
            this.numero2txt = new System.Windows.Forms.TextBox();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numeromayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(287, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(287, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "______________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "______________________________________________";
            // 
            // numero1txt
            // 
            this.numero1txt.Location = new System.Drawing.Point(424, 47);
            this.numero1txt.Name = "numero1txt";
            this.numero1txt.Size = new System.Drawing.Size(44, 20);
            this.numero1txt.TabIndex = 4;
            // 
            // numero2txt
            // 
            this.numero2txt.Location = new System.Drawing.Point(424, 72);
            this.numero2txt.Name = "numero2txt";
            this.numero2txt.Size = new System.Drawing.Size(44, 20);
            this.numero2txt.TabIndex = 5;
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(474, 70);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(71, 22);
            this.btncontinuar.TabIndex = 6;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.Btncontinuar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(287, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "El número mayor es:";
            // 
            // numeromayor
            // 
            this.numeromayor.AutoSize = true;
            this.numeromayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.numeromayor.Location = new System.Drawing.Point(431, 112);
            this.numeromayor.Name = "numeromayor";
            this.numeromayor.Size = new System.Drawing.Size(15, 16);
            this.numeromayor.TabIndex = 8;
            this.numeromayor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.numeromayor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.numero2txt);
            this.Controls.Add(this.numero1txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Número mayor y número menor.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numero1txt;
        private System.Windows.Forms.TextBox numero2txt;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numeromayor;
    }
}

