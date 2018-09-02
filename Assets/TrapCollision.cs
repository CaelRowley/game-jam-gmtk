using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public GameObject player1Victory;
    public GameObject player2Victory;
    public GameObject player1Death;
    public GameObject player2Death;

    void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.tag.Equals("Player1"))
        {
            Destroy(collison.gameObject, 0);
            Instantiate(player1Death);
            Invoke("SpawnPlayer2Victory", 3);
        }
        else if (collison.gameObject.tag.Equals("Player2"))
        {
            Destroy(collison.gameObject, 0);
            Instantiate(player2Death);
            Debug.Log("VICTORY 2");
            Invoke("SpawnPlayer1Victory", 3);
        }
    }
    void OnCollisionStay2D(Collision2D collison)
    {
        if (collison.gameObject.tag.Equals("Player1"))
        {
            Destroy(collison.gameObject, 0);
            Instantiate(player1Death);
            Invoke("SpawnPlayer2Victory", 3);
        }
        else if (collison.gameObject.tag.Equals("Player2"))
        {
            Destroy(collison.gameObject, 0);
            Instantiate(player2Death);
            Invoke("SpawnPlayer1Victory", 3);
        }
    }

    void SpawnPlayer1Victory()
    {
        Debug.Log("VICTORY 1");
        Instantiate(player1Victory);
    }

    void SpawnPlayer2Victory()
    {
        Debug.Log("VICTORY 2");
        Instantiate(player2Victory);
    }
}
