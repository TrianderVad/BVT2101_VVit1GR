using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public KeyCode Key1 = KeyCode.Alpha1;
    public KeyCode Key2 = KeyCode.Alpha2;
    public int kostil = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Key1)){
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            kostil = 1;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(Key2))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            kostil = 2;
            Cursor.visible = false;
        }
    }
}
