namespace Classification
{
    
    abstract public class GenericClassifier
    {
     
        public GenericClassifier()
        {

        }

    
        abstract public double TrainClassifier(ClassificationData trainingData);

     
        abstract public int[] TestClassifier(ClassificationData testingData);

     
        abstract public int ComputeResult(double[] testingInput);
    }
}