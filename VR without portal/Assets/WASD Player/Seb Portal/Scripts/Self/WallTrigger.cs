using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wall;
    // Update is called once per frame
    void OnTriggerEnter(Collider collider) 
    {
        if (collider.CompareTag("Player"))
        {
            if (wall.activeInHierarchy)
            {
                wall.SetActive(false);
            }
            else
            {
                wall.SetActive(true);
            }
        }
    }
}
