using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseGame : MonoBehaviour {
    //creating variables
    private bool _paused;
    private Canvas _canvas;
    private Text _highScore;
    private int _LevelHighScore;
    private Text _conditionalText;
	// Use this for initialization
	void Start () {
        //following commented line of code delete all the highscores
        //PlayerPrefs.DeleteAll();
        //initializing variables
        _paused = false;
        _canvas = GameObject.Find("PauseCanvas").GetComponent<Canvas>();
        _canvas.enabled = false;
        _highScore = GameObject.Find("HighScore").GetComponent<Text>();
        _conditionalText = GameObject.Find("ConditionalText").GetComponent<Text>();
        //equalising timeScale to 1 just to ensure that game will not be paused
        Time.timeScale = 1;
        //enabling resume button as it is disabled if the game is over
        GameObject.Find("Resume").GetComponent<Button>().interactable = true;

        //getting the high score for the current level
        if (Application.loadedLevelName == "Level1") {
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if game is paused do the following
            if (_paused == false)
            {
                //showing high score for current level on the scene object as a text
                _highScore.text = _LevelHighScore.ToString();
                //showing the text game paused if the resume button is active
                if (GameObject.Find("Resume").GetComponent<Button>().interactable == true)
                    _conditionalText.text = "Game Paused";
                Pause();
            }
            //if game is not paused do the following
            else if (_paused == true)
            {
                //if the resume button is active resumes game
                if(GameObject.Find("Resume").GetComponent<Button>().interactable == true)
                    ResumeGame();
            }
        }
    }

    public void RestartLevel()
    {
        //equalizing timeScale to 1
        Time.timeScale = 1;
        //reloads current scene
        Application.LoadLevel(Application.loadedLevel);
    }

    public void ResumeGame()
    {
        //change variable values
        _paused = false;
        _canvas.enabled = false;
        //equalizes timeScale to 1 to unpause game
        Time.timeScale = 1;
    }

    public void Pause()
    {
        //change variable values
        _paused = true;
        _canvas.enabled = true;
        //equalizes timeScale to 0 to pause game
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        //goes to main menu
        Application.LoadLevel("MainMenu");
    }
}
