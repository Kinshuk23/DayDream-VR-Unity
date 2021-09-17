using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    //public GameObject player;
    //Camera camera;

    
    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
        transform.LookAt(target);
        //transform.LookAt(player.transform);
    }
}
