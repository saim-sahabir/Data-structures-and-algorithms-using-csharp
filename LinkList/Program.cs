using System.Threading.Channels;





var list = new MyListLink<string>();

list.AddFirst("saim");
list.AddFirst("hello");
 Console.WriteLine(list);

var blist = new LinkedList<string>();

foreach (var item in blist)
{
    Console.WriteLine(item);
}
 


public class MyListLink<T>
{

    private Node<T> head;
    private int Size = 0;
  public class Node<T>
    {
       T Data; 
      Node<T> Next;

      public Node( T data)
      {
        this.Data = data;
        this.Next = null;
      }

    } 

    public void AddFirst(T data)
    {
        
        var newNode = new Node<T>(data);
       
        if (head == null)
        {
            head = newNode;
            
        }

        Size++;


    }

    public void AddLast(T data)
    {
        
        var newNode = new Node<T>(data);
        
    }
    
    
    
}

