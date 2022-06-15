using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimiendoDiana1 : MovimientoDianas
{
    // Start is called before the first frame update
    void Start()
    {
        leftAndRight = new Vector3(0.018f, 0.0f, -0.8f) * Time.deltaTime;
        ResetTimer();
        timeToChangeDrection = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Temporizador();
    }


}
