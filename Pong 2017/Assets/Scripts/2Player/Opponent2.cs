﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent2 : MonoBehaviour {

    public float paddleSpeed = 1f;
    public Ball ball;

    float timer = 0;
    float width;

    private Vector3 playerPos = new Vector3(10f, 0, 0);

    // Update is called once per frame
    void Update()
    {
        float zPos = transform.position.z + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(10f, 0, Mathf.Clamp(zPos, -4.25f, 4.25f));
        transform.position = playerPos;

        timer++;
        if (timer % 200 == 0 && ball.ballInPlay == true)
        {
            width = Random.Range(.2f, 5f);
            transform.localScale = new Vector3(0.2f, 1f, width);
        }
    }
}
