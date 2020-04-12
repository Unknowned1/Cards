using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Timer : MonoBehaviour
{ 
    public Text enemy_timer_txt;
    public string enemy_timer_str;
    public float enemy_timer_value;
    public bool isEnemyTurn, isPlayerTurn;

    // Start is called before the first frame update
    void Start()
    {
        enemy_timer_txt = GetComponent<Text>();
        enemy_timer_str = enemy_timer_txt.text;
        enemy_timer_value = 10;
        enemy_timer_txt.text = enemy_timer_str + (int)enemy_timer_value;

        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;

        //startEnemyTimer();
    }

    // Update is called once per frame
    void Update()
    {
        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn; // sennò non legge la variabile il bastardo
        if (isEnemyTurn)
        {
            Debug.Log("enemy timer has started ");
            decreaseTimer();
        }
        else
        {
            StartCoroutine("WaitYourTurn");
        }
    }

    IEnumerator WaitYourTurn()
    {
        yield return new WaitForSeconds(10);
        isEnemyTurn = true;
        startEnemyTimer();
    }

    public void startEnemyTimer()
    {
        if (isEnemyTurn)
        {
            Debug.Log("enemy timer has started ");
            decreaseTimer();
        }
        else
        {
            enemy_timer_txt.text = "Timer = 10";
        }
    }

    public void decreaseTimer()
    {
        // if time < 0 so time = 0
        if (enemy_timer_value > 0 )
        {
            enemy_timer_value -= 1 * Time.deltaTime;
            enemy_timer_txt.text = enemy_timer_str + (int)enemy_timer_value;
        }
        else if (enemy_timer_value <= 0 )
        {
            enemy_timer_value = 10;
            enemy_timer_txt.text = enemy_timer_str + enemy_timer_value;
            
            isPlayerTurn = true;
            isEnemyTurn = false;
        }
    }

    
}
