using system;
class test
{
    public static void Main()
    {
        string x=console.readline();
        string y=console.readline();
        string z=console.readline();
        int a=convert.ToInt32(x);
        int b=convert.ToInt32(y);
        int c=convert.ToInt32(z);
        if(a+b>c && b+c>a && a+c>b)
        {
            mohit(a,b,c);
        }
        else
        {
            console.writeline("NO");
        }

    }
    privet void mohit (int x,int y,int z)
    {
        int m = x + y + z ;
        console.writeline(m);
    }
}