using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public TextMesh curSco;
    public GameObject ballPref;
    public Transform paddleObj;

    GameObject paddle;
    GameObject ball;
    int score;
    Vector3 Paddpos;

    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        curSco.text = "" + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score += 1;
            paddle = GameObject.FindGameObjectWithTag("paddle");
            Paddpos = new Vector3(paddle.transform.position.x, paddle.transform.position.y, 0);
            ball.transform.position = Paddpos;

           
        }
    }

}