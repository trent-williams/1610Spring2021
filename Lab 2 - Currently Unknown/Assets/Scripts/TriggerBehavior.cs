using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerBehavior : MonoBehaviour
{
    public TextMeshProUGUI loseText;
    private void OnTriggerEnter(Collider other)
    {
        print("Game Over");
        loseText.gameObject.SetActive(true);
    }
}
