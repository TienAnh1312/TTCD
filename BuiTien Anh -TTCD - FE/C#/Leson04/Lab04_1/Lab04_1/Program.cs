using Lab04_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //khởi tạo lớp window
        Window win = new Window(1,2);
        //khởi tạo lớp listbox
        ListBox lb = new ListBox(3, 4, "stand alone list box");
        //khởi tạo lớp button
        Button b = new Button(5, 6);
        win.DrawWindow();
        lb.DrawWindow();
        b.DrawWindow();
        //khởi tạo mảng window
        Window[] winArray = new Window[3];
        winArray[0] = new Window(1,2);
        winArray[1] = new ListBox(3,4, "List Box in array");
        winArray[2] = new Button(5, 6);
        for (int i = 0; i < 3; i++)
        {
            winArray[i].DrawWindow();
        }
    }
}