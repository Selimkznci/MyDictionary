using System;

namespace GenericsIntro
{
    internal class MyDictionary<T1, T2>
    {
        T1[] keysArray;
        T2[] valuesArray;
        public MyDictionary()
        {
            keysArray = new T1[0];
            valuesArray = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempKey = keysArray;
            T2[] tempValue = valuesArray;
            keysArray = new T1[keysArray.Length + 1];
            valuesArray = new T2[valuesArray.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keysArray[i] = tempKey[i];
                valuesArray[i] = tempValue[i];
            }
            keysArray[keysArray.Length - 1] = key;
            valuesArray[valuesArray.Length - 1] = value;
        }
        public void Values(int key)
        {
            for (int i = 0; i < keysArray.Length; i++)
            {
                if (Convert.ToInt32(keysArray[i]) == key)
                {
                    Console.WriteLine(valuesArray[i]);
                }
            }
        }
    }
}