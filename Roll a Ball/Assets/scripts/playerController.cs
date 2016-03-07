using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	void Update ()
    {
        //updates after every frame of movement
    }
    void FixedUpdate ()
    {
        //updates after every physics movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical")
    }
}
