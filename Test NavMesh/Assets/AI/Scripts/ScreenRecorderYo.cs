using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ScreenRecorderYo : MonoBehaviour
{
    private int ctech = 0;
    public Camera Camera;
    public void Capture1()
    {

        RenderTexture activeRenderTexture = RenderTexture.active;
        RenderTexture.active = Camera.targetTexture;

        Camera.Render();
        Debug.Log(Camera.targetTexture.width);
        Texture2D image = new Texture2D(Camera.targetTexture.width, Camera.targetTexture.height);

        image.ReadPixels(new Rect(0, 0, Camera.targetTexture.width, Camera.targetTexture.height), 0, 0);
        image.Apply();
        RenderTexture.active = activeRenderTexture;

        byte[] bytes = image.EncodeToPNG();
        Destroy(image);

        File.WriteAllBytes("Resources/sign.png", bytes);
        
    }

void FixedUpdate()
    {
        ctech++;
        
        if (ctech == 250)
        {

        Capture1();
        ctech = 0;
        }
    }
}

