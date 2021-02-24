using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    private string[] sandwitches = {"Ham and Cheese", "Gyro", "Meatball Sub"};
    private void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            print("Well, I'm surprised. People normally can't handle more than " + i + " of those at a time.");
        }

        foreach (var lunch in sandwitches)
        {
            print("A " + lunch + " sounds great!");
        }

        for (int i = 0; i < sandwitches.Length; i++)
        {
            print(sandwitches[i]);
        }
    }
}
