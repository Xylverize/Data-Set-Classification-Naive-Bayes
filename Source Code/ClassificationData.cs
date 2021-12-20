using Accord.Math;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Classification
{
    public class ClassificationData
    {
        public DataTable ExtractedDataset { get; private set; }
        public DataTable ProcessedDataset { get; private set; }
        public Codification CodeBook { get; private set; }
        public List<string> AllColumnNames { get; private set; }
        public List<string> InputColumnNames { get; private set; }
        public string OutputColumnName { get; private set; }
        public double[][] InputData { get; private set; }
        public int[] OutputData { get; private set; }
        public int InputAttributeNumber { get; private set; }
        public int OutputPossibleValues { get; private set; }
       
        public ClassificationData()
        {
            initializeVariables();
        }

     
        private void initializeVariables()
        {
            ExtractedDataset = new DataTable();
            ProcessedDataset = new DataTable();
            CodeBook = new Codification();
            AllColumnNames = new List<string>();
            InputColumnNames = new List<string>();
            InputData = null;
            OutputData = null;
            InputAttributeNumber = 0;
            OutputPossibleValues = 0;
        }

     
        public bool OpenAndParseFile(string filePath, bool hasHeader = false)
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(filePath))
                {
                    string textLine = "";
                    string[] textLineTokens = null;

                    
                    textLine = inputFile.ReadLine();
                    textLineTokens = textLine.Split(',');
                    for (int n = 0; n < textLineTokens.Length; ++n)
                    {
                       
                        if (!hasHeader)
                            AllColumnNames.Add("attribute_" + (n + 1).ToString());
                        
                        else
                            AllColumnNames.Add(textLineTokens[n]);

                        ExtractedDataset.Columns.Add(AllColumnNames[n], typeof(string));
                    }
                  
                    if (!hasHeader)
                        ExtractedDataset.Rows.Add(textLineTokens);

                    while ((textLine = inputFile.ReadLine()) != null)
                    {
                        textLineTokens = textLine.Split(',');
                        ExtractedDataset.Rows.Add(textLineTokens);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ProcessDataset(string attributeToPredict, Codification codeBook = null)
        {
           
            ProcessedDataset = ExtractedDataset.Clone();

            InputData = new double[ExtractedDataset.Rows.Count][];
            OutputData = new int[ExtractedDataset.Rows.Count];

            foreach (DataColumn column in ExtractedDataset.Columns)
            {
                if (column.ColumnName != attributeToPredict)
                {
                    InputColumnNames.Add(column.ColumnName);
                    ProcessedDataset.Columns[column.Ordinal].DataType = typeof(double);
                }
                else
                    OutputColumnName = column.ColumnName;
            }

            try
            {
             
                double tempValue = 0;
                DataRow processedRow = null;
                List<double> tempInput = null;

                for (int row = 0; row < ExtractedDataset.Rows.Count; ++row)
                {
            
                    processedRow = ProcessedDataset.NewRow();
                    tempInput = new List<double>();
                    foreach (DataColumn column in ExtractedDataset.Columns)
                    {
                        if (column.ColumnName != attributeToPredict)
                        {
                            Double.TryParse(
                                ExtractedDataset.Rows[row][column.Ordinal] as string,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out tempValue);
                        
                            processedRow[column.Ordinal] = tempValue;
                            tempInput.Add(tempValue);
                        }
                        else
                        {
                           
                            processedRow[column.Ordinal] = ExtractedDataset.Rows[row][column.Ordinal];
                        }
                    }
                    
                    ProcessedDataset.Rows.Add(processedRow);
                    InputData[row] = tempInput.ToArray();
                }

                if (codeBook != null)
                
                    this.CodeBook = codeBook;
                else
                  
                    CodeBook = new Codification(ExtractedDataset, attributeToPredict);

        
                ProcessedDataset = CodeBook.Apply(ProcessedDataset);
                
                OutputData = ProcessedDataset.ToArray<int>(attributeToPredict);

                InputAttributeNumber = ExtractedDataset.Columns.Count - 1;

                OutputPossibleValues = CodeBook[attributeToPredict].Symbols;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}