using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Script : MonoBehaviour
{
    public GameObject player;

    [System.Obsolete]
    private void Start()
    {
        Vector2 touchPos = GvrControllerInput.TouchPos;
        print(GvrControllerInput.TouchPos);
    }

    [System.Obsolete]
    void Update()
    {
        ////if (GvrControllerInput.TouchDown == true)
        ////{
        //    if (GvrControllerInput.TouchPos.y < 0.1f)
        //    {
        //        Debug.Log("In IF");
        //    //print(GvrControllerInput.TouchPos);
        //    //player.transform.position += Camera.main.transform.forward * Time.deltaTime;
        //    player.transform.position += player.transform.forward * Time.deltaTime;
        //    }
        ////}
        //else
        //{
        //    Debug.Log("In Else");
        //    Debug.Log(GvrControllerInput.TouchPos);
        //}
        if (GvrControllerInput.IsTouching == true)
        {
            if (GvrControllerInput.TouchPos.y < 0.1f)
            {
                player.transform.position += player.transform.forward * Time.deltaTime;
                print(GvrControllerInput.TouchPos);
            }
        }
        else
        {
            Debug.Log(GvrControllerInput.TouchPos);
            //GvrControllerInput.GetDevice(GvrControllerHand.Dominant).TouchPos;
            
        }
    }
}
