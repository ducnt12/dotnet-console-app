class People
{
    private int age;
    private double height;
    public People(int age, double height)
    {
        this.age = age;
        this.height = height;
    }

    public int getAge()
    {
        return this.age;
    }

    public double getHeight()
    {
        return this.height;
    }

    //static Method overloading
    public void add(int a, int b)
    {
        System.Console.WriteLine(a + b);
    }

    public void add(int a, int b, int c)
    {
        System.Console.WriteLine(a + b + c);
    }
}
