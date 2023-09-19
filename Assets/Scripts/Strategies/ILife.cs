using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILife
{
    int MaxLife { get; }
    int CurrentLife { get; }

    void TakeDamage(int damage);
    void TakeLife(int RegenLife);
    void Die();
}
