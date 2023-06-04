// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        UseCase2LinkedList useCase2 = new UseCase2LinkedList();
        Console.WriteLine("UC 2: Ability to create Linked List by adding 30 and 56 to 70");
        useCase2.CreateLinkedList();
        Console.WriteLine();

        UseCase3LinkedList useCase3 = new UseCase3LinkedList();
        Console.WriteLine("UC 3: Ability to create Linked List by appending 30 and 70 to 56");
        useCase3.CreateLinkedList();
        Console.WriteLine();

        UseCase4LinkedList useCase4 = new UseCase4LinkedList();
        Console.WriteLine("UC 4: Ability to insert 30 between 56 and 70");
        useCase4.CreateLinkedList();
        Console.WriteLine();

        UseCase5LinkedList useCase5 = new UseCase5LinkedList();
        Console.WriteLine("UC 5: Ability to delete the first element in the LinkedList of sequence 56->30->70");
        useCase5.CreateLinkedList();
        Console.WriteLine();

        UseCase6LinkedList useCase6 = new UseCase6LinkedList();
        Console.WriteLine("UC 6: Ability to delete the last element in the LinkedList of sequence 56->30->70");
        useCase6.CreateLinkedList();
        Console.WriteLine();

        UseCase7LinkedList useCase7 = new UseCase7LinkedList();
        Console.WriteLine("UC 7: Ability to search LinkedList to find Node with value 30");
        useCase7.CreateLinkedList();
        Console.WriteLine();

        UseCase8LinkedList useCase8 = new UseCase8LinkedList();
        Console.WriteLine("UC 8: Ability to insert 40 after 30 to the Linked List sequence of 56->30->70");
        useCase8.CreateLinkedList();
        Console.WriteLine();

        UseCase9LinkedList useCase9 = new UseCase9LinkedList();
        Console.WriteLine("UC 9: Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3");
        useCase9.CreateLinkedList();
        Console.WriteLine();

        UseCase10SortedLinkedList useCase10 = new UseCase10SortedLinkedList();
        Console.WriteLine("UC 10: Ability to create Ordered Linked List in ascending order of data entered");
        useCase10.CreateSortedLinkedList();
    }
}

