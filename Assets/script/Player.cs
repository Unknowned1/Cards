using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isMyturn_var;

    // Start is called before the first frame update
    void Start()
    {
        isMyturn_var = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        //Debug.Log(isMyturn_var + " from Player script");
    }

    // Update is called once per frame
    void Update()
    {
        isMyturn_var = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        if (isMyturn_var == true)
        {
            IsMyTurn();
        }
        else {
            StartCoroutine("WaitYourTurn");
        }
    }

    public void IsMyTurn() {

        Debug.Log("Is my turn");
    }

    IEnumerator WaitYourTurn()
    {
        yield return new WaitForSeconds(10);
        IsMyTurn();
    }
}
