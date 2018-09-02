using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour {

    public int player1Score;
    public int player2Score;

    GameObject score;

    public static bool created = false;

    // Use this for initialization
    void Awake () {
        LoadRounds();
        if (!created) {
            DontDestroyOnLoad(gameObject);
            created = true;
        }
        //Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(player1Score);
        if (player1Score >= 3)
        {
            Debug.Log("Winner");
            PlayerPrefs.SetInt("player1Score", 0);
            PlayerPrefs.SetInt("player2Score", 0);
            player1Score = 0;
            player2Score = 0;
        }
        else if (player2Score >= 3)
        {
            Debug.Log("Winner2");
            PlayerPrefs.SetInt("player1Score", 0);
            PlayerPrefs.SetInt("player2Score", 0);
            player1Score = 0;
            player2Score = 0;
        }

        score = GameObject.Find("Text");
        score.GetComponent<Text>().text = player1Score + " - " + player2Score;
    }

    private void LoadRounds() {
        if (PlayerPrefs.HasKey("player1Score") && PlayerPrefs.HasKey("player2Score")) {
            player1Score = PlayerPrefs.GetInt("player1Score");
            player2Score = PlayerPrefs.GetInt("player2Score");
        }
    }

    public void SaveRounds()
    {
        PlayerPrefs.SetInt("player1Score" , player1Score);
        PlayerPrefs.SetInt("player2Score", player2Score);

    }

    //    gameRules = GameObject.Find("GameRules");

    //    if (collison.gameObject.GetComponent<PlayerMove>().isPlayerOne)
    //    {
    //        gameRules.GetComponent<GameRules>().player1Score++;
    //        gameRules.GetComponent<GameRules>().SaveRounds();
    //    }
    //    else
    //    {
    //        gameRules.GetComponent<GameRules>().player2Score++;
    //        gameRules.GetComponent<GameRules>().SaveRounds();
    //    }
        
    //    SceneManager.LoadScene("Game - Copy");
}
