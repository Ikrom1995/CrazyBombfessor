using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SecondCounter : MonoBehaviour {

    private float _score;
    private float _seconds;
    private TextMesh _secondCounter;
    private int _LevelHighScore;
    private Text _conditionalText;
    // Use this for initialization
    void Start ()
    {
        //equalizing initial score to 60 
        _score = 60;
        _seconds = 0;
        _secondCounter = GameObject.Find("ScoreCount").GetComponent<TextMesh>();

        _conditionalText = GameObject.Find("ConditionalText").GetComponent<Text>();

        if (Application.loadedLevelName == "Level1")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore1");
        }
        else if (Application.loadedLevelName == "Level2")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore2");
        }
        else if (Application.loadedLevelName == "Level3")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore3");
        }
        else if (Application.loadedLevelName == "Level5")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore4");
        }
        else if (Application.loadedLevelName == "Level6")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore5");
        }
        else if (Application.loadedLevelName == "Level7")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore6");
        }
        else if (Application.loadedLevelName == "Level8")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore7");
        }
        else if (Application.loadedLevelName == "Level9")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore8");
        }
        else if (Application.loadedLevelName == "Level10")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore9");
        }
        else if (Application.loadedLevelName == "Level10")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore10");
        }
        else if (Application.loadedLevelName == "LevelDontEyes")
        {
            _LevelHighScore = PlayerPrefs.GetInt("HighScore11");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Mathf.Round(Time.timeSinceLevelLoad) > _seconds)
        {
            //each second 1 will be added to the _seconds variable created
            _seconds++;
            //subtracts 1 from the score each second
            _score -= 1;
        }

        if (_score <= 0)
        {
            //game overs after score = 0
            Canvas _GameOverCanvas = GameObject.Find("PauseCanvas").GetComponent<Canvas>();
            Button _resumeButton = GameObject.Find("Resume").GetComponent<Button>();
            Text _highScoreText = GameObject.Find("HighScore").GetComponent<Text>();

            Time.timeScale = 0;
            _GameOverCanvas.enabled = true;
            _resumeButton.interactable = false;
            _conditionalText.text = "Game Over";
            _highScoreText.text = _LevelHighScore.ToString();
        }
        _secondCounter.text = _score.ToString();
    }
}
