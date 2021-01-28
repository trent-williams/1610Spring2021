using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    private float coffeTemperature = 85.0f;
    private float hotLimitTemperature = 70.0f;
    private float coldLimitTempterature = 40.0f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the cofee's temperature is greater than the hottest drinking temperature...
        if (coffeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee tempertaure is less than the coldest drinking temperture...
        else if (coffeTemperature < coldLimitTempterature)
        {
            print("Coffee is too cold.");
        }
        // If it neither of those then...
        else
        {
            // ... do this
            print("Coffee is just right.");
        }
    }
}
