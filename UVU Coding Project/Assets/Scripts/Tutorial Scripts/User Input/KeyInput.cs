using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public GUITexture graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;

    private void Start()
    {
        graphic.texture = standard;
    }

    private void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKey(KeyCode.Space);

        if (down)
        {
            graphic.texture = downgfx;
        }
        else if(held)
        {
            graphic.texture = heldgfx;
        }
        else if (up)
        {
            graphic.texture = upgfx;
        }
        else
        {
            graphic.texture = standard;
        }

        GUIText.text = " " + down + "\n" + held + "\n" + up;
    }
}
