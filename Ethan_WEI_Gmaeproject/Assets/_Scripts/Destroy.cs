using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public Transform teleportTarget;

    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "food")
        {
            Destroy(other.gameObject);
        }
        Debug.Log("explode" + other.gameObject.name);
    }
}