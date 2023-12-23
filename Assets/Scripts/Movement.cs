using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // using https://developer.oculus.com/documentation/unity/unity-ovrinput

public float movementSpeed = 2.0f;
public float rotationSpeed = 45.0f;


void Start()
{

}


void Update()
{

    Vector2 movement = new Vector2(movementSpeed, movementSpeed);
    movement *= OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
    movement *= Time.deltaTime;
    transform.Translate(new Vector3(movement.x, 0.0f, movement.y));

    float rotation = rotationSpeed * Time.deltaTime * OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x;
    transform.Rotate(Vector3.up, rotation, Space.World);
}
}