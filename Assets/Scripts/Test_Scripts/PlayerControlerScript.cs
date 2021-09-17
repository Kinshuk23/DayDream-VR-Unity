using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerScript : MonoBehaviour
{
    public GameObject player;
    public float movespeed = 10f;
    public float moveangle = 2f;
   

    [System.Obsolete]
    void Update()
    {
        //player.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movespeed );
        //player.transform.Rotate(0,Input.GetAxis("Horizontal")* Time.deltaTime * moveangle,0);

        //if (GvrControllerInput.ClickButton)
        //{
        //    Debug.Log("Hi");
        //}

        //if (GvrControllerInput.IsTouching == true)
        //{
        //    Debug.Log("Touching");
        //    player.transform.position += player.transform.forward * 0.5f;
        //}

      //  print(GvrControllerInput.TouchPos);

        if (GvrControllerInput.TouchPos.y < 0.1f)
        {
            print(GvrControllerInput.TouchPos);
            player.transform.position += player.transform.forward *Time.deltaTime;
        }

        else if (GvrControllerInput.TouchPos.y > 0.9f)
        {
            print(GvrControllerInput.TouchPos);
            player.transform.position -= player.transform.forward * Time.deltaTime;
        }

        if (GvrControllerInput.TouchPos.x < 0.1f)
        {
            print(GvrControllerInput.TouchPos);
            //player.transform.rotation = new Quaternion(player.transform.rotation.x, player.transform.rotation.y - 1f, player.transform.rotation.z, player.transform.rotation.w);
            //player.transform.rotation = new Quaternion(player.transform.rotation.x, player.transform.rotation.y, player.transform.rotation.z, player.transform.rotation.w);
            player.transform.eulerAngles = new Vector3 (0, player.transform.eulerAngles.y - 0.5f, 0);
        }

        if (GvrControllerInput.TouchPos.x > 0.9f)
        {
            print(GvrControllerInput.TouchPos);
            player.transform.eulerAngles = new Vector3(0, player.transform.eulerAngles.y + 0.5f, 0);
        }
    }
}
