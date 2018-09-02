using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (player1Score >= 4)
        {
            PlayerPrefs.SetInt("player1Score", 1);
            PlayerPrefs.SetInt("player2Score", 1);
            player1Score = 1;
            player2Score = 1;
            RestartMenu();
        }
        else if (player2Score >= 4)
        {
            PlayerPrefs.SetInt("player1Score", 1);
            PlayerPrefs.SetInt("player2Score", 1);
            player1Score = 1;
            player2Score = 1;
            RestartMenu();
        }

        score = GameObject.Find("TextScore");
        score.GetComponent<Text>().text = player1Score + " - " + player2Score;

        if (player1Score == 1 || player2Score == 1)
        {

        }
        else if (player1Score == 2 || player2Score == 2) {

        }
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

    public void Winner(string lastPlayerVictory) {
        PlayerPrefs.SetString("lastWinner", lastPlayerVictory);
    }

    public void RestartLevel()
    {
        StartCoroutine(Wait());
    }

    public void RestartMenu()
    {
        StartCoroutine(WaitMenu());
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Game - Copy");
    }

    public IEnumerator WaitMenu()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Menu");
    }
}
