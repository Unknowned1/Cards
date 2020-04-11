using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Timer1 : MonoBehaviour
{

    public Text player_timer_txt;
    string player_timer_str;
    float player_timer_value;
    public bool isPlayerTurn;


    // Start is called before the first frame update
    void Start()
    {
        player_timer_txt = GetComponent<Text>();
        player_timer_str = player_timer_txt.text;
        player_timer_value = 10;

        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        Debug.Log(isPlayerTurn + "from player timer script");

        startPlayerTimer();

    }

    // Update is called once per frame
    void Update()
    {
        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn; // sennò non legge la variabile il bastardo
        startPlayerTimer();
    }

    public void startPlayerTimer()
    {
        if (isPlayerTurn)
        {
            Debug.Log("player timer has started ");
            decreaseTimer();
        }
    }

    public void decreaseTimer()
    {
        // if time < 0 so time = 0
        player_timer_value -= 1 * Time.deltaTime;
        player_timer_txt.text = player_timer_str + (int)player_timer_value;
    }
}

