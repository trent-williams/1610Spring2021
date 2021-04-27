using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
