using System;

class MyStack
{
    private int[] array;
    private int top; //Индекс верхнего элемента стека
    private int capacity; //Максимальная вместимость стека

    public MyStack(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Емкость стека должна быть больше 0.");
        }

        this.capacity = capacity;
        this.array = new int[capacity];
        this.top = -1; // Пустой стек
    }

    public void Push(int item)
    {
        if (top < capacity - 1)
        {
            top++;
            array[top] = item;
        }
        else
        {
            Console.WriteLine("Переполнение стека. Невозможно отправить элемент: " + item);
        }
    }

    public int Pop()
    {
        if (top >= 0)
        {
            int poppedItem = array[top];
            top--;
            return poppedItem;
        }
        else
        {
            Console.WriteLine("Переполнение стека. Невозможно извлечь из пустого стека.");
            return -1; //Значение по умолчанию, можно изменить в зависимости от требований.
        }
    }
}



