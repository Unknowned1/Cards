using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player_Timer1 : MonoBehaviour
{
    public Text player_timer_txt;
    public string player_timer_str;
    public float player_timer_value;
    public bool isPlayerTurn, isEnemyTurn;

    // Start is called before the first frame update
    void Start()
    {
        player_timer_txt = GetComponent<Text>();
        player_timer_str = player_timer_txt.text;
        player_timer_value = 10;
        player_timer_txt.text = player_timer_str + (int)player_timer_value;

        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;
        //Debug.Log(isPlayerTurn + "from player timer script");

        //startPlayerTimer();
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn; // sennò non legge la variabile il bastardo
                                                                                 // startPlayerTimer();
        if (isPlayerTurn)
        {
            Debug.Log("player timer has started ");
            decreaseTimer();
        }
        else {
            StartCoroutine("WaitYourTurn");
            
        }
    }

    IEnumerator WaitYourTurn()
    {
        
        yield return new WaitForSeconds(10);
        isPlayerTurn = true;
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
        if (player_timer_value > 0)
        {
            player_timer_value -= 1 * Time.deltaTime;
            player_timer_txt.text = player_timer_str + (int)player_timer_value;

        }
        if (player_timer_value == 0)
        {
            player_timer_value = 10;
            player_timer_txt.text = player_timer_str + 10;
            isPlayerTurn = false;
            isEnemyTurn = true;
        }
    }

}

