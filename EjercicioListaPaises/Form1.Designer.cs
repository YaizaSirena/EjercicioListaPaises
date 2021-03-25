
namespace EjercicioListaPaises
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.butDerecha = new System.Windows.Forms.Button();
            this.butIzquierda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Suecia",
            "Dinamarca",
            "Suiza",
            "Holanda",
            "Moldavia",
            "Rumania"});
            this.checkedListBox1.Location = new System.Drawing.Point(58, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(239, 293);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "España",
            "Portugal",
            "Francia",
            "Andorra",
            "Italia",
            "Alemania"});
            this.checkedListBox2.Location = new System.Drawing.Point(494, 77);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(221, 293);
            this.checkedListBox2.TabIndex = 1;
            // 
            // butDerecha
            // 
            this.butDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butDerecha.Location = new System.Drawing.Point(336, 136);
            this.butDerecha.Name = "butDerecha";
            this.butDerecha.Size = new System.Drawing.Size(125, 30);
            this.butDerecha.TabIndex = 2;
            this.butDerecha.Text = "-->";
            this.butDerecha.UseVisualStyleBackColor = false;
            this.butDerecha.Click += new System.EventHandler(this.button1_Click);
            // 
            // butIzquierda
            // 
            this.butIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butIzquierda.Location = new System.Drawing.Point(338, 210);
            this.butIzquierda.Name = "butIzquierda";
            this.butIzquierda.Size = new System.Drawing.Size(125, 30);
            this.butIzquierda.TabIndex = 3;
            this.butIzquierda.Text = "<--";
            this.butIzquierda.UseVisualStyleBackColor = false;
            this.butIzquierda.Click += new System.EventHandler(this.butIzquierda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butIzquierda);
            this.Controls.Add(this.butDerecha);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button butDerecha;
        private System.Windows.Forms.Button butIzquierda;
    }
}

