using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stack<T> : IStack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new System.InvalidOperationException("La pila está vacía");
        }

        int lastIndex = items.Count - 1;
        T item = items[lastIndex];
        items.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (items.Count == 0)
        {
            throw new System.InvalidOperationException("La pila está vacía");
        }

        int lastIndex = items.Count - 1;
        return items[lastIndex];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public int Count()
    {
        return items.Count;
    }

    public void Clear()
    {
        items.Clear();
    }
}
