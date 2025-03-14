namespace StatisticLibrary.Methods
{
    public class MySatistic
    {
        public static double Mean(List<double> data){

            // Two variables:
            int totalData = 0;
            double totalSum = 0;

            foreach(double number in data){
                totalData++;
                totalSum += number;
            }
            return totalSum / totalData;

        }

        // Median
        public static double Median(List<double> data){
            data.Sort();

            int totalData = 0;

            foreach(double number in data){
                totalData++;
            }
            double medianNumber = 0;
            // Even number of data
            if(totalData % 2 == 0){
                medianNumber = (data[totalData/2] + data[totalData/2 - 1]) / 2.0;
                return medianNumber;
            } 
            else // Odd number of elements
            {
                return data[totalData/2];
            }

        }
    }
}