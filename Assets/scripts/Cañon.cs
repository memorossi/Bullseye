using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{

    public GameObject prefabBala;
    public Transform posicionInicial;
    public int damage = 100;
    public float speed = 1f;

    public float timeToAnimateShoot=2;
    private float timeLeft;

    private Animator anim;



    Rigidbody rb;
    public float forceToAdd = 1000;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        ResetTimer();
        Debug.Log("Bienvenido! \n Cambiar de Camara: C ");
        Debug.Log("Aumentar tamaño de balas: M  \n Disparar: Espacio \n Moverte: WASD");
    }

    void ResetTimer()
    {
        timeLeft = timeToAnimateShoot;
    }

    private void Temporizador()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            ResetTimer();
            anim.SetBool("Disparar", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Temporizador();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Disparar();
            ChangeAnimationValue();
            
        }
        Temporizador();
    }


    public void Disparar()
    { 
       GameObject bullet = Instantiate(prefabBala, posicionInicial.position , posicionInicial.rotation) as GameObject;
       rb = bullet.GetComponent<Rigidbody>();
       rb.AddForce(Vector3.forward  * forceToAdd);
        Debug.Log("Disparo");
       
     }

    private void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(moveHorizontal, 0, moveVertical) *Time.deltaTime * speed;
    }

    void ChangeAnimationValue()
    {
        anim.SetBool("Disparar", true);
        ResetTimer();
    }
}
