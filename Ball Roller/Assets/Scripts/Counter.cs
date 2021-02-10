using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public IntData numberCount;
    public Text counterText;

    private void Start()
    {
        counterText.text = numberCount.value.ToString();
    }

    private void OnTriggerEnter2D()
    {
        numberCount.value += creditValue;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }
}

// GUIText updates to text in the code itself. You may need to ad a using UnityEngine.UI
// GUITexture has also been outdated. Replace it with Image