using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject Player;
    public float warningHeight= 100;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    float flughöhe;


    // Start is called before the first frame update
    void Start()
    {
        textSpeed.text = "speed: 10 km/h";
        textHeight.text = "Alt: 10 m";
         

        flyJoystick = Player.GetComponent<FlyJoystick>();

    }
    // Update is called once per frame
    void Update()
    {
        flughöhe = Player.transform.position.y;
        textHeight.text = "At :" + flughöhe.ToString() + "m";


        textSpeed.text = "speed :" + flyJoystick.speed +"km/h";
         
        if (flughöhe < warningHeight)
        {
            warnImage.SetActive(true);
         }
        else
        {
            warnImage.SetActive(false);
        }

    }

}
