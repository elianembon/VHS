using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerManager sacarVida;

    private void Start()
    {
        sacarVida = GameObject.FindObjectOfType<PlayerManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")

        {
            sacarVida.LooseLife();        
            
        }
    }
}
