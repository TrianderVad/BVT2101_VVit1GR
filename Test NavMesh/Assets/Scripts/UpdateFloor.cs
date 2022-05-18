using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFloor : MonoBehaviour
{
    public GameObject Floor;
    public Color Cvet;
    private Color Cvet2;
    // Start is called before the first frame update
    void Start()
    {
        Cvet2 = Color.cyan;
        
    }
    void Recolor1()
    {
        Floor.GetComponent<Renderer>().material.color = Cvet;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cvet != Cvet2)
        {
            Cvet2 = Cvet;
            Recolor1();
        }
    }
}
