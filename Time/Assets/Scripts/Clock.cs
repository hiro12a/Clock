using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Text timeText;
    public Text amText;
    public Text secondsText;

    // Update is called once per frame
    void Update()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        string am = System.DateTime.UtcNow.ToLocalTime().ToString("tt");
        string seconds = System.DateTime.UtcNow.ToLocalTime().ToString("ss");
        timeText.text = time;
        amText.text = am;
        secondsText.text = seconds;
    }
}
