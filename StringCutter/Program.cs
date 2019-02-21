using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCutter
{
    class Program
    {
        static void Main(string[] args)
        {
            string devSda1 = "/dev/sda1              41G   15G   27G  36% /";
            string devSda2 = "/dev/sda2              41G   15G   25G  38% /home/root/sda2";
            string partition1Size = "";
            string partition1Used = "";
            string partition2Size = "";
            string partition2Used = "";

            Console.WriteLine("<----- Comparing strings----->");
            Console.WriteLine("<----- and cutting strings----->");
            Console.WriteLine("Cutting string to remove empty spaaces");
            string[] partition1 = devSda1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            partition1Size = partition1[1];
            partition1Used = partition1[2];
            string[] partition2 = devSda2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            partition2Size = partition2[1];
            partition2Used = partition2[2];
            Console.WriteLine("<----- Printing new strings ----->");
            Console.WriteLine("<--- String Partition1 --->");
            foreach (var line in partition1)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Printing specific partition1Size: " + partition1Size);
            Console.WriteLine("Printing specific partition1Used: " + partition1Used);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("<--- String Partition2 --->");
            foreach (var line in partition2)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Printing specific partition2Size: " + partition2Size);
            Console.WriteLine("Printing specific partition2Used: " + partition2Used);
            Console.WriteLine("<--- Comparing cutted strings--->");
            if (partition1Size == partition2Size && partition1Used == partition2Used)
            {
                Console.WriteLine("Partition 1 Size: " + partition1Size);
                Console.WriteLine("Partition 2 Size: " + partition2Size);
                Console.WriteLine("Partition 1 Used: " + partition1Used);
                Console.WriteLine("Partition 2 Used: " + partition2Used);
                Console.WriteLine("Partitions are equal");
            }
            if (partition1Size != partition2Size || partition1Used != partition2Used)
            {
                Console.WriteLine("Partition 1 Size: " + partition1Size);
                Console.WriteLine("Partition 2 Size: " + partition2Size);
                Console.WriteLine("Partition 1 Used: " + partition1Used);
                Console.WriteLine("Partition 2 Used: " + partition2Used);
                Console.WriteLine("Partitions has different size!");
            }

            //Console.ReadKey();
        }
    }
}