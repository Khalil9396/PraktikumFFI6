using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{

    public float speed=1000;

    public float speedAmplifier=10;
    float rotationSpeed=40;
    float inputPitch = Input.GetAxis("Pitch");
    float inputYaw = Input.GetAxis("Yawn");
    float inputRoll = Input.GetAxis("Roll");


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

            // this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
           // this.transform.Translate(Vector3.forward * speedAmplifier * Time.deltaTime);
             //this.transform.Translate(Vector3.forward * rotationSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Rotate(Vector3.forward * inputPitch * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                this.transform.Rotate(Vector3.back * inputYaw * speed * Time.deltaTime);


            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.transform.Rotate(Vector3.left * inputYaw * speed * Time.deltaTime);


            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.transform.Rotate(Vector3.right * inputRoll * speed * Time.deltaTime);


            }
            else if (Input.GetKey(KeyCode.F))
            {
                this.transform.Translate(Vector3.right * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.X))
            {
                this.transform.Translate(Vector3.left * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.E))
            {
                this.transform.Translate(Vector3.up * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.Q))
            {
                this.transform.Translate(Vector3.down * speed * Time.deltaTime);

            }
        }

        
    
}
