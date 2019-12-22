namespace LadyFitness.forms
{
    partial class Main2
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
            this.fitness2DataSet11 = new LadyFitness.Fitness2DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fitness2DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectTimetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectTimetableTableAdapter = new LadyFitness.Fitness2DataSet1TableAdapters.SelectTimetableTableAdapter();
            this.dayNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fitness2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitness2DataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTimetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fitness2DataSet11
            // 
            this.fitness2DataSet11.DataSetName = "Fitness2DataSet1";
            this.fitness2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayNumberDataGridViewTextBoxColumn,
            this.typeRoomDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.trainNameDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.classTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectTimetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // fitness2DataSet11BindingSource
            // 
            this.fitness2DataSet11BindingSource.DataSource = this.fitness2DataSet11;
            this.fitness2DataSet11BindingSource.Position = 0;
            // 
            // selectTimetableBindingSource
            // 
            this.selectTimetableBindingSource.DataMember = "SelectTimetable";
            this.selectTimetableBindingSource.DataSource = this.fitness2DataSet11BindingSource;
            // 
            // selectTimetableTableAdapter
            // 
            this.selectTimetableTableAdapter.ClearBeforeFill = true;
            // 
            // dayNumberDataGridViewTextBoxColumn
            // 
            this.dayNumberDataGridViewTextBoxColumn.DataPropertyName = "DayNumber";
            this.dayNumberDataGridViewTextBoxColumn.HeaderText = "DayNumber";
            this.dayNumberDataGridViewTextBoxColumn.Name = "dayNumberDataGridViewTextBoxColumn";
            // 
            // typeRoomDataGridViewTextBoxColumn
            // 
            this.typeRoomDataGridViewTextBoxColumn.DataPropertyName = "TypeRoom";
            this.typeRoomDataGridViewTextBoxColumn.HeaderText = "TypeRoom";
            this.typeRoomDataGridViewTextBoxColumn.Name = "typeRoomDataGridViewTextBoxColumn";
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            // 
            // trainNameDataGridViewTextBoxColumn
            // 
            this.trainNameDataGridViewTextBoxColumn.DataPropertyName = "TrainName";
            this.trainNameDataGridViewTextBoxColumn.HeaderText = "TrainName";
            this.trainNameDataGridViewTextBoxColumn.Name = "trainNameDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // classTimeDataGridViewTextBoxColumn
            // 
            this.classTimeDataGridViewTextBoxColumn.DataPropertyName = "ClassTime";
            this.classTimeDataGridViewTextBoxColumn.HeaderText = "ClassTime";
            this.classTimeDataGridViewTextBoxColumn.Name = "classTimeDataGridViewTextBoxColumn";
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main2";
            this.Text = "Main2";
            this.Load += new System.EventHandler(this.Main2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitness2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitness2DataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTimetableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Fitness2DataSet1 fitness2DataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fitness2DataSet11BindingSource;
        private System.Windows.Forms.BindingSource selectTimetableBindingSource;
        private Fitness2DataSet1TableAdapters.SelectTimetableTableAdapter selectTimetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTimeDataGridViewTextBoxColumn;
    }
}