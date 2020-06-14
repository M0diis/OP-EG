// Maybe working
public void SelectionSortV1()
{
	for (Node d1 = begin; d1 != null; d1 = d1.Next)
	{
		Node minv = d1;

		for (Node d2 = d1.Next; d1 != null; d2 = d2.Next)
		{
			if (d2.Data.CompareTo(minv.Data) < 0)minv = d2;
		}

		T temp = d1.Data;

		d1.Data = minv.Data;

		minv.Data = temp;
	}
}

// Most likely is working
public void SelectionSortV2()
{
	Node current = begin;

	while (current != null)
	{
		Node min = current;
		Node InnerData = current.Next;

		while (InnerData != null)
		{
			if (InnerData.Data.CompareTo(min.Data) < 0)
			{
				min = InnerData;
			}
			InnerData = InnerData.Next;
		}

		T temp = current.Data;

		current.Data = min.Data;

		min.Data = temp;

		current = current.Next;
	}
}