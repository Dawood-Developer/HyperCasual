using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float fwdSpeed;
    public float slideSpeed;

    public Vector3 startPosition;
    public Vector3 endPosition;
    public Vector3 offsetPosition;

    public Rigidbody rb;

    private void Update()
    {
        FwdSpeed();
        HorizontalSpeed();
    }
    private void FwdSpeed()
    {
        gameObject.transform.position += Vector3.forward * Time.deltaTime * fwdSpeed;
    }
        private void HorizontalSpeed()
        {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            endPosition = Input.mousePosition;
            if (endPosition.x > startPosition.x + offsetPosition.x)
            {
                print("right");
                //rb.AddForce(new Vector3(slideSpeed,0,0));
                rb.velocity = new Vector3(slideSpeed*Time.deltaTime, 0, 0);
            }
            if (endPosition.x < startPosition.x - offsetPosition.x)
            {
                print("left");
                rb.velocity = new Vector3(slideSpeed * Time.deltaTime, 0, 0);
            }
        }
            
        }
}