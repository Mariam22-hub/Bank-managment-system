﻿namespace Bank
{
    partial class AdminBranches
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bankSysDataSet = new Bank.BankSysDataSet();
            this.bANKBRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANK_BRANCHTableAdapter = new Bank.BankSysDataSetTableAdapters.BANK_BRANCHTableAdapter();
            this.bRANCHNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKBRANCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 24);
            this.textBox3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 48);
            this.label3.TabIndex = 23;
            this.label3.Text = "Manage Banks";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(477, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 48);
            this.button5.TabIndex = 22;
            this.button5.Text = "Show data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(110, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 48);
            this.button4.TabIndex = 21;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(208, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 24);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 24);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bank ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bRANCHNODataGridViewTextBoxColumn,
            this.bBADDRESSDataGridViewTextBoxColumn,
            this.bANKIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bANKBRANCHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(474, 304);
            this.dataGridView1.TabIndex = 13;
            // 
            // bankSysDataSet
            // 
            this.bankSysDataSet.DataSetName = "BankSysDataSet";
            this.bankSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANKBRANCHBindingSource
            // 
            this.bANKBRANCHBindingSource.DataMember = "BANK_BRANCH";
            this.bANKBRANCHBindingSource.DataSource = this.bankSysDataSet;
            // 
            // bANK_BRANCHTableAdapter
            // 
            this.bANK_BRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // bRANCHNODataGridViewTextBoxColumn
            // 
            this.bRANCHNODataGridViewTextBoxColumn.DataPropertyName = "BRANCH_NO";
            this.bRANCHNODataGridViewTextBoxColumn.HeaderText = "BRANCH_NO";
            this.bRANCHNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRANCHNODataGridViewTextBoxColumn.Name = "bRANCHNODataGridViewTextBoxColumn";
            this.bRANCHNODataGridViewTextBoxColumn.ReadOnly = true;
            this.bRANCHNODataGridViewTextBoxColumn.Width = 125;
            // 
            // bBADDRESSDataGridViewTextBoxColumn
            // 
            this.bBADDRESSDataGridViewTextBoxColumn.DataPropertyName = "BB_ADDRESS";
            this.bBADDRESSDataGridViewTextBoxColumn.HeaderText = "BB_ADDRESS";
            this.bBADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bBADDRESSDataGridViewTextBoxColumn.Name = "bBADDRESSDataGridViewTextBoxColumn";
            this.bBADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // bANKIDDataGridViewTextBoxColumn
            // 
            this.bANKIDDataGridViewTextBoxColumn.DataPropertyName = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.HeaderText = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bANKIDDataGridViewTextBoxColumn.Name = "bANKIDDataGridViewTextBoxColumn";
            this.bANKIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminBranches";
            this.Text = "AdminBranches";
            this.Load += new System.EventHandler(this.AdminBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKBRANCHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankSysDataSet bankSysDataSet;
        private System.Windows.Forms.BindingSource bANKBRANCHBindingSource;
        private BankSysDataSetTableAdapters.BANK_BRANCHTableAdapter bANK_BRANCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKIDDataGridViewTextBoxColumn;
    }
}