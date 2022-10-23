// See https://aka.ms/new-console-template for more information
// Add(1, 2, 3);
int[] intArray = { 1, 2, 3 };
double[] doubleArray = { 1.0, 2.0, 3.0 };
String[] stringArray = { "1", "2", "3" };

Thread thread1 = new Thread(() => displayElements(intArray));
Thread thread2 = new Thread(() => displayElements(stringArray));
thread1.Start();
displayElements(doubleArray);
thread2.Start();


static void displayElements<T>(T[] list)
{
    foreach (T item in list)
    {
        System.Console.WriteLine(item);
        Thread.Sleep(1000);
    }
}

