using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{
    public float ballVelocity = 3000;

    Rigidbody rb;
    int randInt;
    bool Play = false;


    void Update()
    {



        if (Input.GetMouseButton(0) && Play==false)
        {
            rb = GetComponent<Rigidbody>();
            randInt = Random.Range(1, 3); 

            transform.parent = null;
            Play = true;
            rb.isKinematic = false;
            if (randInt == 1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
            }
            if (randInt == 2)
            {
                rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
            }
        }
    }
}