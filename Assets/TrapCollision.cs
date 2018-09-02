using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapCollision : MonoBehaviour
{
    public GameObject player1Victory;
    public GameObject player2Victory;
    public GameObject player1Death;
    public GameObject player2Death;

    private GameObject gameRules;

    private void Start()
    {
        gameRules = GameObject.Find("GameRules");
    }
    void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.tag.Equals("Player1"))
        {
            gameRules.GetComponent<GameRules>().player2Score++;
            gameRules.GetComponent<GameRules>().SaveRounds();
            Destroy(collison.gameObject, 0);
            Instantiate(player1Death);
            Invoke("SpawnPlayer2Victory", 3);
        }
        else if (collison.gameObject.tag.Equals("Player2"))
        {
            gameRules.GetComponent<GameRules>().player1Score++;
            gameRules.GetComponent<GameRules>().SaveRounds();
            Destroy(collison.gameObject, 0);
            Instantiate(player2Death);
            Invoke("SpawnPlayer1Victory", 3);
        }
    }
    void OnCollisionStay2D(Collision2D collison)
    {
        if (collison.gameObject.tag.Equals("Player1"))
        {
            gameRules.GetComponent<GameRules>().player2Score++;
            gameRules.GetComponent<GameRules>().SaveRounds();
            Destroy(collison.gameObject, 0);
            Instantiate(player1Death);
            Invoke("SpawnPlayer2Victory", 3);
        }
        else if (collison.gameObject.tag.Equals("Player2"))
        {
            gameRules.GetComponent<GameRules>().player1Score++;
            gameRules.GetComponent<GameRules>().SaveRounds();
            Destroy(collison.gameObject, 0);
            Instantiate(player2Death);
            Invoke("SpawnPlayer1Victory", 3);
        }
    }

    void SpawnPlayer1Victory()
    {
        Debug.Log("VICTORY 1");
        Instantiate(player1Victory);
        GameObject gameRules = GameObject.Find("GameRules");
        gameRules.GetComponent<GameRules>().RestartLevel();
        //StartCoroutine(gameRules.GetComponent<GameRules>().RestartLevel());
    }

    void SpawnPlayer2Victory()
    {
        Debug.Log("VICTORY 2");
        Instantiate(player2Victory);
        GameObject gameRules = GameObject.Find("GameRules");
        gameRules.GetComponent<GameRules>().RestartLevel();
        //StartCoroutine(gameRules.GetComponent<GameRules>().RestartLevel());
    }
}
