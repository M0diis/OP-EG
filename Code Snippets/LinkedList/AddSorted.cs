// Isn't tested

public void AddSorted(int data)
{
    if (next == null) 
    {
        next = new Node(data);
    }
    else if(data < next.Data) 
    {
        Node temp = new Node(data);
        temp.Next = this.Next;
        this.Next = temp;
    }
    else 
    {
        Next.AddSorted(Data);
    }
}
