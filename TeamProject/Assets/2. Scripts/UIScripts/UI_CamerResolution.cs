using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CamerResolution : MonoBehaviour
{

    void Start()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scalewidth = ((float)Screen.width / Screen.height) / ((float)16 / 9); // (가로 / 세로)
        float scaleheight = 1f / scalewidth;
        if (scalewidth < 1)
        {
            rect.height = scalewidth;
            rect.y = (1f - scalewidth) / 2f;
        }
        else
        {
            rect.width = scaleheight;
            rect.x = (1f - scaleheight) / 2f;
        }
        camera.rect = rect;
    }

    void OnPreCull() => GL.Clear(true, true, Color.black);
}