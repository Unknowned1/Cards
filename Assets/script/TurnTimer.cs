using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnTimer : MonoBehaviour
{
    public Text counterText;

    public float seconds, minutes, startTime;

    // Initialization
    void Start()
    {
        counterText = GetComponent<Text>() as Text;
        startTime = Time.time;
        seconds = 0;
    }

    // Update once per frame
    void Update()
    {
        if (seconds <= 10f)
        {
            seconds += 1 * Time.deltaTime;
            counterText.text = string.Format("{0:00}:{1:00}", minutes, seconds);  
        }
        if (seconds >= 10f)
        {
            minutes = 0;
            seconds = 0;
            counterText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
