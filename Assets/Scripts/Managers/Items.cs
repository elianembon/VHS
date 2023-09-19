using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour, IItems
{

    private Player _player;

    public int Damage => _damage;
    public int MaxAmount => _maxAmount;

    [SerializeField] protected int _damage;
    [SerializeField] protected int _maxAmount;



    public virtual void Attack()
    {
        Debug.Log("Atack");
    }

    public virtual void Cooldown(float time)
    {
        throw new System.NotImplementedException();
    }

    public bool HasSpecialAccion()
    {
        throw new System.NotImplementedException();
    }

    public virtual void SpecialAccion()
    {
        throw new System.NotImplementedException();
    }
}
