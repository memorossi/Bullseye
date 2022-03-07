using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    public float timeToInstantiate;
    private float timeLeft;

    public GameObject prefabBala;
    public Transform posicionInicial;


    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();

        //Rotar();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        Temporizador();
    }
    void ResetTimer()
    {
        timeLeft = timeToInstantiate;
    }
    private void Temporizador()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            Disparar();
            ResetTimer();
        }
    }

    public void Disparar()
    {
        Instantiate(prefabBala, posicionInicial.position, posicionInicial.rotation);

    }
    public void Rotar()
    {
        transform.rotation = Quaternion.Euler(90, 90, 50);
    }

    void LookAtPlayer()
    {
        transform.LookAt(new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z));
    }
}
