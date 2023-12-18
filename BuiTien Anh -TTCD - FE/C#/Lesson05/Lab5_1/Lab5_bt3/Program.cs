internal class Program
{
    private static void Main(string[] args)
    {
        string[] canArray = { "Giáp", "Ất","Binh", "Bính", "Mậu", "Kỷ","Canh", "Tân", "NHâm", "Quý" };
        string[] chiArray = { "Tý", "Sửu", "Dần ", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tất", "Hợi" };

        Console.WriteLine("Nhập năm bất kỳ");
        int year = Convert.ToInt32(Console.ReadLine());

        int startYear = 2010;
        int startIndex = 6;// vị trí cố định của can
        int endIndex = 2;//vị trí cố định của chi

        int canIndex = (year - startYear + startIndex) % canArray.Length;
        int chiIdex = (year - startYear + endIndex) % chiArray.Length;

        if(canIndex < 0)
        {
            canIndex += canArray.Length;
        }
        if(canIndex > 0)
        {
            chiIdex += canArray.Length;
        }
        string can = canArray[canIndex];
        string chi = chiArray[canIndex];

        Console.WriteLine("Năm âm tương ứng: {0} {1}", can, chi);
    }
}