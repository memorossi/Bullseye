using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    //public float velocidad = 0.5f;
     

  
    public AudioSource sonidoCrecimiento;

    //public float forceToAdd = 1000;
    //Rigidbody rb;
    //public Transform posicionEnemigo;
 
    public float timeToDisappear;
    private float timeLeft;

    private int escalaActual=1;
    
    

    // Start is called before the first frame update
    void Start()
    {

        //rb = rb.GetComponent<Rigidbody>();
        //posicionEnemigo = GameObject.Find("diana").GetComponent<>
        //rb.AddForce( Vector3.forward * forceToAdd);

        //rb.AddForce(transform.forward * forceToAdd);

        ResetTimer();
    }

    void ResetTimer()
    {
        timeLeft = timeToDisappear;
    }

    private void Temporizador()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft<= 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*posicion = transform.localPosition;
        posicion.z += velocidad;
        transform.localPosition = posicion;
        posicion += direccion * velocidad;
        */


        Escala();
        Temporizador();
    }

    void Escala()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            transform.localScale = new Vector3(escalaActual * 2, escalaActual * 2, escalaActual * 2);
            escalaActual *= 2;
            sonidoCrecimiento.Play();
        }
    }

    

}
