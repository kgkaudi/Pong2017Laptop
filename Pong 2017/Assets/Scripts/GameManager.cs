using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int playerScore;
    public int opponentScore;
    public Text playerText;
    public Text opponentText;
    public Text winText;

    public void addPlayerScore () {
        playerScore++;
        playerText.text = "Player: " + playerScore;
        if (playerScore == 5)
        {
            winText.text = "Player Wins";
            Invoke("restart", 1);
        }
    }

    public void addOpponentScore()
    {
        opponentScore++;
        opponentText.text = "Opponent: " + opponentScore;
        if (opponentScore == 5)
        {
            winText.text = "Opponent Wins";
            Invoke("restart", 1);
        }
    }
    void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
