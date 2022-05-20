using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    float speed = 50;
    float bias = 0.96f;
    float terrainHeightWherewesre= 20;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 moveCamTo = transform.position - transform.forward * 10.0f +Vector3.up * 5.0f;
         Camera.main.transform.position = Camera.main.transform.position *bias + moveCamTo*(1.0f-bias);
         Camera.main.transform.LookAt(transform.position+ transform.forward * 30.0f);
         //terrainHeightWherewesre = Terrain.activeTerrain.SampleHeight(transform.position);

        if(terrainHeightWherewesre > transform.position.y) {

            transform.position = new Vector3(transform.position.x,terrainHeightWherewesre,transform.position.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //speed -= transform.forward.y*Time.deltaTime * 100.0f;
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.left * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.right * speed * Time.deltaTime);

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
        else if (Input.GetKey(KeyCode.Q)) {

            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
         else {

            this.transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
        }


    }
}
