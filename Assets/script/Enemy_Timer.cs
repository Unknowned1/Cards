using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Timer : MonoBehaviour
{ 
    public Text enemy_timer_txt;
    string enemy_timer_str;
    float enemy_timer_value;
    public bool isEnemyTurn;


    // Start is called before the first frame update
    void Start()
    {
        enemy_timer_txt = GetComponent<Text>();
        enemy_timer_str = enemy_timer_txt.text;
        enemy_timer_value = 10;

        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        Debug.Log(isEnemyTurn + "from player timer script");

        startEnemyTimer();

    }

    // Update is called once per frame
    void Update()
    {
        // include an if
        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn; // sennò non legge la variabile il bastardo
        startEnemyTimer();
    }

    public void startEnemyTimer()
    {
        if (isEnemyTurn)
        {
            Debug.Log("player timer has started ");
            decreaseTimer();
        }
    }

    public void decreaseTimer()
    {
        // if time < 0 so time = 0
        enemy_timer_value -= 1 * Time.deltaTime;
        enemy_timer_txt.text = enemy_timer_str + (int)enemy_timer_value;
    }
}
