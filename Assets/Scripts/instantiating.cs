using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiating : MonoBehaviour
{
    public float height_offset = 0;
    public string fireButton = "Fire1";
    public float skud_speed = 20;

    public GameObject Skud;
    // Start is called before the first frame update
    void Update()
    {
    if (Input.GetButtonDown(fireButton))
    {
    Vector3 position = transform.position + new Vector3(0, height_offset, 0);
    GameObject skud = Instantiate(Skud, position, Quaternion.FromToRotation(Vector3.up, transform.forward));
    skud.GetComponent<Skud_movement>().movementspeed = skud_speed;
    }


    }

    

      
}
