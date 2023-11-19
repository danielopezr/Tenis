namespace Tenis
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.raqueta1 = new System.Windows.Forms.Button();
            this.raqueta2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblPuntos1 = new System.Windows.Forms.Label();
            this.lblPuntos2 = new System.Windows.Forms.Label();
            this.pelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // raqueta1
            // 
            this.raqueta1.Location = new System.Drawing.Point(53, 142);
            this.raqueta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raqueta1.Name = "raqueta1";
            this.raqueta1.Size = new System.Drawing.Size(13, 87);
            this.raqueta1.TabIndex = 0;
            this.raqueta1.TabStop = false;
            this.raqueta1.UseVisualStyleBackColor = true;
            // 
            // raqueta2
            // 
            this.raqueta2.Location = new System.Drawing.Point(596, 142);
            this.raqueta2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raqueta2.Name = "raqueta2";
            this.raqueta2.Size = new System.Drawing.Size(13, 87);
            this.raqueta2.TabIndex = 1;
            this.raqueta2.TabStop = false;
            this.raqueta2.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblJugador1
            // 
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblJugador1.Location = new System.Drawing.Point(198, 296);
            this.lblJugador1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(52, 15);
            this.lblJugador1.TabIndex = 3;
            this.lblJugador1.Text = "DDDDD";
            this.lblJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJugador2
            // 
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblJugador2.Location = new System.Drawing.Point(416, 297);
            this.lblJugador2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(52, 15);
            this.lblJugador2.TabIndex = 4;
            this.lblJugador2.Text = "DDDDD";
            this.lblJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuntos1
            // 
            this.lblPuntos1.AutoSize = true;
            this.lblPuntos1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblPuntos1.Location = new System.Drawing.Point(208, 311);
            this.lblPuntos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos1.Name = "lblPuntos1";
            this.lblPuntos1.Size = new System.Drawing.Size(25, 27);
            this.lblPuntos1.TabIndex = 5;
            this.lblPuntos1.Text = "0";
            this.lblPuntos1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPuntos2
            // 
            this.lblPuntos2.AutoSize = true;
            this.lblPuntos2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblPuntos2.Location = new System.Drawing.Point(425, 311);
            this.lblPuntos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos2.Name = "lblPuntos2";
            this.lblPuntos2.Size = new System.Drawing.Size(25, 27);
            this.lblPuntos2.TabIndex = 6;
            this.lblPuntos2.Text = "0";
            this.lblPuntos2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.SystemColors.WindowText;
            this.pelota.Image = global::Tenis.Properties.Resources.pelota;
            this.pelota.Location = new System.Drawing.Point(315, 162);
            this.pelota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(27, 27);
            this.pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pelota.TabIndex = 2;
            this.pelota.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(652, 358);
            this.Controls.Add(this.lblPuntos2);
            this.Controls.Add(this.lblPuntos1);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.raqueta2);
            this.Controls.Add(this.raqueta1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raqueta1;
        private System.Windows.Forms.Button raqueta2;
        private System.Windows.Forms.PictureBox pelota;
        private System.Windows.Forms.Label puntaje1;
        private System.Windows.Forms.Label puntaje2;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblPuntos1;
        private System.Windows.Forms.Label lblPuntos2;
        public System.Windows.Forms.Timer timer;
    }
}