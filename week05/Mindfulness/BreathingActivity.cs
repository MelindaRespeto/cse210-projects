using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
              "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            AnimateBreath("Breathe in...", 4);
            AnimateBreath("Breathe out...", 6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    // More meaningful breathing animation
    private void AnimateBreath(string message, int seconds)
    {
        Console.WriteLine(message);

        int totalSteps = 10; // number of visual growth steps
        double baseDelay = (double)seconds / totalSteps;

        // accelerate quickly then slow down
        for (int i = 1; i <= totalSteps; i++)
        {
            int delay = (int)(baseDelay * (0.5 + (i / (double)totalSteps))); 
            string bar = new string('●', i).PadRight(totalSteps, '○');

            Console.Write("\r" + bar); // overwrite previous
            System.Threading.Thread.Sleep(delay * 1000);
        }
        Console.WriteLine();
    }
}
