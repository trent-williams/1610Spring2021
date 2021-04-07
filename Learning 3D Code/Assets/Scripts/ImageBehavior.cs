using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehavior : MonoBehaviour
{
    private Image img;

    public FloatData dataObj;
    public GameObject gameOverObj, player, replayButton;
    
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (img.fillAmount == 0)
        {
            gameOverObj.SetActive(true);
            player.SetActive(false);
            replayButton.SetActive(true);
        }

        img.fillAmount = dataObj.value;
    }
}
