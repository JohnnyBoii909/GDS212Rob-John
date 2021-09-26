using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLogic : MonoBehaviour
{

    public float timeRemaining;
    

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time has run out");
        }
    }
}
