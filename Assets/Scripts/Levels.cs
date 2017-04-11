using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Levels : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //if the high score for the 1 level is not available disables button to choose 2 level
        if (PlayerPrefs.GetInt("HighScore1", 0) <= 0)
        {
            GameObject.Find("2").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 2 level is not available disables button to choose 3 level
        if (PlayerPrefs.GetInt("HighScore2", 0) <= 0)
        {
            GameObject.Find("3").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 3 level is not available disables button to choose 4 level
        if (PlayerPrefs.GetInt("HighScore3", 0) <= 0)
        {
            GameObject.Find("4").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 4 level is not available disables button to choose 5 level
        if (PlayerPrefs.GetInt("HighScore4", 0) <= 0)
        {
            GameObject.Find("5").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 5 level is not available disables button to choose 6 level
        if (PlayerPrefs.GetInt("HighScore5", 0) <= 0)
        {
            GameObject.Find("6").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 6 level is not available disables button to choose 7 level
        if (PlayerPrefs.GetInt("HighScore6", 0) <= 0)
        {
            GameObject.Find("7").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 7 level is not available disables button to choose 8 level
        if (PlayerPrefs.GetInt("HighScore7", 0) <= 0)
        {
            GameObject.Find("8").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 8 level is not available disables button to choose 9 level
        if (PlayerPrefs.GetInt("HighScore8", 0) <= 0)
        {
            GameObject.Find("9").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 9 level is not available disables button to choose 10 level
        if (PlayerPrefs.GetInt("HighScore9", 0) <= 0)
        {
            GameObject.Find("10").GetComponent<Button>().interactable = false;
        }
        //if the high score for the 10 level is not available disables button to choose 11 level
        if (PlayerPrefs.GetInt("HighScore10", 0) <= 0)
        {
            GameObject.Find("11").GetComponent<Button>().interactable = false;
        }

        //showing the highscores for each level below the button of the level
        GameObject.Find("t1").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore1", 0);
        GameObject.Find("t2").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore2", 0);
        GameObject.Find("t3").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore3", 0);
        GameObject.Find("t4").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore4", 0);
        GameObject.Find("t5").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore5", 0);
        GameObject.Find("t6").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore6", 0);
        GameObject.Find("t7").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore7", 0);
        GameObject.Find("t8").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore8", 0);
        GameObject.Find("t9").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore9", 0);
        GameObject.Find("t10").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore10", 0);
        GameObject.Find("t11").GetComponent<Text>().text += PlayerPrefs.GetInt("HighScore11", 0);
    }

    //methods to load the level
    public void LoadLevel1()
    {
        Application.LoadLevel("Level1");
    }

    public void LoadLevel2()
    {
        Application.LoadLevel("Level2");
    }

    public void LoadLevel3()
    {
        Application.LoadLevel("Level3");
    }

    public void LoadLevel4()
    {
        Application.LoadLevel("Level5");
    }

    public void LoadLevel5()
    {
        Application.LoadLevel("Level6");
    }

    public void LoadLevel6()
    {
        Application.LoadLevel("Level7");
    }

    public void LoadLevel7()
    {
        Application.LoadLevel("Level8");
    }

    public void LoadLevel8()
    {
        Application.LoadLevel("Level9");
    }

    public void LoadLevel9()
    {
        Application.LoadLevel("Level10");
    }

    public void LoadLevel10()
    {
        Application.LoadLevel("Level11");
    }

    public void LoadLevel11()
    {
        Application.LoadLevel("LevelDontEyes");
    }

    //method to return to the main menu
    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
