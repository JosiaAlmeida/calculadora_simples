
namespace calculadora
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
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Soma = new System.Windows.Forms.RadioButton();
            this.rb_Sub = new System.Windows.Forms.RadioButton();
            this.rb_Div = new System.Windows.Forms.RadioButton();
            this.rb_Mult = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(134, 12);
            this.txt_Valor1.Multiline = true;
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(176, 29);
            this.txt_Valor1.TabIndex = 0;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(134, 53);
            this.txt_Valor2.Multiline = true;
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(176, 29);
            this.txt_Valor2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            // 
            // rb_Soma
            // 
            this.rb_Soma.AutoSize = true;
            this.rb_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Soma.Location = new System.Drawing.Point(225, 114);
            this.rb_Soma.Name = "rb_Soma";
            this.rb_Soma.Size = new System.Drawing.Size(69, 24);
            this.rb_Soma.TabIndex = 4;
            this.rb_Soma.TabStop = true;
            this.rb_Soma.Text = "Soma";
            this.rb_Soma.UseVisualStyleBackColor = true;
            this.rb_Soma.CheckedChanged += new System.EventHandler(this.rb_Soma_CheckedChanged);
            // 
            // rb_Sub
            // 
            this.rb_Sub.AutoSize = true;
            this.rb_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Sub.Location = new System.Drawing.Point(225, 155);
            this.rb_Sub.Name = "rb_Sub";
            this.rb_Sub.Size = new System.Drawing.Size(56, 24);
            this.rb_Sub.TabIndex = 5;
            this.rb_Sub.TabStop = true;
            this.rb_Sub.Text = "Sub";
            this.rb_Sub.UseVisualStyleBackColor = true;
            this.rb_Sub.CheckedChanged += new System.EventHandler(this.rb_Sub_CheckedChanged);
            // 
            // rb_Div
            // 
            this.rb_Div.AutoSize = true;
            this.rb_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Div.Location = new System.Drawing.Point(225, 198);
            this.rb_Div.Name = "rb_Div";
            this.rb_Div.Size = new System.Drawing.Size(49, 24);
            this.rb_Div.TabIndex = 6;
            this.rb_Div.TabStop = true;
            this.rb_Div.Text = "Div";
            this.rb_Div.UseVisualStyleBackColor = true;
            this.rb_Div.CheckedChanged += new System.EventHandler(this.rb_Div_CheckedChanged);
            // 
            // rb_Mult
            // 
            this.rb_Mult.AutoSize = true;
            this.rb_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mult.Location = new System.Drawing.Point(225, 237);
            this.rb_Mult.Name = "rb_Mult";
            this.rb_Mult.Size = new System.Drawing.Size(57, 24);
            this.rb_Mult.TabIndex = 7;
            this.rb_Mult.TabStop = true;
            this.rb_Mult.Text = "Mult";
            this.rb_Mult.UseVisualStyleBackColor = true;
            this.rb_Mult.CheckedChanged += new System.EventHandler(this.rb_Mult_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(8, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 42);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 148);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(189, 31);
            this.txtResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 289);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rb_Mult);
            this.Controls.Add(this.rb_Div);
            this.Controls.Add(this.rb_Sub);
            this.Controls.Add(this.rb_Soma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Soma;
        private System.Windows.Forms.RadioButton rb_Sub;
        private System.Windows.Forms.RadioButton rb_Div;
        private System.Windows.Forms.RadioButton rb_Mult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

