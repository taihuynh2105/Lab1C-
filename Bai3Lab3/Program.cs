using System.Text;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyClass obj = new MyClass(10,4);
        int cong = obj.Cong();
        Console.WriteLine("Phép tính Cộng: " + cong);

        int tru = obj.Tru();
        Console.WriteLine("Phép tính Trừ: " +tru);
        
        int nhan=obj.Nhan();
        Console.WriteLine("Phép tính Nhân: " +nhan);

        int chia=obj.Chia();
        Console.WriteLine("Phép tính Chia: "+ chia);
    }
}