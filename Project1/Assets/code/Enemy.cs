﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;

    void Update()
    {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        if (ballObj != null)
        {
            targetPos = Vector3.Lerp(transform.position, ballObj.transform.position, Time.deltaTime * speed);
            playerPos = new Vector3(10, Mathf.Clamp(targetPos.y, -4.5F, 4.5F), 0);
            transform.position = new Vector3(10, playerPos.y, 0);
        }
    }
}