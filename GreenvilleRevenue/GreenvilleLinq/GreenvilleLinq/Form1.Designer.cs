namespace GreenvilleLinq
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnName = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.checkBoxSinging = new System.Windows.Forms.CheckBox();
            this.checkBoxDancing = new System.Windows.Forms.CheckBox();
            this.checkBoxInstrument = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.greenvilledatabase1DataSet = new GreenvilleLinq.greenvilledatabase1DataSet();
            this.contestblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contestblTableAdapter = new GreenvilleLinq.greenvilledatabase1DataSetTableAdapters.contestblTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenvilledatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(40, 83);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(148, 23);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "View the Contesient Name\'s";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(40, 112);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(148, 23);
            this.btnCode.TabIndex = 1;
            this.btnCode.Text = "View Talent Code\'s";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(194, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(284, 394);
            this.outputListBox.TabIndex = 2;
            // 
            // checkBoxSinging
            // 
            this.checkBoxSinging.AutoSize = true;
            this.checkBoxSinging.Location = new System.Drawing.Point(40, 192);
            this.checkBoxSinging.Name = "checkBoxSinging";
            this.checkBoxSinging.Size = new System.Drawing.Size(137, 17);
            this.checkBoxSinging.TabIndex = 3;
            this.checkBoxSinging.Text = "Talent Code for Singing";
            this.checkBoxSinging.UseVisualStyleBackColor = true;
            this.checkBoxSinging.CheckedChanged += new System.EventHandler(this.checkBoxSinging_CheckedChanged);
            // 
            // checkBoxDancing
            // 
            this.checkBoxDancing.AutoSize = true;
            this.checkBoxDancing.Location = new System.Drawing.Point(40, 215);
            this.checkBoxDancing.Name = "checkBoxDancing";
            this.checkBoxDancing.Size = new System.Drawing.Size(142, 17);
            this.checkBoxDancing.TabIndex = 4;
            this.checkBoxDancing.Text = "Talent Code for Dancing";
            this.checkBoxDancing.UseVisualStyleBackColor = true;
            this.checkBoxDancing.CheckedChanged += new System.EventHandler(this.checkBoxDancing_CheckedChanged);
            // 
            // checkBoxInstrument
            // 
            this.checkBoxInstrument.AutoSize = true;
            this.checkBoxInstrument.Location = new System.Drawing.Point(40, 238);
            this.checkBoxInstrument.Name = "checkBoxInstrument";
            this.checkBoxInstrument.Size = new System.Drawing.Size(151, 17);
            this.checkBoxInstrument.TabIndex = 5;
            this.checkBoxInstrument.Text = "Talent Code for Instrument";
            this.checkBoxInstrument.UseVisualStyleBackColor = true;
            this.checkBoxInstrument.CheckedChanged += new System.EventHandler(this.checkBoxInstrument_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.talentCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contestblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(666, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // greenvilledatabase1DataSet
            // 
            this.greenvilledatabase1DataSet.DataSetName = "greenvilledatabase1DataSet";
            this.greenvilledatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contestblBindingSource
            // 
            this.contestblBindingSource.DataMember = "contestbl";
            this.contestblBindingSource.DataSource = this.greenvilledatabase1DataSet;
            // 
            // contestblTableAdapter
            // 
            this.contestblTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // talentCodeDataGridViewTextBoxColumn
            // 
            this.talentCodeDataGridViewTextBoxColumn.DataPropertyName = "TalentCode";
            this.talentCodeDataGridViewTextBoxColumn.HeaderText = "TalentCode";
            this.talentCodeDataGridViewTextBoxColumn.Name = "talentCodeDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click To view!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(495, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxInstrument);
            this.Controls.Add(this.checkBoxDancing);
            this.Controls.Add(this.checkBoxSinging);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenvilledatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.CheckBox checkBoxSinging;
        private System.Windows.Forms.CheckBox checkBoxDancing;
        private System.Windows.Forms.CheckBox checkBoxInstrument;
        private System.Windows.Forms.DataGridView dataGridView1;
        private greenvilledatabase1DataSet greenvilledatabase1DataSet;
        private System.Windows.Forms.BindingSource contestblBindingSource;
        private greenvilledatabase1DataSetTableAdapters.contestblTableAdapter contestblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

