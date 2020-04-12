using UnityEngine;
using UnityEngine.UI;

public class TurnHandler : MonoBehaviour
{
    public GameObject player, enemy, coin;

    public Enemy enemy_script;
    public Player player_script;

    Enemy_Timer et;
    Player_Timer1 pt1;

    bool isEnemyTurn, isYourTurn;
    float enemy_timer_value, your_timer_value;
    string enemy_timer_text, your_timer_text;

    public Text your_timer, enemy_timer;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        enemy_script = (Enemy)enemy.GetComponent(typeof(Enemy));

        player = GameObject.Find("Player");
        player_script = (Player)player.GetComponent(typeof(Player));

        et = GetComponent<Enemy_Timer>();
        pt1 = GetComponent<Player_Timer1>();

        isEnemyTurn = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;
        isYourTurn = GameObject.Find("coin").GetComponent<Coin>().player_turn;

        your_timer_value = GameObject.Find("player_timer").GetComponent<Player_Timer1>().player_timer_value;
        enemy_timer_value = GameObject.Find("enemy_timer").GetComponent<Enemy_Timer>().enemy_timer_value;

        enemy_timer_text = GameObject.Find("enemy_timer").GetComponent<Enemy_Timer>().enemy_timer_str;
        your_timer_text = GameObject.Find("player_timer").GetComponent<Player_Timer1>().player_timer_str;

        enemy_timer_value = GameObject.Find("enemy_timer").GetComponent<Enemy_Timer>().enemy_timer_value;
        your_timer_value = GameObject.Find("player_timer").GetComponent<Player_Timer1>().player_timer_value;

    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemyTurn)
        {
            enemy_script.IsEnemyTurn();
            et.decreaseTimer();
        }
        else {
            player_script.IsMyTurn();
            pt1.decreaseTimer();
        }
    }

    public void turnHandle() {


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
