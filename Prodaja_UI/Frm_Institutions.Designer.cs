namespace Prodaja_UI
{
    partial class Frm_Institutions
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
            this.dgInstitutions = new System.Windows.Forms.DataGridView();
            this.LANAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APOTEKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_APOTEKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MJESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teren1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teren2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.lblInstitucija = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtInstitucija = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.cbxTerritories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstitutions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInstitutions
            // 
            this.dgInstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstitutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LANAC,
            this.APOTEKA,
            this.ID_APOTEKE,
            this.MJESTO,
            this.Teren1,
            this.Teren2});
            this.dgInstitutions.Location = new System.Drawing.Point(13, 41);
            this.dgInstitutions.Name = "dgInstitutions";
            this.dgInstitutions.Size = new System.Drawing.Size(756, 341);
            this.dgInstitutions.TabIndex = 0;
            // 
            // LANAC
            // 
            this.LANAC.DataPropertyName = "LANAC";
            this.LANAC.HeaderText = "LANAC";
            this.LANAC.Name = "LANAC";
            // 
            // APOTEKA
            // 
            this.APOTEKA.DataPropertyName = "APOTEKA";
            this.APOTEKA.HeaderText = "APOTEKA";
            this.APOTEKA.Name = "APOTEKA";
            // 
            // ID_APOTEKE
            // 
            this.ID_APOTEKE.DataPropertyName = "ID_APOTEKE";
            this.ID_APOTEKE.HeaderText = "ID_APOTEKE";
            this.ID_APOTEKE.Name = "ID_APOTEKE";
            // 
            // MJESTO
            // 
            this.MJESTO.DataPropertyName = "MJESTO";
            this.MJESTO.HeaderText = "MJESTO";
            this.MJESTO.Name = "MJESTO";
            // 
            // Teren1
            // 
            this.Teren1.DataPropertyName = "Teren1";
            this.Teren1.HeaderText = "Teren1";
            this.Teren1.Name = "Teren1";
            // 
            // Teren2
            // 
            this.Teren2.DataPropertyName = "Teren 2";
            this.Teren2.HeaderText = "Teren 2";
            this.Teren2.Name = "Teren2";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(717, 13);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // lblInstitucija
            // 
            this.lblInstitucija.AutoSize = true;
            this.lblInstitucija.Location = new System.Drawing.Point(297, 13);
            this.lblInstitucija.Name = "lblInstitucija";
            this.lblInstitucija.Size = new System.Drawing.Size(51, 13);
            this.lblInstitucija.TabIndex = 2;
            this.lblInstitucija.Text = "Institucija";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(479, 13);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(30, 13);
            this.lblGrad.TabIndex = 3;
            this.lblGrad.Text = "Grad";
            // 
            // txtInstitucija
            // 
            this.txtInstitucija.Location = new System.Drawing.Point(364, 12);
            this.txtInstitucija.Name = "txtInstitucija";
            this.txtInstitucija.Size = new System.Drawing.Size(109, 20);
            this.txtInstitucija.TabIndex = 4;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(535, 12);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(140, 20);
            this.txtGrad.TabIndex = 5;
            // 
            // cbxTerritories
            // 
            this.cbxTerritories.FormattingEnabled = true;
            this.cbxTerritories.Location = new System.Drawing.Point(125, 11);
            this.cbxTerritories.Name = "cbxTerritories";
            this.cbxTerritories.Size = new System.Drawing.Size(130, 21);
            this.cbxTerritories.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "View institution";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of institutions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Territory";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumber.Location = new System.Drawing.Point(130, 387);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 10;
            // 
            // Frm_Institutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 412);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTerritories);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtInstitucija);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblInstitucija);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.dgInstitutions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Frm_Institutions";
            this.Text = "Institutions";
            this.Load += new System.EventHandler(this.Frm_Institutions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstitutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInstitutions;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label lblInstitucija;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtInstitucija;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.ComboBox cbxTerritories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn APOTEKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_APOTEKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MJESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teren1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teren2;
        private System.Windows.Forms.Label lblNumber;
    }
}

