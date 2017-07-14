using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentScores : MonoBehaviour {

    public Text OpponentScoreText;
    public GameManager gameManager;
    public Rigidbody Ball;
    public Transform SpawnBall;
    public Transform Player;

    void OnTriggerEnter(Collider other)
    {
        gameManager.addOpponentScore();
        Ball.transform.position = SpawnBall.position;
    }
}
