// Count++ in `if` & `else` if LinkedList has .Count propery

public void AddToFront(T data)
{
	if (begin == null) //If List is empty
	{
		begin = new Node(data, null); //Set the begging as data
		//Count++;
	}
	else //If List isn't empty
	{
		Node temp = new Node(data, null); //Create a new temp node

		temp.Next = begin; //Make the first node of list, the next node of the new node

		begin = temp; //Set the new node as the beggining
		//Count++;
	}
}
