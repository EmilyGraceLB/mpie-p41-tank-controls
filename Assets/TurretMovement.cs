using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed = 50.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 0.0f;
        if(Input.GetKey(KeyCode.Q)) {
            rotation = -turnSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.E)) {
            rotation = turnSpeed * Time.deltaTime;
        }
        Transform t = gameObject.transform;
        t.Rotate(0.0f, rotation, 0.0f);
    }
}
