using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool isMyturn_var;
    int timer;


    // Start is called before the first frame update
    void Start()
    {
        isMyturn_var = GameObject.Find("coin").GetComponent<Coin>().player_turn;

        if (isMyturn_var)
        {
            IsMyTurn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsMyTurn() {

        Debug.Log("Is my turn");
    }
}
