using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScores : MonoBehaviour {

    public Text PlayerScoreText;
    public GameManager gameManager;
    public Transform SpawnBall;
    public Rigidbody Ball;
    public Transform Player;

    void OnTriggerEnter(Collider other)
    {
        gameManager.addPlayerScore();
        Ball.transform.position = SpawnBall.position;
    }

}
