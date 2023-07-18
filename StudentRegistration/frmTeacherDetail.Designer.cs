namespace StudentRegistration
{
    partial class frmTeacherDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınsertCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBatchSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillLoadOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missingMappingActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missingSchemaActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sqlDataAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionStringSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 57);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 27);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(186, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 27);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(372, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 267);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Scors";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 27);
            this.textBox5.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(186, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 27);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exam 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Exam 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(714, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 267);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Scors";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(175, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(175, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(175, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Failed Student :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Passed Student :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Avarege :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(31, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(996, 295);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCommandDataGridViewTextBoxColumn,
            this.ınsertCommandDataGridViewTextBoxColumn,
            this.selectCommandDataGridViewTextBoxColumn,
            this.updateCommandDataGridViewTextBoxColumn,
            this.updateBatchSizeDataGridViewTextBoxColumn,
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn,
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn,
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn,
            this.fillLoadOptionDataGridViewTextBoxColumn,
            this.missingMappingActionDataGridViewTextBoxColumn,
            this.missingSchemaActionDataGridViewTextBoxColumn,
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sqlDataAdapterBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(990, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteCommandDataGridViewTextBoxColumn
            // 
            this.deleteCommandDataGridViewTextBoxColumn.DataPropertyName = "DeleteCommand";
            this.deleteCommandDataGridViewTextBoxColumn.HeaderText = "DeleteCommand";
            this.deleteCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deleteCommandDataGridViewTextBoxColumn.Name = "deleteCommandDataGridViewTextBoxColumn";
            this.deleteCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınsertCommandDataGridViewTextBoxColumn
            // 
            this.ınsertCommandDataGridViewTextBoxColumn.DataPropertyName = "InsertCommand";
            this.ınsertCommandDataGridViewTextBoxColumn.HeaderText = "InsertCommand";
            this.ınsertCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınsertCommandDataGridViewTextBoxColumn.Name = "ınsertCommandDataGridViewTextBoxColumn";
            this.ınsertCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // selectCommandDataGridViewTextBoxColumn
            // 
            this.selectCommandDataGridViewTextBoxColumn.DataPropertyName = "SelectCommand";
            this.selectCommandDataGridViewTextBoxColumn.HeaderText = "SelectCommand";
            this.selectCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectCommandDataGridViewTextBoxColumn.Name = "selectCommandDataGridViewTextBoxColumn";
            this.selectCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateCommandDataGridViewTextBoxColumn
            // 
            this.updateCommandDataGridViewTextBoxColumn.DataPropertyName = "UpdateCommand";
            this.updateCommandDataGridViewTextBoxColumn.HeaderText = "UpdateCommand";
            this.updateCommandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateCommandDataGridViewTextBoxColumn.Name = "updateCommandDataGridViewTextBoxColumn";
            this.updateCommandDataGridViewTextBoxColumn.Width = 125;
            // 
            // updateBatchSizeDataGridViewTextBoxColumn
            // 
            this.updateBatchSizeDataGridViewTextBoxColumn.DataPropertyName = "UpdateBatchSize";
            this.updateBatchSizeDataGridViewTextBoxColumn.HeaderText = "UpdateBatchSize";
            this.updateBatchSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateBatchSizeDataGridViewTextBoxColumn.Name = "updateBatchSizeDataGridViewTextBoxColumn";
            this.updateBatchSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // acceptChangesDuringFillDataGridViewCheckBoxColumn
            // 
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.DataPropertyName = "AcceptChangesDuringFill";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.HeaderText = "AcceptChangesDuringFill";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.Name = "acceptChangesDuringFillDataGridViewCheckBoxColumn";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.Width = 125;
            // 
            // acceptChangesDuringUpdateDataGridViewCheckBoxColumn
            // 
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.DataPropertyName = "AcceptChangesDuringUpdate";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.HeaderText = "AcceptChangesDuringUpdate";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.Name = "acceptChangesDuringUpdateDataGridViewCheckBoxColumn";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.Width = 125;
            // 
            // continueUpdateOnErrorDataGridViewCheckBoxColumn
            // 
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.DataPropertyName = "ContinueUpdateOnError";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.HeaderText = "ContinueUpdateOnError";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.Name = "continueUpdateOnErrorDataGridViewCheckBoxColumn";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.Width = 125;
            // 
            // fillLoadOptionDataGridViewTextBoxColumn
            // 
            this.fillLoadOptionDataGridViewTextBoxColumn.DataPropertyName = "FillLoadOption";
            this.fillLoadOptionDataGridViewTextBoxColumn.HeaderText = "FillLoadOption";
            this.fillLoadOptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fillLoadOptionDataGridViewTextBoxColumn.Name = "fillLoadOptionDataGridViewTextBoxColumn";
            this.fillLoadOptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // missingMappingActionDataGridViewTextBoxColumn
            // 
            this.missingMappingActionDataGridViewTextBoxColumn.DataPropertyName = "MissingMappingAction";
            this.missingMappingActionDataGridViewTextBoxColumn.HeaderText = "MissingMappingAction";
            this.missingMappingActionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missingMappingActionDataGridViewTextBoxColumn.Name = "missingMappingActionDataGridViewTextBoxColumn";
            this.missingMappingActionDataGridViewTextBoxColumn.Width = 125;
            // 
            // missingSchemaActionDataGridViewTextBoxColumn
            // 
            this.missingSchemaActionDataGridViewTextBoxColumn.DataPropertyName = "MissingSchemaAction";
            this.missingSchemaActionDataGridViewTextBoxColumn.HeaderText = "MissingSchemaAction";
            this.missingSchemaActionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missingSchemaActionDataGridViewTextBoxColumn.Name = "missingSchemaActionDataGridViewTextBoxColumn";
            this.missingSchemaActionDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnProviderSpecificTypesDataGridViewCheckBoxColumn
            // 
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.DataPropertyName = "ReturnProviderSpecificTypes";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.HeaderText = "ReturnProviderSpecificTypes";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.Name = "returnProviderSpecificTypesDataGridViewCheckBoxColumn";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // sqlDataAdapterBindingSource
            // 
            this.sqlDataAdapterBindingSource.DataSource = typeof(System.Data.SqlClient.SqlDataAdapter);
            this.sqlDataAdapterBindingSource.CurrentChanged += new System.EventHandler(this.sqlDataAdapterBindingSource_CurrentChanged);
            // 
            // connectionStringSettingsBindingSource
            // 
            this.connectionStringSettingsBindingSource.DataSource = typeof(System.Configuration.ConnectionStringSettings);
            // 
            // frmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1064, 630);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeacherDetail";
            this.Text = "frmTeacherDetail";
            this.Load += new System.EventHandler(this.frmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn deleteCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ınsertCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn selectCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateBatchSizeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn acceptChangesDuringFillDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn acceptChangesDuringUpdateDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn continueUpdateOnErrorDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fillLoadOptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn missingMappingActionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn missingSchemaActionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn returnProviderSpecificTypesDataGridViewCheckBoxColumn;
        private BindingSource sqlDataAdapterBindingSource;
        private BindingSource connectionStringSettingsBindingSource;
    }
}