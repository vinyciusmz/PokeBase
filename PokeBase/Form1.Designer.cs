namespace PokeBase
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
            this.Pokémon = new System.Windows.Forms.GroupBox();
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHabilidades = new System.Windows.Forms.Label();
            this.lblFraquezas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.Pokémon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pokémon
            // 
            this.Pokémon.Controls.Add(this.dgvPokemon);
            this.Pokémon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Pokémon.Location = new System.Drawing.Point(12, 12);
            this.Pokémon.Name = "Pokémon";
            this.Pokémon.Size = new System.Drawing.Size(898, 327);
            this.Pokémon.TabIndex = 0;
            this.Pokémon.TabStop = false;
            this.Pokémon.Text = "Pokémon";
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(6, 23);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.Size = new System.Drawing.Size(886, 298);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.Click += new System.EventHandler(this.dgvPokemon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHabilidades);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(18, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilidades";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFraquezas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(322, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fraquezas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTipo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(628, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 342);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // lblHabilidades
            // 
            this.lblHabilidades.AutoSize = true;
            this.lblHabilidades.Location = new System.Drawing.Point(20, 37);
            this.lblHabilidades.Name = "lblHabilidades";
            this.lblHabilidades.Size = new System.Drawing.Size(46, 18);
            this.lblHabilidades.TabIndex = 0;
            this.lblHabilidades.Text = "label1";
            // 
            // lblFraquezas
            // 
            this.lblFraquezas.AutoSize = true;
            this.lblFraquezas.Location = new System.Drawing.Point(16, 37);
            this.lblFraquezas.Name = "lblFraquezas";
            this.lblFraquezas.Size = new System.Drawing.Size(46, 18);
            this.lblFraquezas.TabIndex = 1;
            this.lblFraquezas.Text = "label1";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(27, 37);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 18);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 725);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pokémon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pokémon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pokémon;
        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHabilidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFraquezas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTipo;
    }
}

