using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_handler : MonoBehaviour
{
    public static float time;
    public Text timer;
    string timer_text;

    // Start is called before the first frame update
    void Start()
    {
        time = 182;
        timer = GetComponent<Text>();
        timer_text = timer.text;
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;

        timer.text = timer_text + (int)time;
    }
}
