using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBehavior : MonoBehaviour
{
    public TextMeshProUGUI loseText;
    public Button restartButton;
    
    private void OnTriggerEnter(Collider other)
    {
        print("Game Over");
        loseText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
}
