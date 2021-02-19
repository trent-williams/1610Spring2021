using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    private int x = 20;
    private int y = 18;
    private int time = 22;

    void Start()
    {
        if (20 > 18)
        {
            print("20 is greater than 18");
        }

        if (x > y)
        {
            print("x is greater than y");
        }

        if (time < 20)
        {
            print("Good day");
        }
        else
        {
            print("Good evening");
        }

        if (time < 10)
        {
            print("Good morning");
        }
        else if (time < 20)
        {
            print("Good day");
        }
        else
        {
            print("Good evening");
        }

        string result = (time < 18) ? "Good day" : "Good evening";
        print(result);
    }

    void Exercise()
    {
        int xX = 50;
        int yY = 50;

        if (xX == yY)
        {
            print("1");
        }
        else if (xX > yY)
        {
            print("2");
        }
        else
        {
            print("3");
        }
    }

    void Experiment()
    {
        // I know that there is no such thing as void Experiment
        int a = 50;
        int b = 10;
        int health = 50;
        bool spam = false;

        if (a > b)
        {
            print("Hey there");
        }
        else
        {
            print("Well, that was a waste of time. Why did I even boot up my mother board?");
        }

        if (spam == false)
        {
            print("I will make a delicious sandwitch!");
            health += 10;
        }
        else if (spam == true)
        {
            print("Why did you have to bring that stuff?");
            health -= 10;
        }
    }
}
