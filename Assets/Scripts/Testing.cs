using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    Vector2 touchPos;
    public GameObject Harvester;

    [System.Obsolete]
    void Start()
    {
       
    }

    [System.Obsolete]
    void Update()
    {
        if (GvrControllerInput.IsTouching == true)
        {
            touchPos = GvrControllerInput.TouchPos;
            if (touchPos.y > 0.9f && Harvester.transform.position.z < 6.5f )
            {
                //Harvester.transform.position += Harvester.transform.forward * Time.deltaTime;
                //Harvester.transform.position += Camera.main.transform.forward * Time.deltaTime;
                Harvester.transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
            }
            else if (touchPos.y < 0.1f && Harvester.transform.position.z > 4.5f)
            {
                //Harvester.transform.position -= Harvester.transform.forward * Time.deltaTime;
                //Harvester.transform.position -= Camera.main.transform.forward * Time.deltaTime;
                Harvester.transform.Translate(Vector3.back * Time.deltaTime , Space.World);
            }
            else if (touchPos.x < 0.1f && Harvester.transform.position.z > 3.5f)
            {
                Harvester.transform.eulerAngles = new Vector3(0, Harvester.transform.eulerAngles.y + 1.5f, 0);
            }
            else if (touchPos.x > 0.9f && Harvester.transform.position.z > 3.5f)
            {
                Harvester.transform.eulerAngles = new Vector3(0, Harvester.transform.eulerAngles.y - 1.5f, 0);
            }

        }
        else
        {
            touchPos.y = 0.1f;
            //print(touchPos);
        }
    }
}
