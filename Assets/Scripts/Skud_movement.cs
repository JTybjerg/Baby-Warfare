using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skud_movement : MonoBehaviour
{
    private float TimeExisted = 0;
    public float TimeBeforeSelfDestruct = 2;
    public float movementspeed = 20;

    void Update()
    {
        TimeExisted += Time.deltaTime;
        transform.position = transform.position + (movementspeed * transform.up * Time.deltaTime);
        if (TimeExisted > TimeBeforeSelfDestruct)
            {
                Destroy(gameObject);
            }    
    }


}
