using QueueWithLinkedList;

var queue = new Queue();

queue.Dequeue();
queue.Enqueue(1);
queue.Enqueue(4);
queue.Dequeue();
queue.Enqueue(5);
queue.Enqueue(6);

//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();

Console.WriteLine("-----------------------------------");

queue.Print();