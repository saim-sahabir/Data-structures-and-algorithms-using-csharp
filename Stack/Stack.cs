// stack implement using built'in class 
 var stack = new Stack<string>();

  stack.Push("saim");
  stack.Push("raj");
  stack.Push("sahabir");
   stack.Pop();
   stack.Pop();

 for (int i = 0; i < stack.Count; i++)
 {
  Console.WriteLine(stack.ElementAt(i));
 }
 
 //stack implement manually 

 int capacity = 5;
 int [] myStack = new int[5];
 int top = -1;
 
 Push(22);
 Push(3);
 Push(4);
 Pop();
 Push(55);

 

 foreach (var item in myStack)
 {
  Console.WriteLine(item);
 }
 
 void Push(int data)
 {
  if (top < capacity -1)
  {
   top = top + 1;
   myStack[top] = data ;
   Console.WriteLine("Item Add sucsessfull" + myStack[top]);
  }
  else
  {
   Console.WriteLine("stack is full");
  }
 }

 int Pop()
 {
  if (top < 0)
  {
   Console.WriteLine("Exception! Stack Underflow" +top);
   return -1;

  }

  var value = myStack[top];
    top = top - 1;
    Console.WriteLine(top);
    return value;
  
 }

 int Pick()
 {

  if (top < 0)
  {
   Console.WriteLine("Exception! Stack Underflow" + top);
   return -1;

  }

  return -1;
 }