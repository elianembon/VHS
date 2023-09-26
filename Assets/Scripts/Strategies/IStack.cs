using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Peek();
    bool IsEmpty();
    int Count();
    void Clear();
}
