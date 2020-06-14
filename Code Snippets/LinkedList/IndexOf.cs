public int IndexOf(type obj) //Find the index of node with given data
{
    Node<type> current = this.HeadNode; //Set the list to start from beggining

    for (int i = 0; i < this.Count; i++)
    {
        if (current.Data.Equals(obj)) //If Node data is equal to given data
        {
            return i; //Return the index
        }

        current = current.Next; //Move to the next node
    }

    return -1; //Return -1 if index was not found
}
