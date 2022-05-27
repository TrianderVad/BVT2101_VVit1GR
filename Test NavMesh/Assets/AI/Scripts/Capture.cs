using System.IO;
using UnityEngine;

public class Capture : MonoBehaviour
{
    public int fileCounter;
    public KeyCode screenshotKey;
    public Camera Camera;

    void Update()
    {
        if (Input.GetKeyDown(screenshotKey))
        {
            Capture1();
        }
    }

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
        fileCounter++;
    }
}