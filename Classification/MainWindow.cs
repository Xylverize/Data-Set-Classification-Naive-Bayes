using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Classification
{
    public partial class MainWindow : Form
    {
        private GenericClassifier classifier;
        private ClassificationData trainingData;
        private ClassificationData testingData;
        private double classifierError;
        private double predictionError;
        private List<string> classificationMethods;
    
 
        private bool trainingFileLoaded;
        private bool testingFileLoaded;
        private bool dataTrained;
        private bool attributeChosen;
        private bool classifierChosen;
  
        private Stopwatch chronometer;
     
        private ConfusionMatrixView matrixVisualizer;

 
        public MainWindow()
        {
            InitializeComponent();
            classifierError = 0;
            predictionError = 0;
            trainingFileLoaded = false;
            testingFileLoaded = false;
            dataTrained = false;
            attributeChosen = false;
            classifierChosen = false;
            chronometer = new Stopwatch();

            classificationMethods = new List<string>
            {
              "Naive Bayesian"
            };


            
        }

        private void trainClassifier_button_Click(object sender, EventArgs e)
        {
            classificationModel_richTextBox.SelectionStart = classificationModel_richTextBox.Text.Length;
            classificationModel_richTextBox.ScrollToCaret();
        

            classificationLog_richTextBox.SelectionStart = classificationLog_richTextBox.Text.Length;
            classificationLog_richTextBox.ScrollToCaret();

            if (!trainingData.ProcessDataset(attributeToPredict_comboBox.SelectedItem.ToString()))
            {
                classificationLog_richTextBox.SelectionColor = Color.Red;
                classificationLog_richTextBox.SelectedText =
                    "=====> There was a problem with processing the training data." +
                    Environment.NewLine;
                return;
            }
            classificationLog_richTextBox.SelectionColor = Color.Green;
            classificationModel_richTextBox.Text = richTextBox1.Text;
            classificationLog_richTextBox.SelectedText =
                "=====> Training data was processed correctly." +
                Environment.NewLine;
    
            switch (classifierToUse_comboBox.SelectedItem.ToString())
            {
             
                case "Naive Bayesian":
                    classifier = new NaiveBayesianClassifier();
                    break;
                
                default:
                    return;
            }

            chronometer.Reset();
            chronometer.Start();
            try
            {
             
                if (classifier is NaiveBayesianClassifier)
                    classifierError = ((NaiveBayesianClassifier)classifier).TrainClassifier(
                        trainingData);
            
            }
            catch
            {
                classificationLog_richTextBox.SelectionColor = Color.Red;
                classificationLog_richTextBox.SelectedText =
                    "=====> There was a problem with training the classifier." +
                    Environment.NewLine;
                return;
            }
            chronometer.Stop();
            classificationLog_richTextBox.SelectionColor = Color.Green;
            classificationLog_richTextBox.SelectedText =
                "=====> Classifier was trained successfully." +
                Environment.NewLine;
            trainingTimeValue_label.ForeColor = Color.Blue;
            trainingTimeValue_label.Text = chronometer.ElapsedMilliseconds + " ms";
            classifierErrorValue_label.ForeColor = (classifierError == 0) ? Color.Green : Color.Red;
            classifierErrorValue_label.Text =
                string.Format("{0:0.00}", classifierError * 100) + "%";
            classifierAccuracyValue_label.ForeColor = (classifierError == 0) ? Color.Red : Color.Green;
            classifierAccuracyValue_label.Text =
                string.Format("{0:0.00}", 100 - classifierError * 100 ) + "%";
            dataTrained = true;

            attributeToPredict_comboBox.Enabled = false;
            classifierToUse_comboBox.Enabled = false;
            trainingFile_button.Enabled = false;
            trainClassifier_button.Enabled = false;
            testClassifier_button.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
            this.Refresh();

           
        }

        private void testClassifier_button_Click(object sender, EventArgs e)
        {

            classificationLog_richTextBox.SelectionStart = classificationLog_richTextBox.Text.Length;
            classificationLog_richTextBox.ScrollToCaret();

            if (!testingData.ProcessDataset(trainingData.OutputColumnName, trainingData.CodeBook))
            {
                classificationLog_richTextBox.SelectionColor = Color.Red;
                classificationLog_richTextBox.SelectedText =
                    "=====> There was a problem with processing the testing data." +
                    Environment.NewLine;
                return;
            }
            classificationLog_richTextBox.SelectionColor = Color.Green;
            classificationLog_richTextBox.SelectedText =
                "=====> Testing data was processed correctly. Testing results:" +
                Environment.NewLine;

            predictionError = 0;

            chronometer.Reset();
            chronometer.Start();
            int[] predictedValues = classifier.TestClassifier(testingData);
            chronometer.Stop();

            for (int n = 0; n < predictedValues.Length; ++n)
            {

                if (predictedValues[n] == testingData.OutputData[n])
                {
                    classificationLog_richTextBox.SelectionColor = Color.Green;
                    classificationLog_richTextBox.SelectedText =
                        "MATCHING: expected " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            testingData.OutputData[n]) +
                        " and predicted " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            predictedValues[n]) +
                            Environment.NewLine;
                }
                else
                {
                    ++predictionError;
                    classificationLog_richTextBox.SelectionColor = Color.Red;
                    classificationLog_richTextBox.SelectedText =
                        "NOT MATCHNG: expected " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            testingData.OutputData[n]) +
                        " but predicted " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            predictedValues[n]) +
                        Environment.NewLine;
                }
            }

            classificationLog_richTextBox.SelectionStart = classificationLog_richTextBox.Text.Length;
            classificationLog_richTextBox.ScrollToCaret();

            if (matrixVisualizer != null)
                matrixVisualizer.Close();
            if (confusionMatrix_checkBox.Checked)
            {
                matrixVisualizer = new ConfusionMatrixView(testingData, predictedValues);
                matrixVisualizer.Show();
            }

            testingTimeValue_label.ForeColor = Color.Blue;
            testingTimeValue_label.Text = chronometer.ElapsedMilliseconds + " ms";
            predictionErrorValue_label.ForeColor = (predictionError == 0) ? Color.Green : Color.Red;
            predictionErrorValue_label.Text =
                string.Format("{0:0.00}", predictionError * 100 / predictedValues.Length) + "%";
            predictionAccuracyValue_label.ForeColor = (predictionError == 0) ? Color.Red : Color.Green;
            predictionAccuracyValue_label.Text =
                string.Format("{0:0.00}", 100 - predictionError * 100 / predictedValues.Length) + "%";
        }

        private void trainingFile_button_Click(object sender, EventArgs e)
        {

            classificationLog_richTextBox.SelectionStart = classificationLog_richTextBox.Text.Length;
            classificationLog_richTextBox.ScrollToCaret();

            if (training_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                trainingData = new ClassificationData();

                if (!trainingData.OpenAndParseFile(training_openFileDialog.FileName, true))
                {
                    classificationLog_richTextBox.SelectionColor = Color.Red;
                    classificationLog_richTextBox.SelectedText =
                        "=====> Training file: " +
                        training_openFileDialog.FileName +
                        " was not opened or parsed correctly." +
                        Environment.NewLine;
                    return;
                }
                trainingFileLoaded = true;
                classificationLog_richTextBox.SelectionColor = Color.Green;
                classificationLog_richTextBox.SelectedText =
                    "=====> Training file: " +
                    training_openFileDialog.FileName +
                    " was opened successfully. " +
                    Environment.NewLine;
                
                attributeToPredict_comboBox.SelectedIndex = -1;
                attributeToPredict_comboBox.Enabled = true;
                classifierToUse_comboBox.DataSource = classificationMethods;
                classifierToUse_comboBox.SelectedIndex = -1;
                classifierToUse_comboBox.Enabled = true;
                dataset_dataGridView.DataSource = trainingData.ExtractedDataset;
                dataset_dataGridView.Enabled = true;
                classificationLog_richTextBox.Enabled = true;
                trainClassifier_button.Enabled = attributeChosen && classifierChosen;
                reset_button.Enabled = true;
                testClassifier_button.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
               
            }
        }

        private void testingFile_button_Click(object sender, EventArgs e)
        {
            classificationLog_richTextBox.SelectionStart = classificationLog_richTextBox.Text.Length;
            classificationLog_richTextBox.ScrollToCaret();

            if (testing_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                testingData = new ClassificationData();

                if (!testingData.OpenAndParseFile(testing_openFileDialog.FileName, true))
                {
                    classificationLog_richTextBox.SelectionColor = Color.Red;
                    classificationLog_richTextBox.SelectedText =
                        "=====> Testing file: " +
                        testing_openFileDialog.FileName +
                        " was not opened or parsed correctly." +
                        Environment.NewLine;
                    return;
                }
                testingFileLoaded = true;
                classificationLog_richTextBox.SelectionColor = Color.Green;
                classificationLog_richTextBox.SelectedText =
                    "=====> Testing file: " +
                    testing_openFileDialog.FileName +
                    " was opened successfully." +
                    Environment.NewLine;

                reset_button.Enabled = true;
                testClassifier_button.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
            }
        }

        private void attributeToPredict_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attributeToPredict_comboBox.SelectedIndex >= 0)
                attributeChosen = true;
            else
                attributeChosen = false;
            trainClassifier_button.Enabled = attributeChosen && classifierChosen;
        }

        private void classifierToUse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classifierToUse_comboBox.SelectedIndex >= 0)
            {
                classifierChosen = true;
               
                switch (classifierToUse_comboBox.SelectedItem.ToString())
                {
                
                    case "Naive Bayesian":
                       
                        break;
                
                    default:
                        break;
                }
            }
            else
            {
                classifierChosen = false;
             
            }
            trainClassifier_button.Enabled = attributeChosen && classifierChosen;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            if (matrixVisualizer != null)
                matrixVisualizer.Close();
            trainingFileLoaded = false;
            testingFileLoaded = false;
            dataTrained = false;
            attributeChosen = false;
            classifierChosen = false;
            classifierError = 0;
            predictionError = 0;
            classifier = null;
            trainingData = null;
            testingData = null;
            attributeToPredict_comboBox.DataSource = null;
            attributeToPredict_comboBox.Enabled = false;
            classifierToUse_comboBox.DataSource = null;
            classifierToUse_comboBox.Enabled = false;
            trainingFile_button.Enabled = true;
            trainClassifier_button.Enabled = false;
            testClassifier_button.Enabled = false;
            dataset_dataGridView.DataSource = null;
            dataset_dataGridView.Enabled = false;
            trainingTimeValue_label.ForeColor = SystemColors.ControlText;
            testingTimeValue_label.ForeColor = SystemColors.ControlText;
            classifierErrorValue_label.ForeColor = SystemColors.ControlText;
            predictionErrorValue_label.ForeColor = SystemColors.ControlText;
            trainingTimeValue_label.Text = "-";
            testingTimeValue_label.Text = "-";
            classifierErrorValue_label.Text = "-";
            predictionErrorValue_label.Text = "-";
            classifierAccuracyValue_label.Text = "-";
            predictionAccuracyValue_label.Text = "-";
            classificationLog_richTextBox.Clear();
            classificationLog_richTextBox.Enabled = false;
            classificationModel_richTextBox.Text = "-";
        }
    }
}