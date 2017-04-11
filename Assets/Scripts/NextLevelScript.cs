using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NextLevelScript : MonoBehaviour {
    //creating variables
    int highScore;
    private int _scoreCount;
	public string Level;

	void OnTriggerEnter2D(Collider2D other){
        //saves the high score for each level
        if (Application.loadedLevelName == "Level1")
        {
            //takes the score text from the game, parses to int and saves as a highscore
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            //saves highscore only if the score is higher than current highscore
            if(PlayerPrefs.GetInt("HighScore1", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore1", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level2")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore2", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore2", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level3")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore3", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore3", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level5")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore4", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore4", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level6")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore5", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore5", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level7")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore6", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore6", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level8")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore7", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore7", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level9")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore8", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore8", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level10")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore9", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore9", _scoreCount);
        }
        else if (Application.loadedLevelName == "Level11")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore10", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore10", _scoreCount);
        }
        else if (Application.loadedLevelName == "LevelDontEyes")
        {
            _scoreCount = int.Parse(GameObject.Find("ScoreCount").GetComponent<TextMesh>().text);
            if (PlayerPrefs.GetInt("HighScore11", 0) < _scoreCount)
                PlayerPrefs.SetInt("HighScore11", _scoreCount);
        }
        //loads next level
        Application.LoadLevel (Level);
	}
}
