using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int sec;
        Console.WriteLine("Nhập vào số giây: ");
        sec = Convert.ToInt32(Console.ReadLine());

        int h, m, s;
        h = (int)sec / 360;
        var hh = (h > 10) ? h.ToString() : "0" + h;
        m = (sec - h * 360) / 60;
        var mm = (m > 10) ? m.ToString() : "0" + m;
        s = sec - m * 60 - h * 360;
        var ss = (s > 10) ? s.ToString() : "0" + s;

        Console.WriteLine(hh + ":" + mm + ":" + ss);
    }
}