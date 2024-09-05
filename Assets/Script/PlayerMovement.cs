using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float fwdSpeed;
    public float slideSpeed;

    public int roadWidth;

    public Vector3 startPosition;
    public Vector3 endPosition;
    public Vector3 offsetPosition;
    public Vector3 clickScreenPosition;
    public Vector3 clickPlayerPosition;

    public Rigidbody rb;
    public CrowdPlacement crowdPlacement;

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
        //float xPos = Mathf.Clamp(transform.position.x, -4.7f, 4.7f);
        //transform.position = new Vector3(xPos, 0, transform.position.z);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    startPosition = Input.mousePosition;
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    endPosition = Input.mousePosition;
        //    if (endPosition.x > startPosition.x + offsetPosition.x)
        //    {
        //        print("right");
        //        //rb.AddForce(new Vector3(slideSpeed,0,0));
        //        //rb.velocity = new Vector3(slideSpeed*Time.deltaTime, 0, 0);
        //        transform.position += new Vector3(slideSpeed, 0);
        //    }
        //    if (endPosition.x < startPosition.x - offsetPosition.x)
        //    {
        //        print("left");
        //        //rb.velocity = new Vector3(-slideSpeed * Time.deltaTime, 0, 0);
        //        transform.position -= new Vector3(slideSpeed, 0);

        //    }
        //}
        if (Input.GetMouseButtonDown(0))
        {
            clickScreenPosition = Input.mousePosition;
            clickPlayerPosition = transform.position;
        }    
        else if (Input.GetMouseButton(0))
        {
            float xScreenDifference = Input.mousePosition.x - clickScreenPosition.x;
            xScreenDifference /= Screen.width;
            xScreenDifference *= slideSpeed;

            Vector3 position = transform.position;
            position.x = clickPlayerPosition.x + xScreenDifference;
            position.x = Mathf.Clamp(position.x,-roadWidth / 2 + crowdPlacement.CrowdRadius(), roadWidth/2 - crowdPlacement.CrowdRadius());
            transform.position = position;
        }
    
    }
}