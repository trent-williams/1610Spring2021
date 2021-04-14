using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public Button goFasterButton;
    
    private void OnTriggerEnter(Collider other)
    {
        winText.gameObject.SetActive(true);
        goFasterButton.gameObject.SetActive(true);
    }
}
