using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Timeline;
using UnityEngine;

public class DrivingControls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50.0f;
    public float turnSpeed = 50.0f;
    void Start()
    {
    
        


    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float movementForward = vertical * speed * Time.deltaTime;
        float movementSide = horizontal * turnSpeed * Time.deltaTime;
        Transform t = gameObject.transform;
        t.Translate (0.0f, 0.0f, movementForward);
        t.Rotate (0.0f, movementSide, 0.0f);

    }
}
