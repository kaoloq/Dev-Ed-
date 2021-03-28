using System;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set;}
        
        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _array[index];
             }

            set
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }
        
        private int[] _array;


        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }

        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }

        public ArrayList(int[] array)
        {
            Length = array.Length;
            if (array.Length > 10)
            {
                _array = new int[array.Length];
            }
            else
            {
                _array = new int[10];
            }
            for (int i = 0; i < Length; i++)
            {
                _array[i] = array[i];
            }
        }

        public void Add(int value)
        {
            Insert(value, Length);
        }

        public void InsertInStart(int value)
        {
            Insert(value, 0);
        }

        public void Insert(int value, int index)
        {
            if(index > Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if(Length == _array.Length)
            {
                UpSize();
            }

            Length++;

            for(int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = value;
        }

        public void RemoveLast()
        {
            RemoveAt(Length - 1);
        }
         
        public void RemoveFirst()
        {
            RemoveAt(0);
        }

        public void RemoveAt(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Length--;
        }

        public int Get(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }
        
        public int FindIndexByValue(int value)
        {
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                    return i;
            }
            return -1;
        }

        public void Set(int value, int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = value;
        }

        public void Reverse()
        {
            int tmp;

            for(int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - 1 - i];
                _array[Length - 1 - i] = tmp;                
            }
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }

            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }

            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }

            return min;
        }

        public int FindIndexOfMin()
        {
            if (Length == 0)
            {
                return -1;
            }

            int indexOfMin = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[indexOfMin] > _array[i])
                {
                    indexOfMin = i;
                }
            }

            return indexOfMin;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                return -1;
            }

            int indexOfMax = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[indexOfMax] < _array[i])
                {
                    indexOfMax = i;
                }
            }

            return indexOfMax;
        }
        
        public void SortUp()
        {
            SortUpInClass(0, Length);
        }

        
        public void SortDown()
        {
            SortDownInClass(0, Length);
        }

        public void RemoveFirstElementByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAllByValue(int value)
        {
            int[] array = new int[Length];
            int FixedLength = Length;
            for (int i = 0, j = 0; i < FixedLength; i++)
            {
                if(_array[i] == value)
                {
                    Length--;
                    continue;
                }
                array[j++] = _array[i];               
            }

            _array = array;                
            
        }

        public void AddList(ArrayList list)
        {
            InsertList(list, Length);
        }

        public void InsertListInStart(ArrayList list)
        {
            InsertList(list, 0);
        }

        public void InsertList(ArrayList list, int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            UpSize(Length + list.Length);

            for(int i = index; i < Length; i++)
            {
                _array[i + list.Length] = _array[i];
            }

            for(int j = 0; j < list.Length; j++)
            {
                _array[index + j] = list._array[j];   
            }

            Length += list.Length;

        }

        public int[] GetAll()
        {
            return _array;
        }


        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (this.Length != arrayList.Length)
                return false;

            for(int i = 0; i < Length; i++)
            {
                if (_array[i] != arrayList._array[i])
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < Length; i++)
            {
                s += _array[i] + " "; 
            }
            return s;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private bool IsEmpty()
        {
            if (Length == 0)
                return true;
            else
                return false;
        }

        private void UpSize(int newLength = 0)
        {

            if (newLength == 0) { 
                newLength = (int)(_array.Length * 1.33 + 1);
            }
            else
            {
                newLength = (int)(newLength * 1.33 + 1);
            }

            int[] tmpArray = new int[newLength];

            for(int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }


        private void DownSize()
        {
            if ((int)(Length * 0.67 + 1) < 10) {
                Length = 10;
            }
            else
            {
                Length = (int)(Length * 0.67 + 1);
            }         
        }

        private void SortUpInClass(int low, int high)
        {
            Random random = new Random();
            int index = random.Next(low, high);

            if (high - low <= 1)
            {
                return;
            }

            for (int i = low; i < high; i++)
            {
                if (_array[i] >= _array[index] && i < index)
                {
                    int tmp = _array[i];
                    _array[i] = _array[index];
                    _array[index] = tmp;
                    index = i;
                    continue;
                }

                if (_array[i] < _array[index] && i > index)
                {
                    for (int j = i; j > index; j--)
                    {
                        int tmp = _array[j];
                        _array[j] = _array[j - 1];
                        _array[j - 1] = tmp;
                    }
                    index++;
                }
            }
            SortUpInClass(low, index);
            SortUpInClass(index + 1, high);
        }

        private void SortDownInClass(int low, int high)
        {
            Random random = new Random();
            int index = random.Next(low, high);

            if (high - low <= 1)
            {
                return;
            }

            for (int i = low; i < high; i++)
            {
                if (_array[i] <= _array[index] && i < index)
                {
                    int tmp = _array[i];
                    _array[i] = _array[index];
                    _array[index] = tmp;
                    index = i;
                    continue;
                }

                if (_array[i] > _array[index] && i > index)
                {
                    for (int j = i; j > index; j--)
                    {
                        int tmp = _array[j];
                        _array[j] = _array[j - 1];
                        _array[j - 1] = tmp;
                    }
                    index++;
                }
            }
            SortDownInClass(low, index);
            SortDownInClass(index + 1, high);
        }
    }
}
