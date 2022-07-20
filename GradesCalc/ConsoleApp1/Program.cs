namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            double sum = 0, average = 0;
            int count=0;

            Console.WriteLine("Welcome to our program \n <-----------Grade Calculator----------->");

            Console.Write("How many grades will you enter?");
            int NumOfGrade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter " + NumOfGrade + " grade");

            int[] grades = new int[NumOfGrade];
            for (int i = 0; i < NumOfGrade; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());

                sum += grades[i];
                count++;
            
            }

            Array.Sort(grades);
            average=sum/count;

            Console.WriteLine("Minimum grade is :" + grades[0]);
            Console.WriteLine("Maximum grade is :" + grades[grades.Length-1]);
            Console.WriteLine("Average is:" + average);

        }
    }
}




