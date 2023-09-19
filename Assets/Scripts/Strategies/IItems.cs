using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItems
{
    int Damage { get; }
    int MaxAmount { get; }

    void Attack();
    void SpecialAccion();
    bool HasSpecialAccion();

    void Cooldown(float time);
}
