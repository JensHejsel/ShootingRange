using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameBehavior : MonoBehaviour
{
    public GameObject target;
    public bool gameStarted;
    float time;
    public Text shotsHitTxt;
    public Text shotsMissedTxt;
    public Text scoreTxt;
    public Text pressETxt;
    public Text timeTxt;
    public int numberOfShotsHit;
    public int numberOfShotsMissed;
    public int score;

    void Update()
    {
        //Counts down if the time is above 0.
        if (time > 0)
        {
            time -= Time.deltaTime;
            timeTxt.text = "Time left: " + (int)time;
        }

        //Stops the game if time hits 0
        else
        {
            gameStarted = false;
            pressETxt.text = "Press E to start the game";
            target.SetActive(false);
        }

        //Starts the game if a game isn't already started when the user presses "E"
        if (Input.GetKeyDown(KeyCode.E) && gameStarted == false)
        {
            pressETxt.text = "";
            gameStarted = true;
            startTheGame();
        }
    }
    void startTheGame()
    {
        //Resets all stats to their initial value and starts a fresh game.
        time = 30;
        numberOfShotsHit = 0; 
        numberOfShotsMissed = 0;
        shotsHitTxt.text = "Shots hit: 0";
        shotsMissedTxt.text = "Shots missed: 0";
        scoreTxt.text = "Score: 0";
        score = 0;
        gameStarted = true;

        //Activates target and spawns it at a random position within the room.
        target.SetActive(true);
        target.transform.position = new Vector3(Random.Range(2, -8), Random.Range(3, 6), Random.Range(-12, -18));
    }
}
