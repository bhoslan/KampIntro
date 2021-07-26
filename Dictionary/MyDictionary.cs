using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _key; // Gelen anahtar tipinde bir anahtar dizisi oluşturduk.
        private TValue[] _value; //Gelen değer tipinde bir değer dizisi oluşturduk.

        public MyDictionary() //Contsructor oluşturduk
        {
            _key = new TKey[0]; //Anahtar dizisinin ilk elemanına bir adres atadık
            _value = new TValue[0]; //Değer dizisinin ilk elemanına bir adres atadık. 
        }

        public void Add(TKey keys, TValue values) //Add metodunu oluşturduk
        {
            TKey[] tempKey = _key; //Anahtar dizisi her newlendiğinde elemanları kaybolduğundan elemanlarını atamak için 
            TValue[] tempValue = _value; // ... geçici bir dizi oluşturduk. Aynısını değer dizisi içinde yaptık.

            _key = new TKey[_key.Length + 1]; //Dizi dinamik bir dizi olacağından her eleman eklemesinde dizinin boyutunu bir arttırdık
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i]; //Anahtar dizisinin elemanlarını geçici diziye atadık.
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                _value[i] = tempValue[i];
            }
            _key[_key.Length - 1] = keys; //Yeni gelen elemanı genişlettiğimiz dizinin son elemanına koyduk
            _value[_value.Length - 1] = values;
        }
    }
}
