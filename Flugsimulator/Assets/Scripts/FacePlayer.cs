using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject Player;
    float distance;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // player.transform.position + distance * player.transform.forward;
        this.transform.LookAt(Player.transform.position);
    }
}
