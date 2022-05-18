using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RePrice : MonoBehaviour
{
    public List<NavMeshModifierVolume> ScriptName;
    /*public NavMeshModifierVolume ScriptName1;
    //public NavMeshModifierVolume ScriptName2;
    public NavMeshModifierVolume ScriptName3;
    public NavMeshModifierVolume ScriptName4;
    public NavMeshModifierVolume ScriptName5;
    public NavMeshModifierVolume ScriptName6;
    public NavMeshModifierVolume ScriptName7;
    public NavMeshModifierVolume ScriptName8; */
    public int m_area1;
    public int m_area2;
    public GameObject Obj;

    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            for(int i = 0; i < ScriptName.Count; i++)
            {
                if(i % 2 == 0)
                {
                    ScriptName[i].area = m_area1;
                }
                else
                {
                    ScriptName[i].area = m_area2;
                }
            }
            
            /*if (ScriptName1 && ScriptName2)
            {
                ScriptName1.area = m_area1;
                ScriptName2.area = m_area2;
            }
            if (ScriptName3 && ScriptName4)
            {
                
            }
            */
            Obj.GetComponent<NavMeshSurface>().BuildNavMesh();
        }
    }

    // Update is called once per frame
    
}
