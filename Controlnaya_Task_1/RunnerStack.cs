class Program
{
    static void Main()
    {
        //Пример использования MyStack
        MyStack stack = new MyStack(5);

        //Добавление элементов в стек
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        //Удаление элементов из стека
        Console.WriteLine(stack.Pop()); //Выведет 3
        Console.WriteLine(stack.Pop()); //Выведет 2
        Console.WriteLine(stack.Pop()); //Выведет 1

        //Попытка удалить из пустого стека
        Console.WriteLine(stack.Pop()); //Выведет сообщение об ошибке

        //Добавление элементов после удаления
        stack.Push(4);
        stack.Push(5);

        //Попытка добавить в полный стек
        stack.Push(6); //Выведет сообщение об ошибке
    }
}
