using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CountDownBehavior : MonoBehaviour
{
    private WaitForSeconds wfsObj;
    private Text countDownLable;
    
    public int number = 3;
    public float holdTime = 1f;
    public string endString = "Go!";
    
    
    IEnumerator Start()
    {
        countDownLable = GetComponent<Text>();
        wfsObj = new WaitForSeconds(holdTime);
        
        while (number > 0)
        {
            countDownLable.text = number.ToString();
            number--;
            yield return wfsObj;
        }

        countDownLable.text = endString;
        yield return wfsObj;
        countDownLable.text = null;
    }
}