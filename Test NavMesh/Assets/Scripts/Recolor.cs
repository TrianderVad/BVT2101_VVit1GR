using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolor : MonoBehaviour
{
    public UpdateFloor ScriptName;
    public Color IzmC;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log(1);
            ScriptName.Cvet = IzmC;
        }
       
    }
    


    // Update is called once per frame
    
}
