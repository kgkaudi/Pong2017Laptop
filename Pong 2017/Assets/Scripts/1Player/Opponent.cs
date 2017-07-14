using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour {

    public float paddleSpeed = 1f;
    public Ball ball;

    float timer = 0;
    float width;

    float ballPosition;

    private Vector3 playerPos = new Vector3(10f, 0, 0);

    // Update is called once per frame
    void Update()
    {
        float ballPosz = GameObject.FindGameObjectWithTag("Ball").transform.position.z;
        float dz = ballPosz - transform.position.z;
        float ballPosx = GameObject.FindGameObjectWithTag("Ball").transform.position.x;
        if (ballPosx- transform.position.x > -9)
        {
            float zPos = transform.position.z + (dz * paddleSpeed /** Time.deltaTime*/);
            playerPos = new Vector3(10f, 0, Mathf.Clamp(zPos, -4.25f, 4.25f));
            transform.position = playerPos;
        }
        

        timer++;
        if (timer % 200 == 0 && ball.ballInPlay == true)
        {
            width = Random.Range(.2f, 5f);
            transform.localScale = new Vector3(0.2f, 1f, width);
        }
    }
}
