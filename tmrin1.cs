using system;
class test
{
    public static void Main()
    {
        string a =console.readline();
        string b =console.readline();
        int x = convert.ToInt32(a);
        int y = convert.ToInt32(b);
        int z = math.Abs(x-y);
        int w =math.pow(z,math.Abs(y));
        int t =math.sqrt(w);
        console.writline(t);
        
        
    }
}