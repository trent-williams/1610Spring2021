using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    // Start is called before the first frame update
    private int day = 4;
    
    void Start()
    {
        switch (day)
        {
            case 1:
                print("Monday");
                break;
            case 2:
                print("Tuesday");
                break;
            case 3:
                print("Wednesday");
                break;
            case 4:
                print("Thursday");
                break;
            case 5:
                print("Friday");
                break;
            case 6:
                print("Saturday");
                break;
            case 7:
                print("Sunday");
                break;
            default:
                print("Looking forward to the weekend");
                break;
        }
    }

    void Exercise()
    {
        int day = 2;

        switch (day)
        {
            case 1:
                print("Monday");
                break;
            case 2:
                print("Monday number 2: Groundhogs day");
                break;
            default:
                print("Wait a minute, by is Bill Murray here?");
        }
    }
}
