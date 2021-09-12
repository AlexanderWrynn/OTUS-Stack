using System;
using System.Collections.Generic;
using System.Linq;

namespace OTUS_Stack
{
    partial class Stack
    {
        //Список для хранения полученных строк
        private List<string> Strings = new List<string>();

        //Свойство возвращает размер списка
        public int Size
        {
            get { return Strings.Count; }
        }

        //Свойство возвращает верхний элемент стэка, если стэк пуст возвращает null
        public string Top
        {
            get
            {
                if (Strings.Count == 0)
                    return null;
                return Strings.Last();
            }
        }

        //Конструктор для ввода неограниченного числа параметров и запись их в стэк
        public Stack(params string[] inputStrings)
        {
            foreach (var singleString in inputStrings)
            {
                Strings.Add(singleString);
            }
        }

        //Метод добавляет элемент в стэк
        public void Add(string str)
        {
            Strings.Add(str);
        }

        //Метод возвращает верхний элемент стэка и удаляет его из списка, выбрасывает исключение
        //если стэк пуст
        public string Pop()
        {
            if (Strings.Count == 0)
                throw new Exception("Стек пустой");

            string lastElement = Strings.Last();
            Strings.RemoveAt(Strings.Count - 1);
            return lastElement;
        }

        //Метод принимает неограниченное число стэков и объединяет их
        public static Stack Concat(params Stack[] stck)
        {
            Stack outputStack = new Stack();
            for (int i = 0; i < stck.Length; i++)
            {
                stck[i].Strings.Reverse();
                foreach (var str in stck[i].Strings)
                {
                    outputStack.Add(str);
                }
            }
            return outputStack;
        }

    }
}
