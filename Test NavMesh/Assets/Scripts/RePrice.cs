using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RePrice : MonoBehaviour
{
    public List<NavMeshModifierVolume> ScriptName;
   
    public int m_area1;
    public int m_area2;
    public GameObject Obj;
    private Collider Trigg;
 
    void Start()
    {
       Trigg = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Вход");
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
                Trigg.enabled = false;
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
            Invoke("Timer", 5);

        }
    }
    void Timer()
    {
        Trigg.enabled = true;
        Debug.Log("Коллайдер Появился");
    }
    // Update is called once per frame

}
