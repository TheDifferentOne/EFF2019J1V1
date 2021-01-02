
namespace EFF_2019
{
    partial class Q4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDebutTxtBx = new System.Windows.Forms.TextBox();
            this.dateFinTxtBx = new System.Windows.Forms.TextBox();
            this.parPeriodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.parAssRadioBtn = new System.Windows.Forms.RadioButton();
            this.afiicherBtn = new System.Windows.Forms.Button();
            this.stagesDgv = new System.Windows.Forms.DataGridView();
            this.demandesDgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.nomAssCmbBx = new System.Windows.Forms.ComboBox();
            this.exportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stagesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Debut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste des stages :";
            // 
            // dateDebutTxtBx
            // 
            this.dateDebutTxtBx.Location = new System.Drawing.Point(227, 25);
            this.dateDebutTxtBx.Name = "dateDebutTxtBx";
            this.dateDebutTxtBx.Size = new System.Drawing.Size(135, 24);
            this.dateDebutTxtBx.TabIndex = 3;
            // 
            // dateFinTxtBx
            // 
            this.dateFinTxtBx.Location = new System.Drawing.Point(431, 25);
            this.dateFinTxtBx.Name = "dateFinTxtBx";
            this.dateFinTxtBx.Size = new System.Drawing.Size(125, 24);
            this.dateFinTxtBx.TabIndex = 4;
            // 
            // parPeriodeRadioBtn
            // 
            this.parPeriodeRadioBtn.AutoSize = true;
            this.parPeriodeRadioBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parPeriodeRadioBtn.Location = new System.Drawing.Point(12, 26);
            this.parPeriodeRadioBtn.Name = "parPeriodeRadioBtn";
            this.parPeriodeRadioBtn.Size = new System.Drawing.Size(112, 21);
            this.parPeriodeRadioBtn.TabIndex = 5;
            this.parPeriodeRadioBtn.TabStop = true;
            this.parPeriodeRadioBtn.Text = "Par periode ";
            this.parPeriodeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // parAssRadioBtn
            // 
            this.parAssRadioBtn.AutoSize = true;
            this.parAssRadioBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parAssRadioBtn.Location = new System.Drawing.Point(573, 28);
            this.parAssRadioBtn.Name = "parAssRadioBtn";
            this.parAssRadioBtn.Size = new System.Drawing.Size(134, 21);
            this.parAssRadioBtn.TabIndex = 6;
            this.parAssRadioBtn.TabStop = true;
            this.parAssRadioBtn.Text = "Par Association";
            this.parAssRadioBtn.UseVisualStyleBackColor = true;
            // 
            // afiicherBtn
            // 
            this.afiicherBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afiicherBtn.Location = new System.Drawing.Point(927, 21);
            this.afiicherBtn.Name = "afiicherBtn";
            this.afiicherBtn.Size = new System.Drawing.Size(130, 30);
            this.afiicherBtn.TabIndex = 7;
            this.afiicherBtn.Text = "Afficher";
            this.afiicherBtn.UseVisualStyleBackColor = true;
            this.afiicherBtn.Click += new System.EventHandler(this.afiicherBtn_Click);
            // 
            // stagesDgv
            // 
            this.stagesDgv.AllowUserToAddRows = false;
            this.stagesDgv.AllowUserToDeleteRows = false;
            this.stagesDgv.AllowUserToResizeColumns = false;
            this.stagesDgv.AllowUserToResizeRows = false;
            this.stagesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stagesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagesDgv.Location = new System.Drawing.Point(12, 96);
            this.stagesDgv.MultiSelect = false;
            this.stagesDgv.Name = "stagesDgv";
            this.stagesDgv.ReadOnly = true;
            this.stagesDgv.RowHeadersWidth = 51;
            this.stagesDgv.RowTemplate.Height = 26;
            this.stagesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stagesDgv.Size = new System.Drawing.Size(1045, 150);
            this.stagesDgv.TabIndex = 8;
            this.stagesDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagesDgv_CellClick);
            // 
            // demandesDgv
            // 
            this.demandesDgv.AllowUserToAddRows = false;
            this.demandesDgv.AllowUserToDeleteRows = false;
            this.demandesDgv.AllowUserToResizeColumns = false;
            this.demandesDgv.AllowUserToResizeRows = false;
            this.demandesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demandesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandesDgv.Location = new System.Drawing.Point(12, 279);
            this.demandesDgv.MultiSelect = false;
            this.demandesDgv.Name = "demandesDgv";
            this.demandesDgv.ReadOnly = true;
            this.demandesDgv.RowHeadersWidth = 51;
            this.demandesDgv.RowTemplate.Height = 26;
            this.demandesDgv.Size = new System.Drawing.Size(1045, 150);
            this.demandesDgv.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liste des demandes d\'inscription :";
            // 
            // nomAssCmbBx
            // 
            this.nomAssCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomAssCmbBx.FormattingEnabled = true;
            this.nomAssCmbBx.Location = new System.Drawing.Point(713, 25);
            this.nomAssCmbBx.Name = "nomAssCmbBx";
            this.nomAssCmbBx.Size = new System.Drawing.Size(208, 24);
            this.nomAssCmbBx.TabIndex = 11;
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(898, 60);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(159, 30);
            this.exportBtn.TabIndex = 12;
            this.exportBtn.Text = "Export (XML)";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // Q4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 436);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.nomAssCmbBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.demandesDgv);
            this.Controls.Add(this.stagesDgv);
            this.Controls.Add(this.afiicherBtn);
            this.Controls.Add(this.parAssRadioBtn);
            this.Controls.Add(this.parPeriodeRadioBtn);
            this.Controls.Add(this.dateFinTxtBx);
            this.Controls.Add(this.dateDebutTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Q4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q4";
            this.Load += new System.EventHandler(this.Q4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stagesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateDebutTxtBx;
        private System.Windows.Forms.TextBox dateFinTxtBx;
        private System.Windows.Forms.RadioButton parPeriodeRadioBtn;
        private System.Windows.Forms.RadioButton parAssRadioBtn;
        private System.Windows.Forms.Button afiicherBtn;
        private System.Windows.Forms.DataGridView stagesDgv;
        private System.Windows.Forms.DataGridView demandesDgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nomAssCmbBx;
        private System.Windows.Forms.Button exportBtn;
    }
}