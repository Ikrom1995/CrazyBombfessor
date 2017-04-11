using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReloadIfContacted : MonoBehaviour {

    private Animator explosion;
    private int _LevelHighScore;
    private Text _conditionalText;
    // Use this for initialization
    void Start() {
        explosion = gameObject.GetComponent<Animator>();
        explosion.enabled = false;
        _conditionalText = GameObject.Find("ConditionalText").GetComponent<Text>();

        //getting the highscore for the curent level
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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            // sets the SpriteRenderer sortingOrder to -2
            GameObject.Find("Player").GetComponent<SpriteRenderer>().sortingOrder = -2;
            //enables animation of the object to which script is attached
            explosion.enabled = true;
            
            //geting canvas object and it's childs from the ui
            Canvas _GameOverCanvas = GameObject.Find("PauseCanvas").GetComponent<Canvas>();
            Button _resumeButton = GameObject.Find("Resume").GetComponent<Button>();
            Text _highScoreText = GameObject.Find("HighScore").GetComponent<Text>();

            //pausing the game
            Time.timeScale = 0;
            //shiws the canvas
            _GameOverCanvas.enabled = true;
            //disables resume button
            _resumeButton.interactable = false;
            //shows game over text
            _conditionalText.text = "Game Over";
            //shows the high score as a text
            _highScoreText.text = _LevelHighScore.ToString();
            //Destroy(GameObject.Find("Player"), 1);
        } else {
            //destroys rockets and bombs ewhen they collide with special objects created for their destruction
            if (gameObject.name == "leftRocket(Clone)" && other.name == "rightRigid")
                Destroy(GameObject.Find("leftRocket(Clone)"));
            else if (gameObject.name == "rightRocket(Clone)" && other.name == "leftRigid")
                Destroy(GameObject.Find("rightRocket(Clone)"));
            else if (gameObject.name == "topBomb(Clone)" && other.name == "leftTopRigid")
                Destroy(GameObject.Find("topBomb(Clone)"));
            else if (gameObject.name == "topBomb2(Clone)" && other.name == "rightTopRigid")
                Destroy(GameObject.Find("topBomb2(Clone)"));

        }

    }

}
