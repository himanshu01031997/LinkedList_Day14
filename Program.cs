namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice: \n1.add number \n2.add number reverse order\n3.insert no\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                case 2:
                    LinkedList linkedList1 = new LinkedList();

                    linkedList1.AddInReverseOrder(70);
                    linkedList1.AddInReverseOrder(30);
                    linkedList1.AddInReverseOrder(56);
                    linkedList1.Display();
                    break;
                case 3:
                    LinkedList linkedList2 = new LinkedList();
                    //int a=  linkedList2.Search(70);
                    //Console.WriteLine("index position of 70 is"+a);
                    // linkedList2.InsertNode(2, 67);
                    linkedList2.Add(56);
                    linkedList2.Add(70);
                    linkedList2.InsertNode(2, 30);
                    linkedList2.Display();


                    break;

            }
            



        }
    }
}