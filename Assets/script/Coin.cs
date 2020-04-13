using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int coin_value;
    public bool player_turn, enemy_turn;
    float secondsLeft = 10;

    // Start is called before the first frame update
    void Start()
    {
        coin_value = Random.Range(0, 2);
        

        if (coin_value == 0)
        {
            player_turn = true;
            enemy_turn = false;
            SwitchToEnemy();
        }
        else if (coin_value == 1)
        {
            enemy_turn = true;
            player_turn = false;
            SwitchToPlayer();
        }
        else {
            Debug.Log("vaffanculo");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (coin_value == 0)
        {
            player_turn = true;
            enemy_turn = false;
            SwitchToEnemy();
        }
        else if (coin_value == 1)
        {
            enemy_turn = true;
            player_turn = false;
            SwitchToPlayer();
        }
    }

    IEnumerator SwitchToPlayer() {
        yield return new WaitForSeconds(10);
        player_turn = true;
        enemy_turn = false;
        
    }

    IEnumerator SwitchToEnemy() {
        yield return new WaitForSeconds(10);
        enemy_turn = true;
        player_turn = false;
        secondsLeft = 10;
    }
}
