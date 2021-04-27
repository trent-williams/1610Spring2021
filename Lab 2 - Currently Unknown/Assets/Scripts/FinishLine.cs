using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public UnityEvent finishLineEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        finishLineEvent.Invoke();
    }
}
