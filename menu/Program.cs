
using System.ComponentModel.Design;

List<int> list = new List<int>();
bool control = false;



while (!control)
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("------------------------------");
    Console.WriteLine("A -  Print List :");
    Console.WriteLine("B - Add a Number :");
    Console.WriteLine("C - Display mean of the number :");
    Console.WriteLine("D - Display the Smallest number :");
    Console.WriteLine("E - Display the Largest number:");
    Console.WriteLine("F - Find a number");
    Console.WriteLine("G -  Clear the whole List :");
    Console.WriteLine("S -  Swaping  two number of the  List :");
    Console.WriteLine("I -  number of possitve and negative  in the  List :");


    Console.WriteLine("H - Quit :");

    string enterchar = Console.ReadLine().ToUpper();//عشان حتي لو دخلت رقم صومول بردو
    //print the list
    if (enterchar == "A")
    {
        if (list.Count == 0)
        {
            Console.WriteLine("the list is empty");

        }
        else
        {
            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine(list[i]);
            }
        }

    }
    //add num
    else if (enterchar == "B")
    {
        Console.Write("Enter the number to add :");
        int add = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == add)
            {
                found = true;
                break;

            }



        }

        if (found)
        {
            Console.WriteLine("the number is found");

        }
        else
        {
            list.Add(add);
            Console.WriteLine( $" the number {add} is added");
        }


    }
    //mean number
    else if (enterchar == "C")
    {
        if (list.Count > 0)
        {
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];


            }

            double reuslt = sum / list.Count;
            Console.WriteLine($"the mean is {reuslt}");
        }



    }
    //smallest
    else if (enterchar == "D")
    {
        int smallestNum = list[0];
        for (int i = 0; i < list.Count; i++)
        {
            if (smallestNum > list[i])
            {
                smallestNum = list[i];
            }
        }
        Console.WriteLine(smallestNum);
    }
    //largest
    else if (enterchar == "E")
    {
        int largestNum = list[0];
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >largestNum)
            {
                largestNum = list[i];
            }

        }
        Console.WriteLine(largestNum);
    }
    //find
    else if (enterchar == "F")
    {
        Console.WriteLine(" To find Enter the number : ");
        int ind = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < list.Count; i++)
        {

          
            if (list[i] == ind)
            {
                ind = list[i];
                found = true;
                break;
            }
    

        }
        if (!found)
        {
            Console.WriteLine(" the elemnt is not found");
        }
        continue;   
        Console.WriteLine($"the number  {ind} is found ");


    }

    //مسح الليست
    else if (enterchar == "G")
    {
        list.Clear();
        Console.WriteLine("you clear the list !");
    }

    // bouns
    //swapping
    else if (enterchar == "S")
    {
        int index1 = -1; int index2 = -1;
        int value1, value2;
        Console.WriteLine("Enter the first value : ");
        value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the secound value : ");
        value2 = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < list.Count; i++)
        {
            if (value1 == list[i])

                index1 = i;

            if (value2 == list[i])

                index2 = i;

        }
        if (index1 != -1 && index2 != -1)
        {
            int temp = list[0];
            list[0] = list[1];
            list[1] = temp;
        }




    }
    // negative and possitve number 
    else if (enterchar == "I")
    {
        int posstiveNum = 0;
        int negativeNum = 0;
        for (int i = 0; i < list.Count; i++)
        {

            if (list[i] > 0)
            {
                posstiveNum += 1;
            }
            else if (list[i] < 0)
            {
                negativeNum += 1;
            }

        }
        Console.WriteLine($"Possitve number : {posstiveNum}");
        Console.WriteLine($"Possitve number : {negativeNum}");
    }
    //exit
    else if (enterchar == "H")
    {
        Console.WriteLine("you are Exit .");
        control = true;
    }

}




