// Count++ in `if` & `else` if LinkedList has .Count propery

public void Add(T data)
{
	if (begin == null) //If list is empty
	{
		begin = new Node(data, null); //Set begin to data

		end = begin;
		//Count++
	}
	else //If list isn't empty
	{
		Node temp = new Node(data, null); //Create a temp node

		end.Next = temp; //Set it after the last current node
		end = temp; //Set the last node as the added node
		//Count++
	}
}
