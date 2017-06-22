namespace WindowsFormsApp2
{
    partial class Ahorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahorcado));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tbAhorcado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDigite = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIntentos = new System.Windows.Forms.TextBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.tbJugador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgBest = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(275, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(943, 129);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ahorcado UCR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBest.Location = new System.Drawing.Point(1203, 145);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(167, 24);
            this.lblBest.TabIndex = 3;
            this.lblBest.Text = "Mejores jugadores";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1376, 136);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Obtener ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(498, 624);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 82);
            this.btnStart.TabIndex = 5;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.Enabled = false;
            this.btnFinish.ForeColor = System.Drawing.Color.Transparent;
            this.btnFinish.Location = new System.Drawing.Point(730, 624);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(169, 82);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tbAhorcado
            // 
            this.tbAhorcado.Enabled = false;
            this.tbAhorcado.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAhorcado.Location = new System.Drawing.Point(498, 420);
            this.tbAhorcado.Name = "tbAhorcado";
            this.tbAhorcado.Size = new System.Drawing.Size(401, 53);
            this.tbAhorcado.TabIndex = 7;
            this.tbAhorcado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite una letra:";
            // 
            // tbDigite
            // 
            this.tbDigite.Enabled = false;
            this.tbDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDigite.Location = new System.Drawing.Point(639, 333);
            this.tbDigite.MaxLength = 1;
            this.tbDigite.Name = "tbDigite";
            this.tbDigite.Size = new System.Drawing.Size(51, 29);
            this.tbDigite.TabIndex = 9;
            this.tbDigite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(717, 333);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 29);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Intentos restantes:";
            // 
            // tbIntentos
            // 
            this.tbIntentos.Enabled = false;
            this.tbIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntentos.Location = new System.Drawing.Point(315, 221);
            this.tbIntentos.MaxLength = 100;
            this.tbIntentos.Name = "tbIntentos";
            this.tbIntentos.Size = new System.Drawing.Size(51, 29);
            this.tbIntentos.TabIndex = 13;
            this.tbIntentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.Location = new System.Drawing.Point(533, 486);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(176, 117);
            this.lblGanador.TabIndex = 14;
            this.lblGanador.Text = "      ";
            // 
            // tbJugador
            // 
            this.tbJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJugador.Location = new System.Drawing.Point(639, 221);
            this.tbJugador.MaxLength = 100;
            this.tbJugador.Name = "tbJugador";
            this.tbJugador.Size = new System.Drawing.Size(190, 29);
            this.tbJugador.TabIndex = 16;
            this.tbJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del jugador:";
            // 
            // dgBest
            // 
            this.dgBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBest.Location = new System.Drawing.Point(1207, 182);
            this.dgBest.Name = "dgBest";
            this.dgBest.Size = new System.Drawing.Size(347, 577);
            this.dgBest.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 759);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(805, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Todas las palabras están relacionadas con informática.";
            // 
            // Ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1598, 805);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbJugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.tbIntentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbDigite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAhorcado);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.dgBest);
            this.Controls.Add(this.lblTitle);
            this.Name = "Ahorcado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gato ws Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgBest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox tbAhorcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDigite;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIntentos;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.TextBox tbJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgBest;
        private System.Windows.Forms.Label label4;
    }
}

