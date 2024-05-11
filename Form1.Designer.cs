using System.Windows.Forms;

namespace Analizador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoBtn = new FontAwesome.Sharp.IconMenuItem();
            this.btnAnalizar = new FontAwesome.Sharp.IconMenuItem();
            this.dataViewCodigo = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataViewErrores = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoBtn,
            this.btnAnalizar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 65);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoBtn
            // 
            this.archivoBtn.AutoSize = false;
            this.archivoBtn.IconChar = FontAwesome.Sharp.IconChar.FileZipper;
            this.archivoBtn.IconColor = System.Drawing.Color.Black;
            this.archivoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.archivoBtn.IconSize = 25;
            this.archivoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.archivoBtn.Name = "archivoBtn";
            this.archivoBtn.Size = new System.Drawing.Size(100, 60);
            this.archivoBtn.Text = "Cargar archivo";
            this.archivoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.archivoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.archivoBtn.Click += new System.EventHandler(this.ArchivoBtn_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.AutoSize = false;
            this.btnAnalizar.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnAnalizar.IconColor = System.Drawing.Color.Black;
            this.btnAnalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalizar.IconSize = 25;
            this.btnAnalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(100, 60);
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataViewCodigo
            // 
            this.dataViewCodigo.AllowUserToAddRows = false;
            this.dataViewCodigo.AllowUserToDeleteRows = false;
            this.dataViewCodigo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataViewCodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCodigo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.codigo});
            this.dataViewCodigo.Location = new System.Drawing.Point(0, 68);
            this.dataViewCodigo.Name = "dataViewCodigo";
            this.dataViewCodigo.Size = new System.Drawing.Size(674, 355);
            this.dataViewCodigo.TabIndex = 2;
            // 
            // n
            // 
            this.n.HeaderText = "n";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 30;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 600;
            // 
            // dataViewErrores
            // 
            this.dataViewErrores.AllowUserToAddRows = false;
            this.dataViewErrores.AllowUserToDeleteRows = false;
            this.dataViewErrores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataViewErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.error,
            this.linea});
            this.dataViewErrores.Location = new System.Drawing.Point(0, 429);
            this.dataViewErrores.Name = "dataViewErrores";
            this.dataViewErrores.Size = new System.Drawing.Size(674, 104);
            this.dataViewErrores.TabIndex = 3;
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.Width = 30;
            // 
            // error
            // 
            this.error.HeaderText = "error";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Width = 500;
            // 
            // linea
            // 
            this.linea.HeaderText = "linea";
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 339);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(680, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 70);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 535);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataViewErrores);
            this.Controls.Add(this.dataViewCodigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Analizador Léxico | Alonso Sánchez Eduardo | Vitales Herrera Hatziry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem archivoBtn;
        private FontAwesome.Sharp.IconMenuItem btnAnalizar;
        private System.Windows.Forms.DataGridView dataViewCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridView dataViewErrores;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn error;
        private DataGridViewTextBoxColumn linea;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}

