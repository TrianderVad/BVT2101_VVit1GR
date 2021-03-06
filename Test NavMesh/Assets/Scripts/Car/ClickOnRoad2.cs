using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ClickOnRoad2 : MonoBehaviour
{
    public SwitchCamera switchCamera;
    public Circuit circuit;
    public Cart cart;
    public Camera mainCamera;
    public GameObject waypoint;
    public GameObject Parent;
    public GameObject Mashina;
    private GameObject Point;
    private GameObject FP;
    private Vector3 PosPoint;

    private AIController2 AIController2;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        /*
        cart.maxSpeed = 0;
        AIController2.agent.speed = 0;
        FP = Instantiate(waypoint, new Vector3(Mashina.transform.position.x + 10f, Mashina.transform.position.y, Mashina.transform.position.z), Quaternion.identity);
        circuit.waypoints.Add(FP.transform);
        */

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && switchCamera.kostil == 1)
        {
            Debug.Log("??? ??");
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if(Point != null)
                {
                    Destroy(Point);
                }
                if (cart.maxSpeed == 0)
                {
                    Destroy(FP);
                    cart.maxSpeed = 15;
                    AIController2.agent.speed = 7.5f;
                }
                circuit.waypoints.Clear();
                PosPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                Point = Instantiate(waypoint, PosPoint, Quaternion.identity);
                circuit.waypoints.Add(Point.transform);          
            }
        }

    }
}
