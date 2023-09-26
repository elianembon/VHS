using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorManager : MonoBehaviour
{
    private static GeneratorManager instance;

    // Esta ser� la pila compartida por todos los objetos con el script Generator.
    private Stack<GameObject> generatorStack = new Stack<GameObject>();

    private float timer = 0f;
    private float maxTimer = 60f; // Tiempo l�mite
    private bool isTimerActive = false;
    public static GeneratorManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        // Aseg�rate de que solo haya una instancia de GeneratorManager en la escena.
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isTimerActive)
        {
            timer += Time.deltaTime;

            // Si se alcanza el tiempo l�mite, saca el �ltimo elemento de la pila y reinicia el cron�metro.
            if (timer >= maxTimer)
            {
                if (generatorStack.Count() > 0)
                {
                    GameObject lastGenerator = generatorStack.Pop();
                    // Realiza aqu� cualquier acci�n que necesites al sacar el �ltimo generador.
                    Debug.Log("Se ha sacado el �ltimo generador de la pila.");
                }
                ResetTimer();
            }
        }
    }

    public void PushGenerator(GameObject generator)
    {
        // Agrega el generador actual a la pila.
        generatorStack.Push(generator);


        // Si la pila ten�a 0 elementos antes de agregar este generador, inicia el cron�metro.
        if (generatorStack.Count() == 1)
        {
            StartTimer();
        }
    }

    public int GetGeneratorCount()
    {
        return generatorStack.Count();
    }

    private void StartTimer()
    {
        isTimerActive = true;
        timer = 0f;
    }

    private void ResetTimer()
    {
        isTimerActive = false;
        timer = 0f;
    }
}

