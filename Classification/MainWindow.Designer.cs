namespace Classification
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataset_dataGridView = new System.Windows.Forms.DataGridView();
            this.attributeToPredict_comboBox = new System.Windows.Forms.ComboBox();
            this.attributeToPredict_label = new System.Windows.Forms.Label();
            this.trainClassifier_button = new System.Windows.Forms.Button();
            this.testClassifier_button = new System.Windows.Forms.Button();
            this.classifierToUse_label = new System.Windows.Forms.Label();
            this.classifierToUse_comboBox = new System.Windows.Forms.ComboBox();
            this.training_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trainingFile_button = new System.Windows.Forms.Button();
            this.testingFile_button = new System.Windows.Forms.Button();
            this.testing_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.classificationLog_richTextBox = new System.Windows.Forms.RichTextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.trainingTime_label = new System.Windows.Forms.Label();
            this.testingTime_label = new System.Windows.Forms.Label();
            this.predictionErrorValue_label = new System.Windows.Forms.Label();
            this.classifierErrorValue_label = new System.Windows.Forms.Label();
            this.trainingTimeValue_label = new System.Windows.Forms.Label();
            this.training_groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.performance_groupBox = new System.Windows.Forms.GroupBox();
            this.classifierAccuracyValue_label = new System.Windows.Forms.Label();
            this.predictionAccuracyValue_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testingTimeValue_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testing_groupBox = new System.Windows.Forms.GroupBox();
            this.confusionMatrix_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classificationModel_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_dataGridView)).BeginInit();
            this.training_groupBox.SuspendLayout();
            this.performance_groupBox.SuspendLayout();
            this.testing_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataset_dataGridView
            // 
            this.dataset_dataGridView.AllowUserToAddRows = false;
            this.dataset_dataGridView.AllowUserToDeleteRows = false;
            this.dataset_dataGridView.AllowUserToResizeColumns = false;
            this.dataset_dataGridView.AllowUserToResizeRows = false;
            this.dataset_dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataset_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataset_dataGridView.Enabled = false;
            this.dataset_dataGridView.Location = new System.Drawing.Point(4, 17);
            this.dataset_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataset_dataGridView.Name = "dataset_dataGridView";
            this.dataset_dataGridView.ReadOnly = true;
            this.dataset_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataset_dataGridView.RowTemplate.Height = 24;
            this.dataset_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataset_dataGridView.Size = new System.Drawing.Size(586, 202);
            this.dataset_dataGridView.TabIndex = 0;
            // 
            // attributeToPredict_comboBox
            // 
            this.attributeToPredict_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeToPredict_comboBox.Enabled = false;
            this.attributeToPredict_comboBox.FormattingEnabled = true;
            this.attributeToPredict_comboBox.Items.AddRange(new object[] {
            "y"});
            this.attributeToPredict_comboBox.Location = new System.Drawing.Point(596, 86);
            this.attributeToPredict_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.attributeToPredict_comboBox.Name = "attributeToPredict_comboBox";
            this.attributeToPredict_comboBox.Size = new System.Drawing.Size(151, 21);
            this.attributeToPredict_comboBox.TabIndex = 1;
            this.attributeToPredict_comboBox.SelectedIndexChanged += new System.EventHandler(this.attributeToPredict_comboBox_SelectedIndexChanged);
            // 
            // attributeToPredict_label
            // 
            this.attributeToPredict_label.Location = new System.Drawing.Point(596, 67);
            this.attributeToPredict_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attributeToPredict_label.Name = "attributeToPredict_label";
            this.attributeToPredict_label.Size = new System.Drawing.Size(150, 16);
            this.attributeToPredict_label.TabIndex = 2;
            this.attributeToPredict_label.Text = "Atribut yang akan diprediksi  :";
            // 
            // trainClassifier_button
            // 
            this.trainClassifier_button.Enabled = false;
            this.trainClassifier_button.Location = new System.Drawing.Point(595, 174);
            this.trainClassifier_button.Margin = new System.Windows.Forms.Padding(2);
            this.trainClassifier_button.Name = "trainClassifier_button";
            this.trainClassifier_button.Size = new System.Drawing.Size(152, 45);
            this.trainClassifier_button.TabIndex = 3;
            this.trainClassifier_button.Text = "Train Classifier";
            this.trainClassifier_button.UseVisualStyleBackColor = true;
            this.trainClassifier_button.Click += new System.EventHandler(this.trainClassifier_button_Click);
            // 
            // testClassifier_button
            // 
            this.testClassifier_button.Enabled = false;
            this.testClassifier_button.Location = new System.Drawing.Point(596, 80);
            this.testClassifier_button.Margin = new System.Windows.Forms.Padding(2);
            this.testClassifier_button.Name = "testClassifier_button";
            this.testClassifier_button.Size = new System.Drawing.Size(150, 37);
            this.testClassifier_button.TabIndex = 5;
            this.testClassifier_button.Text = "Test Classifier";
            this.testClassifier_button.UseVisualStyleBackColor = true;
            this.testClassifier_button.Click += new System.EventHandler(this.testClassifier_button_Click);
            // 
            // classifierToUse_label
            // 
            this.classifierToUse_label.Location = new System.Drawing.Point(596, 121);
            this.classifierToUse_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classifierToUse_label.Name = "classifierToUse_label";
            this.classifierToUse_label.Size = new System.Drawing.Size(150, 16);
            this.classifierToUse_label.TabIndex = 6;
            this.classifierToUse_label.Text = "Classifier yang dipakai : ";
            // 
            // classifierToUse_comboBox
            // 
            this.classifierToUse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classifierToUse_comboBox.Enabled = false;
            this.classifierToUse_comboBox.FormattingEnabled = true;
            this.classifierToUse_comboBox.Location = new System.Drawing.Point(596, 140);
            this.classifierToUse_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.classifierToUse_comboBox.Name = "classifierToUse_comboBox";
            this.classifierToUse_comboBox.Size = new System.Drawing.Size(151, 21);
            this.classifierToUse_comboBox.TabIndex = 7;
            this.classifierToUse_comboBox.SelectedIndexChanged += new System.EventHandler(this.classifierToUse_comboBox_SelectedIndexChanged);
            // 
            // training_openFileDialog
            // 
            this.training_openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.training_openFileDialog.InitialDirectory = "Bank-Marketing-Classification";
            // 
            // trainingFile_button
            // 
            this.trainingFile_button.Location = new System.Drawing.Point(596, 17);
            this.trainingFile_button.Margin = new System.Windows.Forms.Padding(2);
            this.trainingFile_button.Name = "trainingFile_button";
            this.trainingFile_button.Size = new System.Drawing.Size(150, 37);
            this.trainingFile_button.TabIndex = 8;
            this.trainingFile_button.Text = "Open Training File";
            this.trainingFile_button.UseVisualStyleBackColor = true;
            this.trainingFile_button.Click += new System.EventHandler(this.trainingFile_button_Click);
            // 
            // testingFile_button
            // 
            this.testingFile_button.Location = new System.Drawing.Point(596, 17);
            this.testingFile_button.Margin = new System.Windows.Forms.Padding(2);
            this.testingFile_button.Name = "testingFile_button";
            this.testingFile_button.Size = new System.Drawing.Size(150, 37);
            this.testingFile_button.TabIndex = 9;
            this.testingFile_button.Text = "Open Testing File";
            this.testingFile_button.UseVisualStyleBackColor = true;
            this.testingFile_button.Click += new System.EventHandler(this.testingFile_button_Click);
            // 
            // testing_openFileDialog
            // 
            this.testing_openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.testing_openFileDialog.InitialDirectory = "Bank-Marketing-Classification";
            // 
            // classificationLog_richTextBox
            // 
            this.classificationLog_richTextBox.DetectUrls = false;
            this.classificationLog_richTextBox.Enabled = false;
            this.classificationLog_richTextBox.Location = new System.Drawing.Point(4, 17);
            this.classificationLog_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.classificationLog_richTextBox.Name = "classificationLog_richTextBox";
            this.classificationLog_richTextBox.ReadOnly = true;
            this.classificationLog_richTextBox.Size = new System.Drawing.Size(588, 212);
            this.classificationLog_richTextBox.TabIndex = 10;
            this.classificationLog_richTextBox.Text = "";
            // 
            // reset_button
            // 
            this.reset_button.Enabled = false;
            this.reset_button.Location = new System.Drawing.Point(764, 246);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(174, 49);
            this.reset_button.TabIndex = 13;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // trainingTime_label
            // 
            this.trainingTime_label.AutoSize = true;
            this.trainingTime_label.Location = new System.Drawing.Point(7, 40);
            this.trainingTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingTime_label.Name = "trainingTime_label";
            this.trainingTime_label.Size = new System.Drawing.Size(70, 13);
            this.trainingTime_label.TabIndex = 14;
            this.trainingTime_label.Text = "Training time:";
            // 
            // testingTime_label
            // 
            this.testingTime_label.AutoSize = true;
            this.testingTime_label.Location = new System.Drawing.Point(4, 120);
            this.testingTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testingTime_label.Name = "testingTime_label";
            this.testingTime_label.Size = new System.Drawing.Size(67, 13);
            this.testingTime_label.TabIndex = 15;
            this.testingTime_label.Text = "Testing time:";
            // 
            // predictionErrorValue_label
            // 
            this.predictionErrorValue_label.AutoSize = true;
            this.predictionErrorValue_label.Location = new System.Drawing.Point(126, 164);
            this.predictionErrorValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictionErrorValue_label.Name = "predictionErrorValue_label";
            this.predictionErrorValue_label.Size = new System.Drawing.Size(10, 13);
            this.predictionErrorValue_label.TabIndex = 21;
            this.predictionErrorValue_label.Text = "-";
            // 
            // classifierErrorValue_label
            // 
            this.classifierErrorValue_label.AutoSize = true;
            this.classifierErrorValue_label.Location = new System.Drawing.Point(126, 85);
            this.classifierErrorValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classifierErrorValue_label.Name = "classifierErrorValue_label";
            this.classifierErrorValue_label.Size = new System.Drawing.Size(10, 13);
            this.classifierErrorValue_label.TabIndex = 20;
            this.classifierErrorValue_label.Text = "-";
            // 
            // trainingTimeValue_label
            // 
            this.trainingTimeValue_label.AutoSize = true;
            this.trainingTimeValue_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trainingTimeValue_label.Location = new System.Drawing.Point(126, 40);
            this.trainingTimeValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingTimeValue_label.Name = "trainingTimeValue_label";
            this.trainingTimeValue_label.Size = new System.Drawing.Size(10, 13);
            this.trainingTimeValue_label.TabIndex = 18;
            this.trainingTimeValue_label.Text = "-";
            // 
            // training_groupBox
            // 
            this.training_groupBox.Controls.Add(this.attributeToPredict_comboBox);
            this.training_groupBox.Controls.Add(this.trainClassifier_button);
            this.training_groupBox.Controls.Add(this.trainingFile_button);
            this.training_groupBox.Controls.Add(this.classifierToUse_label);
            this.training_groupBox.Controls.Add(this.dataset_dataGridView);
            this.training_groupBox.Controls.Add(this.richTextBox1);
            this.training_groupBox.Controls.Add(this.attributeToPredict_label);
            this.training_groupBox.Controls.Add(this.classifierToUse_comboBox);
            this.training_groupBox.Location = new System.Drawing.Point(9, 10);
            this.training_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.training_groupBox.Name = "training_groupBox";
            this.training_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.training_groupBox.Size = new System.Drawing.Size(750, 230);
            this.training_groupBox.TabIndex = 22;
            this.training_groupBox.TabStop = false;
            this.training_groupBox.Text = "Classifier Training";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(735, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // performance_groupBox
            // 
            this.performance_groupBox.Controls.Add(this.classifierAccuracyValue_label);
            this.performance_groupBox.Controls.Add(this.predictionAccuracyValue_label);
            this.performance_groupBox.Controls.Add(this.label4);
            this.performance_groupBox.Controls.Add(this.label3);
            this.performance_groupBox.Controls.Add(this.label2);
            this.performance_groupBox.Controls.Add(this.testingTimeValue_label);
            this.performance_groupBox.Controls.Add(this.label1);
            this.performance_groupBox.Controls.Add(this.trainingTime_label);
            this.performance_groupBox.Controls.Add(this.testingTime_label);
            this.performance_groupBox.Controls.Add(this.predictionErrorValue_label);
            this.performance_groupBox.Controls.Add(this.trainingTimeValue_label);
            this.performance_groupBox.Controls.Add(this.classifierErrorValue_label);
            this.performance_groupBox.Location = new System.Drawing.Point(764, 10);
            this.performance_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.performance_groupBox.Name = "performance_groupBox";
            this.performance_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.performance_groupBox.Size = new System.Drawing.Size(174, 224);
            this.performance_groupBox.TabIndex = 24;
            this.performance_groupBox.TabStop = false;
            this.performance_groupBox.Text = "Performance";
            // 
            // classifierAccuracyValue_label
            // 
            this.classifierAccuracyValue_label.AutoSize = true;
            this.classifierAccuracyValue_label.Location = new System.Drawing.Point(126, 66);
            this.classifierAccuracyValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classifierAccuracyValue_label.Name = "classifierAccuracyValue_label";
            this.classifierAccuracyValue_label.Size = new System.Drawing.Size(10, 13);
            this.classifierAccuracyValue_label.TabIndex = 28;
            this.classifierAccuracyValue_label.Text = "-";
            // 
            // predictionAccuracyValue_label
            // 
            this.predictionAccuracyValue_label.AutoSize = true;
            this.predictionAccuracyValue_label.Location = new System.Drawing.Point(126, 142);
            this.predictionAccuracyValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictionAccuracyValue_label.Name = "predictionAccuracyValue_label";
            this.predictionAccuracyValue_label.Size = new System.Drawing.Size(10, 13);
            this.predictionAccuracyValue_label.TabIndex = 27;
            this.predictionAccuracyValue_label.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Classifier accuracy : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prediction accuracy : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prediction error:";
            // 
            // testingTimeValue_label
            // 
            this.testingTimeValue_label.AutoSize = true;
            this.testingTimeValue_label.Location = new System.Drawing.Point(126, 120);
            this.testingTimeValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testingTimeValue_label.Name = "testingTimeValue_label";
            this.testingTimeValue_label.Size = new System.Drawing.Size(10, 13);
            this.testingTimeValue_label.TabIndex = 23;
            this.testingTimeValue_label.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Classifier error:";
            // 
            // testing_groupBox
            // 
            this.testing_groupBox.Controls.Add(this.confusionMatrix_checkBox);
            this.testing_groupBox.Controls.Add(this.classificationLog_richTextBox);
            this.testing_groupBox.Controls.Add(this.testingFile_button);
            this.testing_groupBox.Controls.Add(this.testClassifier_button);
            this.testing_groupBox.Location = new System.Drawing.Point(9, 477);
            this.testing_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.testing_groupBox.Name = "testing_groupBox";
            this.testing_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.testing_groupBox.Size = new System.Drawing.Size(750, 233);
            this.testing_groupBox.TabIndex = 23;
            this.testing_groupBox.TabStop = false;
            this.testing_groupBox.Text = "Classifier Testing";
            // 
            // confusionMatrix_checkBox
            // 
            this.confusionMatrix_checkBox.Checked = true;
            this.confusionMatrix_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.confusionMatrix_checkBox.Location = new System.Drawing.Point(595, 58);
            this.confusionMatrix_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrix_checkBox.Name = "confusionMatrix_checkBox";
            this.confusionMatrix_checkBox.Size = new System.Drawing.Size(154, 18);
            this.confusionMatrix_checkBox.TabIndex = 11;
            this.confusionMatrix_checkBox.Text = "Tampilkan confusion matrix";
            this.confusionMatrix_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classificationModel_richTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(750, 233);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classifier Modelling";
            // 
            // classificationModel_richTextBox
            // 
            this.classificationModel_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.classificationModel_richTextBox.DetectUrls = false;
            this.classificationModel_richTextBox.Location = new System.Drawing.Point(8, 17);
            this.classificationModel_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.classificationModel_richTextBox.Name = "classificationModel_richTextBox";
            this.classificationModel_richTextBox.ReadOnly = true;
            this.classificationModel_richTextBox.Size = new System.Drawing.Size(727, 212);
            this.classificationModel_richTextBox.TabIndex = 10;
            this.classificationModel_richTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.testing_groupBox);
            this.Controls.Add(this.performance_groupBox);
            this.Controls.Add(this.training_groupBox);
            this.Controls.Add(this.reset_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Classification";
            ((System.ComponentModel.ISupportInitialize)(this.dataset_dataGridView)).EndInit();
            this.training_groupBox.ResumeLayout(false);
            this.performance_groupBox.ResumeLayout(false);
            this.performance_groupBox.PerformLayout();
            this.testing_groupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataset_dataGridView;
        private System.Windows.Forms.ComboBox attributeToPredict_comboBox;
        private System.Windows.Forms.Label attributeToPredict_label;
        private System.Windows.Forms.Button trainClassifier_button;
        private System.Windows.Forms.Button testClassifier_button;
        private System.Windows.Forms.Label classifierToUse_label;
        private System.Windows.Forms.ComboBox classifierToUse_comboBox;
        private System.Windows.Forms.OpenFileDialog training_openFileDialog;
        private System.Windows.Forms.Button trainingFile_button;
        private System.Windows.Forms.Button testingFile_button;
        private System.Windows.Forms.OpenFileDialog testing_openFileDialog;
        private System.Windows.Forms.RichTextBox classificationLog_richTextBox;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label trainingTime_label;
        private System.Windows.Forms.Label testingTime_label;
        private System.Windows.Forms.Label predictionErrorValue_label;
        private System.Windows.Forms.Label classifierErrorValue_label;
        private System.Windows.Forms.Label trainingTimeValue_label;
        private System.Windows.Forms.GroupBox training_groupBox;
        private System.Windows.Forms.GroupBox performance_groupBox;
        private System.Windows.Forms.GroupBox testing_groupBox;
        private System.Windows.Forms.CheckBox confusionMatrix_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label testingTimeValue_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label classifierAccuracyValue_label;
        private System.Windows.Forms.Label predictionAccuracyValue_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox classificationModel_richTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

