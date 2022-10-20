namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice: \n1.add number \n2.add number reverse order\n3.insert no\n4.Append\n5.Delete First no\n");
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
                    linkedList2.Add(56);
                    linkedList2.Add(70);
                    linkedList2.InsertNode(2, 12);
                    linkedList2.Display();
                    break;
                case 4:
                    LinkedList linkedList3 = new LinkedList();
                    linkedList3.Append(56);
                    linkedList3.Append(30);
                    linkedList3.Append(70);
                    linkedList3.Display();
                    break;
                case 5:
                    LinkedList linkedList4 = new LinkedList();
                    linkedList4.Add(56);
                    linkedList4.Add(30);
                    linkedList4.Add(70);
                    linkedList4.Pop();
                    linkedList4.Display();
                    break;

            }
        }
    }
}