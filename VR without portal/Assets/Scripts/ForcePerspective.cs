using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ForcePerspective : MonoBehaviour
{
    public GameObject orb;
    public GameObject door;
    int angle = 0;
    // Start is called before the first frame update
    void Start()
    {
        //door.transform.eulerAngles = new Vector3(0, -45, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (orb.transform.position[0] > 0.6 && orb.transform.position[0] < 0.8) //-0.7 to -0.9
        {
            if (orb.transform.position[2] > 0.24 && orb.transform.position[2] < 0.28) //-0.7 to -0.9
            {
                door.SetActive(false);
            }
        }*/

        if (orb.transform.position[0] > -12.6 && orb.transform.position[0] < -12.4)
        {
            if (orb.transform.position[2] > 8.8 && orb.transform.position[2] < 9.1) 
            {
                if (angle > -90)
                {
                    angle -= 1;
                    print(angle);
                    door.transform.eulerAngles = new Vector3(0, angle, 0);
                }
                //door.SetActive(false);
            }
        }
        else
        {
            if (angle < 0)
            {
                angle += 1;
                print(angle);
                door.transform.eulerAngles = new Vector3(0, angle, 0);
            }
            //door.SetActive(true);
        }
    }
}
