namespace PokeBaseOO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPokemons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPokemon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPokemon = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPokemons
            // 
            this.btnListarPokemons.Location = new System.Drawing.Point(15, 66);
            this.btnListarPokemons.Name = "btnListarPokemons";
            this.btnListarPokemons.Size = new System.Drawing.Size(122, 29);
            this.btnListarPokemons.TabIndex = 0;
            this.btnListarPokemons.Text = "ListarPokemons";
            this.btnListarPokemons.UseVisualStyleBackColor = true;
            this.btnListarPokemons.Click += new System.EventHandler(this.btnListarPokemons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnBuscarPokemon
            // 
            this.btnBuscarPokemon.Location = new System.Drawing.Point(15, 101);
            this.btnBuscarPokemon.Name = "btnBuscarPokemon";
            this.btnBuscarPokemon.Size = new System.Drawing.Size(122, 29);
            this.btnBuscarPokemon.TabIndex = 2;
            this.btnBuscarPokemon.Text = "BuscarPokemon";
            this.btnBuscarPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPokemon.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "ListarCategorias";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "BuscarCategoria";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "ListarTipos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "BuscarTipoPokemon";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "ListarHabilidades";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num Pokemon";
            // 
            // txtNumPokemon
            // 
            this.txtNumPokemon.Location = new System.Drawing.Point(95, 28);
            this.txtNumPokemon.Name = "txtNumPokemon";
            this.txtNumPokemon.Size = new System.Drawing.Size(33, 20);
            this.txtNumPokemon.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 311);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 29);
            this.button8.TabIndex = 10;
            this.button8.Text = "BuscarHabilidades";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 346);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 29);
            this.button9.TabIndex = 11;
            this.button9.Text = "BuscarFraquezas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 623);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtNumPokemon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBuscarPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarPokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPokemons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPokemon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPokemon;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

