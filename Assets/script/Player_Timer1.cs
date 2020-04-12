using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player_Timer1 : MonoBehaviour
{
    public Text player_timer_txt;
    public string player_timer_str;
    public float player_timer_value;
    public bool isPlayerTurn, isEnemyTurn;
    private float timer_stop;

    // Start is called before the first frame update
    void Start()
    {
        player_timer_txt = GetComponent<Text>();
        player_timer_str = player_timer_txt.text;
        player_timer_value = 10;
        timer_stop = 10;
        player_timer_txt.text = player_timer_str + (int)player_timer_value;
        
        isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;
        isPlayerTurn = true;
        //Debug.Log(isPlayerTurn + "from player timer script");

        //startPlayerTimer();
    }

    // Update is called once per frame
    void Update()
    {
       // isPlayerTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn; // sennò non legge la variabile il bastardo
                                                                                 // startPlayerTimer();
        if (isPlayerTurn)
        {
            Debug.Log("player timer has started ");
            decreaseTimer();
        }
        else {
            waitYourTurnProva();
            
        }
    }

    IEnumerator WaitYourTurn()
    {
        
        yield return new WaitForSeconds(10);
        isPlayerTurn = true;
        startPlayerTimer();
    }

    private void waitYourTurnProva()
    {
         timer_stop -= 1 * Time.deltaTime;

         if (timer_stop <= 0)
        {
             
            isPlayerTurn = true;
            isEnemyTurn = false;
        }

    }

    public void startPlayerTimer()
    {
        if (isPlayerTurn)
        {
            Debug.Log("player timer has started ");
            decreaseTimer();
        }
        else {
            player_timer_txt.text = "Timer = 10" ;
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
        else if (player_timer_value <= 0)
        {
            player_timer_value = 10;
            timer_stop = 10;
            player_timer_txt.text = player_timer_str + player_timer_value;
            
            isPlayerTurn = false;
            isEnemyTurn = true;
        }
    }

}

