using System;
using static System.Console;

public class Spinner
{
    public Spinner() 
    {

    }

   public void GetSpinner()
{
    int spin = 0;
    while (spin != 3)
    {
        Write("|");
        Thread.Sleep(500);
        Write("\b \b");
        Write("/");
        Thread.Sleep(500);
        Write("\b \b");
        Write("-");
        Thread.Sleep(500);
        Write("\b \b");
        Write("\\");
        Thread.Sleep(500);
        Write("\b \b");

        // Add some creativity to the spinner by drawing a circle around it.
        for (int i = 0; i < 360; i += 10)
        {
            Write("::::::");
            Thread.Sleep(50);
        }

        spin += 1;
    }
}

}