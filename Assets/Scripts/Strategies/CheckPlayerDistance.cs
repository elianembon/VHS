using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerDistance : MonoBehaviour
{
    public Transform player;
    public float minimumDistance = 5f;

    private Generator generator; // Referencia al script Generator


    private void Start()
    {
        // Obtén una referencia al script Generator en el mismo GameObject.
        generator = GetComponent<Generator>();
    }
    private void Update()
    {
        // Calcula la distancia entre este objeto y el jugador.
        float distance = Vector3.Distance(transform.position, player.position);

        // Si la distancia es menor que la distancia mínima deseada, habilita la entrada del espacio.
        if (distance < minimumDistance)
        {
            generator.EnableSpaceInput();//llamamos la funcion para activar el space
        }
        else
        {
            generator.DisableSpaceInput();//llamamos a la funcion para desactivar el space
        }
    }
}


