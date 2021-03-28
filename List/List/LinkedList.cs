using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }
        public int this[int index]{
            get
            {
                return Get(index);
            }

            set
            {
                Set(index, value);
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] values)
        {
            Length = values.Length;
            if(Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;
                for(int i = 1; i < Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                } 
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public void Add(int value)
        {
            Insert(value, Length);
        }

        public void InsertInStart(int value)
        {
            Length++;
            Node tmp = new Node(value);
            tmp.Next = _root;
            _root = tmp;

            if(Length == 1)
            {
                _tail = _root;
            }
        }

        public void Insert(int value, int index)
        {
            if(index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                InsertInStart(value);
                return;
            }

            Node current = FindNodeByIndex(index - 1);

            Node tmp = new Node(value);
            tmp.Next = current.Next;
            current.Next = tmp;   
            
            if(index == Length)
            {
                _tail = tmp;
            }

            Length++;
        }

        public void RemoveLast()
        {
            RemoveAt(Length - 1);
        }

        public void RemoveFirst()
        {
            if(Length == 0)
            {
                throw new IndexOutOfRangeException();
            }

            _root = _root.Next;
            Length--;

            if(Length == 0)
            {
                _tail = _root;
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = FindNodeByIndex(index - 1);

            current.Next = current.Next.Next;

            if(index == Length - 1)
            {
                _tail = current;
            }

            Length--;
        }

        public void RemoveLastNodes(int n)
        {
            if(n != 0)
            {
                RemoveNodesAt(n, Length - n);
            }            
        }

        public void RemoveStartNodes(int n)
        {
            if(n < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid n < 0");
            }

            if (n >= Length)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    _root = _root.Next;
                }
            }

            Length -= n;
        }

        public void RemoveNodesAt(int n, int index)
        {
            if(index == 0 || Length - n == 0)
            {
                RemoveStartNodes(n);
                return;
            }

            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid n < 0");
            }

            Node current = FindNodeByIndex(index - 1);

            if (index + n > Length)
            {
                n = Length - index;
                _tail = current;
            }            

            for (int i = 0; i < n; i++)
            {
                current.Next = current.Next.Next;
            }

            Length -= n;
        }

        public int Get(int index)
        {
            if(index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = FindNodeByIndex(index);

            return current.Value;
        }

        public void Set(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = FindNodeByIndex(index);

            current.Value = value;            
        }

        public int FindIndexByValue(int value)
        {
            Node current = _root;
            for(int i = 0; i < Length; i++)
            {
                if(current.Value == value)
                {
                    return i;
                }
                current = current.Next;
            }

            return -1;
        }

        public void Reverse()
        {
            if (Length != 0)
            {
                Node current1 = _root;
                Node current2 = _root;
                Node current3 = current2.Next;

                while (current2.Next != null)
                {
                    current2.Next = current3.Next;
                    current3.Next = current1;
                    current1 = current3;
                    current3 = current2.Next;
                }

                _tail = _root;
                _root = current1;
            }
        }


        public int FindMax()
        {
            if (Length == 0)
                throw new IndexOutOfRangeException();

            Node current = _root;
            int max = current.Value;
            for(int i = 1; i < Length; i++)
            {
                current = current.Next;
                if (max < current.Value)
                {
                    max = current.Value;
                }
                
            }

            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
                throw new IndexOutOfRangeException();

            Node current = _root;
            int min = current.Value;
            for (int i = 1; i < Length; i++)
            {
                current = current.Next;
                if (min > current.Value)
                {
                    min = current.Value;
                }
            }

            return min;
        }

        public int FindIndexOfMin()
        {
            if (Length != 0)
            {
                Node current = _root.Next;
                Node min = _root;
                int indexOfMin = 0;
                for (int i = 1; i < Length; i++)
                {
                    if (min.Value > current.Value)
                    {
                        indexOfMin = i;
                        min = current;
                    }
                    current = current.Next;
                }

                return indexOfMin;
            }

            return -1;
        }

        public int FindIndexOfMax()
        {
            if (Length != 0)
            {
                if (Length == 0)
                    throw new IndexOutOfRangeException();

                Node current = _root.Next;
                Node max = _root;
                int indexOfMax = 0;
                for (int i = 1; i < Length; i++)
                {
                    if (max.Value < current.Value)
                    {
                        indexOfMax = i;
                        max = current;
                    }
                    current = current.Next;
                }

                return indexOfMax;
            }

            return -1;
        }

        public void SortUp()
        {
            LinkedList sortedLinkedList = GetSortedUpList(this);
            _root = sortedLinkedList._root;
            _tail = sortedLinkedList._tail;
        }

        public void SortDown(){
            LinkedList sortedLinkedList = GetSortedDownList(this);
            _root = sortedLinkedList._root;
            _tail = sortedLinkedList._tail;
        }

        public void RemoveFirstElementByValue(int value)
        {
            if(Length == 0)
            {
                return;
            }

            Node current = _root;
            if (current.Value == value)
            {
                _root = _root.Next;
                Length--; 

                if(_root == null)
                {
                    _tail = _root;
                }
            }

            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    if(current.Next == _tail)
                    {
                        _tail = current;
                    }
                    current.Next = current.Next.Next;
                    Length--;
                    break;                    
                }
                current = current.Next;
            }
        }

        public void RemoveAllByValue(int value)
        {
            if (Length == 0)
            {
                return;
            }

            while (_root.Value == value)
            {
                _root = _root.Next;
                Length--;

                if(_root == null)
                {
                    _tail = _root;
                    return;
                }

            }

            Node current = _root;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    if (current.Next == _tail)
                    {
                        _tail = current;
                    }

                    current.Next = current.Next.Next;
                    Length--;
                }

                current = current.Next;

                if (current == null)
                {
                    break;
                }
            }           
        }

        public void AddList(LinkedList insertedList)
        {
            InsertList(insertedList, Length);
        }

        public void InsertListInStart(LinkedList insertedList)
        {
            if (insertedList.Length != 0)
            {
                Node _rootNode = new Node(insertedList._root.Value);
                Node _tailNode = _rootNode;

                Node currentInsertedList = insertedList._root;
                while (currentInsertedList.Next != null)
                {
                    Node insertedNode = new Node(currentInsertedList.Next.Value);
                    _tailNode.Next = insertedNode;
                    _tailNode = _tailNode.Next;
                    currentInsertedList = currentInsertedList.Next;
                }

                _tailNode.Next = _root;
                _root = _rootNode;

                Length += insertedList.Length;
            }
        }

        public void InsertList(LinkedList insertedList, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            if(index == 0)
            {
                InsertListInStart(insertedList);
                return;
            }

            Node currentInsertedList = insertedList._root;
            Node current1List = FindNodeByIndex(index - 1);
            Node current2List = current1List.Next;
            while(currentInsertedList != null)
            {
                Node addedNode = new Node(currentInsertedList.Value);
                current1List.Next = addedNode;
                current1List = current1List.Next;
                currentInsertedList = currentInsertedList.Next;
            }

            current1List.Next = current2List;
            Length += insertedList.Length;
            if(index == Length)
            {
                _tail = current1List;
            }
        }

        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;

            if(Length != list.Length)
            {
                return false;
            }

            Node current1 = list._root;
            Node current2 = _root;

            while(current1 != null)
            {
                if(current1.Value != current2.Value)
                {
                    return false;
                }

                current1 = current1.Next;
                current2 = current2.Next;
            }

            return true;
        }

        public override string ToString()
        {
            string s = "";
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                s += current.Value + " ";
                current = current.Next;
            }
            return s;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private Node FindNodeByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            if(index == Length - 1)
            {
                return _tail;
            }

            Node current = _root;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        private LinkedList GetSortedUpList(LinkedList linkedList)
        {
            if (linkedList.Length == 1)
            {
                return linkedList;
            }

            Node current = linkedList._root;
            LinkedList leftList = new LinkedList();
            LinkedList rightList = new LinkedList();
            for (int i = 0; i < linkedList.Length; i++)
            {
                if (i + 1 == linkedList.Length / 2)
                {
                    rightList._root = current.Next;
                    rightList._tail = linkedList._tail;
                    rightList.Length = linkedList.Length - (i + 1);
                    leftList._root = linkedList._root;
                    leftList._tail = current;
                    leftList._tail.Next = null;
                    leftList.Length = i + 1;
                    leftList = GetSortedUpList(leftList);
                    rightList = GetSortedUpList(rightList);
                    break;
                }

                current = current.Next;
            }

            Node currentLeft = leftList._root;
            Node currentRight = rightList._root;
            LinkedList sortedList = new LinkedList();
            while (currentLeft != null || currentRight != null)
            {
                if (currentLeft == null)
                {
                    while (currentRight != null)
                    {
                        sortedList.Add(currentRight.Value);
                        currentRight = currentRight.Next;
                    }
                    break;
                }

                if (currentRight == null)
                {
                    while (currentLeft != null)
                    {
                        sortedList.Add(currentLeft.Value);
                        currentLeft = currentLeft.Next;
                    }
                    break;
                }

                if (currentLeft.Value < currentRight.Value)
                {
                    sortedList.Add(currentLeft.Value);
                    currentLeft = currentLeft.Next;
                }
                else
                {
                    sortedList.Add(currentRight.Value);
                    currentRight = currentRight.Next;
                }
            }

            return sortedList;

        }

        private LinkedList GetSortedDownList(LinkedList linkedList)
        {
            if (linkedList.Length == 1)
            {
                return linkedList;
            }

            Node current = linkedList._root;
            LinkedList leftList = new LinkedList();
            LinkedList rightList = new LinkedList();
            for (int i = 0; i < linkedList.Length; i++)
            {
                if (i + 1 == linkedList.Length / 2)
                {
                    rightList._root = current.Next;
                    rightList._tail = linkedList._tail;
                    rightList.Length = linkedList.Length - (i + 1);
                    leftList._root = linkedList._root;
                    leftList._tail = current;
                    leftList._tail.Next = null;
                    leftList.Length = i + 1;
                    leftList = GetSortedDownList(leftList);
                    rightList = GetSortedDownList(rightList);
                    break;
                }

                current = current.Next;
            }

            Node currentLeft = leftList._root;
            Node currentRight = rightList._root;
            LinkedList sortedList = new LinkedList();
            while (currentLeft != null || currentRight != null)
            {
                if (currentLeft == null)
                {
                    while (currentRight != null)
                    {
                        sortedList.Add(currentRight.Value);
                        currentRight = currentRight.Next;
                    }
                    break;
                }

                if (currentRight == null)
                {
                    while (currentLeft != null)
                    {
                        sortedList.Add(currentLeft.Value);
                        currentLeft = currentLeft.Next;
                    }
                    break;
                }

                if (currentLeft.Value > currentRight.Value)
                {
                    sortedList.Add(currentLeft.Value);
                    currentLeft = currentLeft.Next;
                }
                else
                {
                    sortedList.Add(currentRight.Value);
                    currentRight = currentRight.Next;
                }
            }

            return sortedList;
        }

    }
}
