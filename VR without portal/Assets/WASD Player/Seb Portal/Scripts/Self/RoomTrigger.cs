using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public GameObject firstRoom;
    public GameObject secondRoom;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (firstRoom.activeInHierarchy)
            {
                firstRoom.SetActive(false);
            }
            else
            {
                firstRoom.SetActive(true);
            }
            if (secondRoom.activeInHierarchy)
            {
                secondRoom.SetActive(false);
            }
            else
            {
                secondRoom.SetActive(true);
            }
        }
    }
}
