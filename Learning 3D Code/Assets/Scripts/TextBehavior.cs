using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    private Text lable;
    public IntData numberData;
    
    // Start is called before the first frame update
    void Start()
    {
        lable = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lable.text = numberData.value.ToString();
    }
}
