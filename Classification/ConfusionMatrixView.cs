using Accord.Statistics.Analysis;
using System.Data;
using System.Windows.Forms;

namespace Classification
{
    public partial class ConfusionMatrixView : Form
    {
    
        DataTable confusionMatrixTable = new DataTable();


        public ConfusionMatrixView(ClassificationData testingData, int[] predictedValues)
        {
            InitializeComponent();

            GeneralConfusionMatrix confusionMatrix =
                new GeneralConfusionMatrix(testingData.OutputPossibleValues, predictedValues, testingData.OutputData);

            for (int n = 0; n <= testingData.OutputPossibleValues; ++n)
            {
                if (n == 0)
                {
                    confusionMatrixTable.Columns.Add("Confusion matrix", typeof(string));
                }
                else
                    confusionMatrixTable.Columns.Add(
                        testingData.CodeBook.Translate(testingData.OutputColumnName, n - 1),
                        typeof(int));
            }
            
            for (int i = 0; i < testingData.OutputPossibleValues; ++i)
            {
                DataRow newRow = confusionMatrixTable.NewRow();
                for (int j = 0; j <= testingData.OutputPossibleValues; ++j)
                {
                    if (j == 0)
                    {
                        newRow[j] = testingData.CodeBook.Translate(testingData.OutputColumnName, i);
                    }
                    else
                        newRow[j] = confusionMatrix.Matrix[i, j - 1];
                }
                confusionMatrixTable.Rows.Add(newRow);
            }
            confusionMatrix_dataGridView.DataSource = confusionMatrixTable;
        }
    }
}