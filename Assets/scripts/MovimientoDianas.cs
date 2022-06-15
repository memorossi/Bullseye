using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDianas : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 posicion;
    protected Vector3 leftAndRight;

    protected float timeToChangeDrection;
    private float timeLeft;

    private bool move = true;

    void Start()
    {
        leftAndRight = new Vector3(0.1f, 0.0f, -3) * Time.deltaTime;
        ResetTimer();
        timeToChangeDrection = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Temporizador();
    }

    protected void Movimiento()
    {
        if(move == true)
        {
            posicion = transform.localPosition;
            posicion += leftAndRight;
            transform.localPosition = posicion;
        }
        else
        {
            posicion = transform.localPosition;
            posicion -= leftAndRight;
            transform.localPosition = posicion;
        }
    }

    protected void Temporizador()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            ResetTimer();
            move = !move;

        }
    }
    protected void ResetTimer()
    {
        timeLeft = timeToChangeDrection;
    }

}
