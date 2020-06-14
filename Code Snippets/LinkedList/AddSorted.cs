// Isn't tested

// In Node Class

public void AddSorted(int data)
{
    if (Next == null) 
    {
        Next = new Node(data);
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

// In List Class

public void AddSorted(int data)
{
    if (headNode == null) 
    {
        headNode = new Node(data);
    }
    else if(data < headNode.Data) 
    {
        AddToBeginning(data); // Or just copy AddToBeginning code Here
    }
    else 
    {
        headNode.AddSorted(data);
    }
}
