namespace BIAI.Network.Events
{
    public class TrainingEpochCompletedEventArgs
    {
        public int Epoch { get; private set; }
        public double Accuracy { get; private set; }
        public double MeanSquareError { get; private set; }

        public TrainingEpochCompletedEventArgs(int epoch, double accuracy, double meanSquareError)
        {
            Epoch = epoch;
            Accuracy = accuracy;
            MeanSquareError = meanSquareError;
        }
    }
}
