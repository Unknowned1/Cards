using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool isEnemyturn_var;
    int timer;

    // Start is called before the first frame update
    void Start()
    {
        isEnemyturn_var = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;

        if (isEnemyturn_var == true)
        {
            IsEnemyTurn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        isEnemyturn_var = GameObject.Find("coin").GetComponent<Coin>().enemy_turn;
        if (isEnemyturn_var == true)
        {
            IsEnemyTurn();
        }
        // if is enemy turn, IsEnemyTurn
    }

    public void IsEnemyTurn()
    {
        Debug.Log("Is enemy turn");
    }
}
