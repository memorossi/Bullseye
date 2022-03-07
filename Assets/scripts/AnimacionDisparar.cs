using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionDisparar : MonoBehaviour
{

    private Animator anim;

    public float timeToAnimate = 1;
    private float timeLeft;

    // posicion en Z del player
    float posicionZ = 0;
    float posicionNuevaZ = -7.29f;

    //posicion en X del player
    float posicionX = 0;
    float posicionNuevaX = -1.19f;

     

    bool seMueveAde;
    bool seMueveIzq;
    bool seMueveDer;
    bool seMueveAtras;

    Vector3 sensorMoviemiento;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        sensorMoviemiento = transform.localPosition;
        posicionZ = sensorMoviemiento.z;

        posicionX = sensorMoviemiento.x;

        /*

        if (posicionZ == posicionNuevaZ)
        {
            SetIdle();
        }
        else
        {
            posicionNuevaZ = posicionZ;
   
        }

        if (posicionX == posicionNuevaX)
        {
            SetIdle();
        }
        else
        {
            posicionNuevaX = posicionX;
            
        }
        */

        if (posicionZ == posicionNuevaZ)
        {
            seMueveAde = false;
        }
        else
        {
            seMueveAde = true;
            posicionNuevaZ = posicionZ;

        }

        

        if(posicionX>posicionNuevaX)
        {
            seMueveIzq = true;
        }
        else
        {
            seMueveIzq = false;
            posicionNuevaX = posicionX;
        }


        if (posicionX < posicionNuevaX)
        {
            seMueveDer = true;
        }
        else
        {
            seMueveDer = false;
            posicionNuevaX = posicionX;
        }


        if (seMueveAde == false && seMueveAtras== false && seMueveDer == false && seMueveIzq == false)
        {
            SetIdle();
        }




        //Temporizador();

        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeAnimationValue();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("walkLeft", true);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("walkRight", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("walkBack", true);
        }


    }
    void ChangeAnimationValue()
    {
        anim.SetBool("walk", true);
    }

    void SetIdle()
    {
        anim.SetBool("walk", false);
        anim.SetBool("walkBack", false);
        anim.SetBool("walkLeft", false);
        anim.SetBool("walkRight", false);
    }


    void ResetTimer()
    {
        timeLeft = timeToAnimate;
    }
    private void Temporizador()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            ResetTimer();
            anim.SetBool("walk", false);
        }
    }
}
