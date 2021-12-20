using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Univariate;
using System.Collections.Generic;

namespace Classification
{

    public class NaiveBayesianClassifier : GenericClassifier
    {
        public NaiveBayes<NormalDistribution> BayesianModel { get; private set; }

        public NaiveBayesianClassifier()
        {

        }

      
        public override double TrainClassifier(ClassificationData trainingData)
        {
            double classifierError = 0;

            BayesianModel = new NaiveBayes<NormalDistribution>(
                trainingData.OutputPossibleValues,
                trainingData.InputAttributeNumber,
                NormalDistribution.Standard);

            classifierError = BayesianModel.Estimate(
                trainingData.InputData,
                trainingData.OutputData,
                true,
                new NormalOptions { Regularization = 1e-5 });

            return classifierError;
        }

   
        public override int[] TestClassifier(ClassificationData testingData)
        {
            List<int> results = new List<int>();

            foreach (double[] input in testingData.InputData)
            {
                results.Add(BayesianModel.Compute(input));
            }

            return results.ToArray();
        }

        public override int ComputeResult(double[] testingInput)
        {
            int result = BayesianModel.Compute(testingInput);
            return result;
        }
    }
}