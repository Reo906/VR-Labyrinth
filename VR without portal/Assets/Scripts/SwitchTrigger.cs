using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    public GameObject element;
    private int lastEnteredSide = 0; // 0: No side entered, 1: Entered front, -1: Entered back

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // Calculate the dot product to check if the player is on the front or back side
            Vector3 v = transform.InverseTransformPoint(other.transform.position);
            //Debug.Log("Enter " + v);
            if (v.z > 0f)
            {
                // Player entered the front side
                lastEnteredSide = 1;
            }
            else
            {
                // Player entered the back side
                lastEnteredSide = -1;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // Calculate the dot product to check if the player is on the front or back side
            Vector3 v = transform.InverseTransformPoint(other.transform.position);
            //Debug.Log("Exit " + v);
            if (lastEnteredSide == 1 && v.z < 0f)
            {
                // Player exited from the opposite side they entered (back side)
                if (element.activeInHierarchy)
                {
                    element.SetActive(false);
                }
                else
                {
                    element.SetActive(true);
                }
            }
            else if (lastEnteredSide == -1 && v.z > 0f)
            {
                // Player exited from the opposite side they entered (front side)
                if (element.activeInHierarchy)
                {
                    element.SetActive(false);
                }
                else
                {
                    element.SetActive(true);
                }
            }
        }
    }
}
