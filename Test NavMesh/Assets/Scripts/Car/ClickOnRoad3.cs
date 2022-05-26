using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ClickOnRoad3 : MonoBehaviour
{
    public Circuit circuit;
    public Camera mainCamera;
    public GameObject waypoint;
    public GameObject Parent;
    private GameObject Point;
    private Vector3 PosPoint;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (circuit.waypoints[0] == null)
                {
                    Debug.Log("Pelmen");
                    circuit.waypoints.Clear();
                }
                PosPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                Point = Instantiate(waypoint, PosPoint, Quaternion.identity);
                circuit.waypoints.Add(Point.transform);
            }
        }

    }
}

