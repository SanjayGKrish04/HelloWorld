using System;
using System.Collections.Generic;
using System.Text;

namespace HellowWorld.LittleProjects
{
    public class BlinkPrintName
    {
        public BlinkPrintName() 
        {
            BlinkPintNameFunc();
        }

        private void BlinkPintNameFunc()
        {
            Console.WriteLine("Enter the Name You want to blink");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name)) 
            {
                foreach (char s in name.ToCharArray()) 
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
