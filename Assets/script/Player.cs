using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public bool isMyturn_var;
    private bool atk_interactable;
    private bool shield_interactable;
    private bool health_interactable;
    public Button atk_button, shield_btn, health_btn;

    // Start is called before the first frame update
    void Start()
    {
        isMyturn_var = GameObject.Find("coin").GetComponent<Coin>().player_turn;

        atk_button = GameObject.Find("buttonCartaAttacco").GetComponent<Button>();
        shield_btn = GameObject.Find("buttonCartaDifesa").GetComponent<Button>();
        health_btn = GameObject.Find("buttonCartaVita").GetComponent<Button>();

        atk_interactable = GameObject.Find("buttonCartaAttacco").GetComponent<Button>().interactable;
        shield_interactable = GameObject.Find("buttonCartaDifesa").GetComponent<Button>().interactable;
        health_interactable = GameObject.Find("buttonCartaVita").GetComponent<Button>().interactable;
    }

    void Update()
    {
        isMyturn_var = GameObject.Find("coin").GetComponent<Coin>().player_turn;
        if (isMyturn_var == true)
        {
            IsMyTurn();
        }
        else if (isMyturn_var == false){
            
            IsNotMyTurn();
            StartCoroutine("WaitYourTurn");
        }
    }

    public void IsMyTurn() {

        
        if (isMyturn_var == true)
        {
            Debug.Log("Is my turn");
            GameObject.Find("buttonCartaAttacco").GetComponent<Button>().interactable = true;
            GameObject.Find("buttonCartaDifesa").GetComponent<Button>().interactable = true;
            GameObject.Find("buttonCartaVita").GetComponent<Button>().interactable = true; 
        }
        
    }

    public void IsNotMyTurn()
    {
        if (isMyturn_var == false)
        {
            GameObject.Find("buttonCartaAttacco").GetComponent<Button>().interactable = false;
            GameObject.Find("buttonCartaDifesa").GetComponent<Button>().interactable = false;
            GameObject.Find("buttonCartaVita").GetComponent<Button>().interactable = false;
        }
    }

    IEnumerator WaitYourTurn()
    {
        
        yield return new WaitForSeconds(10);
        IsMyTurn();
    }
}
