using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    private string[] lunchOptions = {"Ham Sandwitch", "Leftover Pizza", "Chicken", "Bowl of Fruit"};
    private int[] testScores = {10, 15, 27, 35, 49, 98};
    private void Start()
    {
        print(lunchOptions[1]);
        //Should output Leftover Pizza

        lunchOptions[3] = "Fast Food";
        print(lunchOptions[3]);
        //Should output Fast Food
        
        print("You have " + lunchOptions.Length + " options for lunch today.");

        foreach (var list in lunchOptions)
        {
            print(list);
        }

        foreach (var i in testScores)
        {
            print(i + " will be the score randomly assigned to you for the experiment.");
        }
    }
}
