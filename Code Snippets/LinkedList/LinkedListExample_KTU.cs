    public class LinkList<T> where T : IComparable<T>
    {
        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data, Node next)
            {
                Data = data;
                Next = next;
            }
        }

        /// <summary>
        /// All the time should point to the first element of the list.
        /// </summary>
        private Node begin;
        /// <summary>
        /// All the time should point to the last element of the list.
        /// </summary>

        private Node end;

        /// <summary>
        /// Shouldn't be used in any other methods except Begin(), Next(), Exist() and Get().
        /// </summary>
        private Node current;

        /// <summary>
        /// Initializes a new instance of the LinkList class with empty list.
        /// </summary>
        public LinkList()
        {
            begin = current = end = null;
        }

        /// <summary>
        /// One of four interface methods devoted to loop through a list and get value stored in it.
        /// Method should be used to move internal pointer to the first element of the list.
        /// </summary>
        public void Begin()
        {
            current = begin;
        }

        /// <summary>
        /// One of four interface methods devoted to loop through a list and get value stored in it.
        /// Method should be used to move internal pointer to the next element of the list.
        /// </summary>
        public void Next()
        {
            current = current.Next;
        }

        /// <summary>
        /// One of four interface methods devoted to loop through a list and get value stored in it.
        /// Method should be used to check whether the internal pointer points to the element of the list.
        /// </summary>
        /// <returns>true, if the internal pointer points to some element of the list; otherwise,
        /// false.</returns>
        public bool Exist()
        {
            return current != null;
        }

        public T Get()
        {
            return current.Data;
        }

        public void RemoveCurrent()
        {
            if (current is null)return;

            if (current == begin)
            {
                begin = begin.Next;

                if (begin is null)end = null;

                current.Next = null;

                current = begin;
            }
            else
            {
                Node prev = begin;

                while (prev.Next != current)
                    prev = prev.Next;

                prev.Next = current.Next;

                if (current == end)
                    end = prev;

                current.Next = null;

                current = prev.Next;
            }
        }

        public void Add(T data)
        {
            if (begin == null)
            {
                begin = new Node(data, null);

                end = begin;
            }
            else
            {
                Node temp = new Node(data, null);

                end.Next = temp;
                end = temp;

            }
        }

        public void Sort()
        {
            if (begin == null)
            {
                return;
            }

            bool done = true;

            while (done)
            {
                done = false;

                for (Node d = begin; d != null && d.Next != null; d = d.Next)
                {
                    if (d.Data.CompareTo(d.Next.Data) > 0)
                    {
                        T temp = d.Data;

                        d.Data = d.Next.Data;

                        d.Next.Data = temp;

                        done = true;
                    }
                }
            }
        }

    }