using System.Text;

namespace Lesson_9
{
    internal class DIagonalMatrix
    {
        private int[] _values;
        public DIagonalMatrix(int[] values)
        {
            _values = new int[values.Length];
            values.CopyTo(_values, 0);
        }

        public int this [int i, int j] {    // индексатор
            get { 
                return i == j ? _values[i] : 0; 
            } 
            set { 
                if(i == j)
                {
                    _values[i] = value;
                }
            } 
        }
        public override string ToString()
        {
            string result = string.Empty;
            StringBuilder stringBuilder = new(result);

            for (int i = 0; i < _values.Length; i++)
            {
                for (int j = 0; j < _values.Length; j++)
                {
                    if(i == j)
                    {
                        stringBuilder.Append(_values[i]);
                    }
                    else
                    {
                        stringBuilder.Append("0");
                    }
                }

                stringBuilder.Append(Environment.NewLine);
            }

            return stringBuilder.ToString();
        }
        public override bool Equals(object obj)
        {
            //var matrix = obj as DIagonalMatrix;   // вариант с as
            //if (matrix == null)
            //{
            //    return false;
            //}

            DIagonalMatrix matrix;

            if (obj is DIagonalMatrix)
            {
                matrix = (DIagonalMatrix)obj;
            } else
            {
                return false;
            }

            if (_values.Length != matrix._values.Length)
            {
                return false;
            }

            for (int i = 0; i < _values.Length; i++)
            {
                if(_values[i] != matrix._values[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 0;

                for (int i = 0; i < _values.Length; i++)
                {
                    hashCode += _values[i].GetHashCode() * i.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}
