using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int i = 0;
    public int spamCount;
    
    void Start()
    {
        do
        {
            print(i);
            i++;
        } while (i < 10);
    }

    private void Update()
    {
        while (spamCount >= 1)
        {
            print("Disgusting bro! No one wants to eat that stuff!");
        }
    }
}
