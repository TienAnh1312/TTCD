using static Lab7_4.Custom;

internal class Program
{
    private static void Main(string[] args)
    {
        int intCnt;
        int intNum = 0;
        Console.WriteLine("Nhap 1 so: ");
        //nhập và tung ngoại tệ
        try
        {
            intNum = Convert.ToInt32(Console.ReadLine());
            if (intNum <= 0)
            {
                throw new InvalidInputNumber();
            }
        }catch (InvalidInputNumber objInvalidInput) {
            Console.WriteLine(objInvalidInput.Message);
        }catch(System.FormatException objFormatException)
        {
            Console.WriteLine(objFormatException.Message);
        }
        finally
        {
            if (intNum > 0)
            {
                for(intCnt = 1; intCnt <= 10; intCnt++)
                {
                    Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}