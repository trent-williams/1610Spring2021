using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
    }
}
