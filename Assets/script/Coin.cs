using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int coin_value;
    public bool player_turn, enemy_turn;

    // Start is called before the first frame update
    void Start()
    {
        coin_value = Random.Range(0, 2);
        //Debug.Log(coin_value + " from coin script ");

        if (coin_value == 0)
        {
            player_turn = true;
            enemy_turn = false;
        }
        else if (coin_value == 1)
        {
            enemy_turn = true;
            player_turn = false;
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
        }
        else if (coin_value == 1)
        {
            enemy_turn = true;
            player_turn = false;
        }
    }
}
