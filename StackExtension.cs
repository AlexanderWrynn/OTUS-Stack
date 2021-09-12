
namespace OTUS_Stack
{
    //Расширение класса
    partial class Stack
    {
        //Метод, объединяющий два стэка
        public void Merge (Stack extensionStack)
        {
            extensionStack.Strings.Reverse();
            foreach (var str in extensionStack.Strings)
            {
                Strings.Add(str);
            }
        }
    }
}
