using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public TextMeshProUGUI winText;
    
    private void OnTriggerEnter(Collider other)
    {
        print("You Win!");
        winText.gameObject.SetActive(true);
    }
}
