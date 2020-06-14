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

        private Node begin;

        private Node end;

        private Node current;

        public LinkList()
        {
            begin = current = end = null;
        }

        public void Begin()
        {
            current = begin;
        }

        public void Next()
        {
            current = current.Next;
        }

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