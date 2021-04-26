using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Trigger2DBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerLateEvent;
    public WaitForSeconds wfsObj, wfsLateObj;
    public float holdTime, holdTimeLate;

    private void Start()
    {
        wfsObj = new WaitForSeconds(holdTime);
        wfsLateObj = new WaitForSeconds(holdTimeLate);
        GetComponent<Collider2D>().isTrigger = true;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return wfsObj;
        triggerEnterEvent.Invoke();
        yield return wfsLateObj;
        triggerLateEvent.Invoke();
    }
}
