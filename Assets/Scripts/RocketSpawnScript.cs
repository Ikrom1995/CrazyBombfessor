using UnityEngine;
using System.Collections;

public class RocketSpawnScript : MonoBehaviour {

    public Transform[] SpawnLocations;
    public GameObject[] SpawnPrefab;

    //spawns left rocket from prefab
    void spawnLeftRocket() {
        GameObject leftRocket = Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    //spawns right rocket from prefab
    void spawnRightRocket() {
        GameObject rightRocket = Instantiate(SpawnPrefab[1], SpawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    //spawns left bomb from prefab
    void spawnTopLeftBomb()
    {
        GameObject TopLeftBomb = Instantiate(SpawnPrefab[2], SpawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    //spawns right bomb from prefab
    void spawnTopRightBomb()
    {
        GameObject TopRightBomb = Instantiate(SpawnPrefab[3], SpawnLocations[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        float spawnTime = 0;
        spawnTime = Mathf.Round(Time.timeSinceLevelLoad);

        //Left Rocket
        //spawns left rocket every 5 seconds
        if (spawnTime != 0 && spawnTime % 5 == 0 && !GameObject.Find("leftRocket(Clone)")) {
            spawnLeftRocket();
            GameObject.Find("leftRocket(Clone)").AddComponent<BoxCollider2D>();
            GameObject.Find("leftRocket(Clone)").GetComponent<BoxCollider2D>().isTrigger = true;
            GameObject.Find("leftRocket(Clone)").AddComponent<ReloadIfContacted>();
        }

        //Right Rocket
        //spawns right rocket every 8 seconds
        if (spawnTime != 0 && spawnTime % 8 == 0 && !GameObject.Find("rightRocket(Clone)"))
        {
            spawnRightRocket();
            GameObject.Find("rightRocket(Clone)").AddComponent<BoxCollider2D>();
            GameObject.Find("rightRocket(Clone)").GetComponent<BoxCollider2D>().isTrigger = true;
            GameObject.Find("rightRocket(Clone)").AddComponent<ReloadIfContacted>();
        }


        //Top Left Bomb
        //spawns left bomb every 9 seconds
        if (spawnTime != 0 && spawnTime % 9 == 0 && !GameObject.Find("topBomb(Clone)"))
        {
            spawnTopLeftBomb();
            GameObject.Find("topBomb(Clone)").AddComponent<BoxCollider2D>();
            GameObject.Find("topBomb(Clone)").GetComponent<BoxCollider2D>().isTrigger = true;
            GameObject.Find("topBomb(Clone)").AddComponent<ReloadIfContacted>();
        }

        //Top Right Bomb
        //spawns right bomb every 9 seconds
        if (spawnTime != 0 && spawnTime % 9 == 0 && !GameObject.Find("topBomb2(Clone)"))
        {
            spawnTopRightBomb();
            GameObject.Find("topBomb2(Clone)").AddComponent<BoxCollider2D>();
            GameObject.Find("topBomb2(Clone)").GetComponent<BoxCollider2D>().isTrigger = true;
            GameObject.Find("topBomb2(Clone)").AddComponent<ReloadIfContacted>();
        }

        //spawned objects are moving if the timeScale is not 0
        if(Time.timeScale != 0)
        {
            if (GameObject.Find("leftRocket(Clone)"))
                GameObject.Find("leftRocket(Clone)").transform.Translate(0.4f, 0, 0);

            if (GameObject.Find("rightRocket(Clone)"))
                GameObject.Find("rightRocket(Clone)").transform.Translate(-0.4f, 0, 0);

            if (GameObject.Find("topBomb(Clone)"))
                GameObject.Find("topBomb(Clone)").transform.Translate(0, -0.3f, 0);

            if (GameObject.Find("topBomb2(Clone)"))
                GameObject.Find("topBomb2(Clone)").transform.Translate(0, -0.3f, 0);
        }

    }


}
