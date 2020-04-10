using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnHandler : MonoBehaviour
{
    public GameObject player, enemy;

    bool isEnemyTurn, isYourTurn;
    int coin;
    float enemy_timer_value, your_timer_value;
    string enemy_timer_text, your_timer_text;

    public Text your_timer, enemy_timer;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
        enemy = GetComponent<GameObject>();

        isEnemyTurn = false;
        enemy_timer_value = 10;
        isYourTurn = false;
        your_timer_value = 10;

        your_timer = GetComponent<Text>();
        enemy_timer = GetComponent<Text>();

        enemy_timer_text = enemy_timer.text;
        your_timer_text = your_timer.text;

        FlipTheCoin();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (coin == 0)
        {
            isEnemyTurn = true;
            Debug.Log("enemy turn " + isEnemyTurn);
            EnemyTurnIsUp();
        }
        else
        {
            isYourTurn = true;
            Debug.Log("enemy turn " + isYourTurn);
            IsYourTurn();
        }
        */
    }

    public void FlipTheCoin()
    {
        Debug.Log(coin + "");
        coin = Random.Range(0, 2);
        if (coin == 0)
        {
            isEnemyTurn = true;
            Debug.Log("enemy turn " + isEnemyTurn);
            //EnemyTurnIsUp();
        }
        else
        {
            isYourTurn = true;
            Debug.Log("enemy turn " + isYourTurn);
            //IsYourTurn();
        }
    }

    public void EnemyTurnIsUp()
    {
        if (isEnemyTurn) {
            enemy_timer_value -= 1 * Time.deltaTime;
            enemy_timer.text = enemy_timer_text + (int) enemy_timer_value;
            
            // implements logic to play
            if (enemy_timer_value == 0)
            {
                enemy_timer_value = 0;
                enemy_timer.text = enemy_timer_text + (int)enemy_timer_value;
                isEnemyTurn = false;
                isYourTurn = true;
                if (isYourTurn)
                {
                    IsYourTurn();
                }
            }
        }
    }

    public void IsYourTurn()
    {
        if (isYourTurn)
        {
            your_timer_value -= 1 * Time.deltaTime;
            your_timer.text = your_timer_text + (int)your_timer_value;
            
            // implements logic to play
            if (your_timer_value == 0)
            {
                your_timer_value = 0;
                your_timer.text = your_timer_text + (int)your_timer_value;
                isEnemyTurn = true;
                isYourTurn = false;
                if (!isYourTurn)
                {
                    EnemyTurnIsUp();
                }
            }
        }
    }
}
