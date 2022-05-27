using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MachineNormalYou: MonoBehaviour
{
    public GameObject something;
    void Update()
    {
        ReadString();
    }
   public void ReadString()
   {
       string path = "Resources/Command.txt";
       //Read the text from directly from the test.txt file
       StreamReader reader = new StreamReader(path);
       if (reader.ReadToEnd() == "Speed Limit 70 km/h")
       {

           //something.SetActive(false);
           Debug.Log("70 km/h");
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 30 km/h")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 40 km/h")
       {
            Debug.Log("40 km/h");
            something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 50 km/h")
       {
            Debug.Log("50 km/h");
            something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 60 km/h")
       {
            Debug.Log("60 km/h");
            something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 20 km/h") 
       {

           something.SetActive(false);
           
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 80 km/h")
       {
            Debug.Log("80 km/h");
            something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "End of Speed Limit 80 km/h")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 100 km/h")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Speed Limit 120 km/h")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "No passing")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "No passing for vechiles over 3.5 metric tons")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Right-of-way at the next intersection")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Priority road")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Yield")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Stop")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "No vechiles")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Vechiles over 3.5 metric tons prohibited")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "No entry")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "General caution")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Dangerous curve to the left")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Dangerous curve to the right")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Double curve")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Bumpy road")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Slippery road")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Road narrows on the right")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Road work")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Traffic signals")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Pedestrians")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Children crossing")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Bicycles crossing")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Beware of ice/snow")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Wild animals crossing")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "End of all speed and passing limits")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Turn right ahead")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Turn left ahead")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Ahead only")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Go straight or right")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Go straight or left")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Keep right")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Keep left")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "Roundabout mandatory")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "End of no passing")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }
       else if (reader.ReadToEnd() == "End of no passing by vechiles over 3.5 metric tons")
       {

           something.SetActive(false);
           //Destroy(gameObject);
       }




       //Debug.Log(reader.ReadToEnd());
       reader.Close();
   }
}