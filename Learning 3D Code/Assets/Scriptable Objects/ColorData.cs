using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ColorData : ScriptableObject
{
    public Color value;

    public void ChangeImageColor(Image imgObj)
    {
        imgObj.color = value;
    }

    public void ChangeMeshRendererColor(MeshRenderer meshObj)
    {
        meshObj.material.color = value;
    }

    public void ChangeSpriteRendererColor(SpriteRenderer spriteObj)
    {
        spriteObj.color = value;
    }
}
