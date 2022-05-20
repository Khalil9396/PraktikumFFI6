using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public ChangeScene MyChangeScene;


    private bool Check45Y()
    {
        Quaternion zielRotation = Quaternion.Euler(0f, 45f, 0f);
        Quaternion aktuelleRotation = Quaternion.Euler(0f, this.transform.rotation.eulerAngles.y, 0f);

        float winkel = Quaternion.Angle(aktuelleRotation, zielRotation);
        bool gleicheRotation = Mathf.Abs(winkel) < 1f;
        if (gleicheRotation)
        {
            print(winkel);
            print("Rotationswinkel gleich!");

            return true;
        }
        else
        {
            print(winkel);
            print("Rotationswinkel nicht gleich!");
            return false;
        }
    }

  


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Check45Y();
    }
}
