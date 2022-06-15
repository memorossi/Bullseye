using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimiendoDiana2 : MovimientoDianas
{
    // Start is called before the first frame update
    void Start()
    {
        leftAndRight = new Vector3(0.055f, 0.0f, -2f) * Time.deltaTime;
        ResetTimer();
        timeToChangeDrection = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Temporizador();
    }
}
