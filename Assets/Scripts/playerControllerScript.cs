using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject sandwich;
    public GameObject armut;
    public float horizontalInput;

    public float speed = 10;

    public int armutCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("armutCoolDown", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -23)
        {
            transform.position = new Vector3(-23,transform.position.y,transform.position.z);
        }
        if (transform.position.x > 23)
        {
            transform.position = new Vector3(23, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right  * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            object value = Instantiate(sandwich, transform.position, sandwich.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.C) && armutCounter >=1 )
        {
            object value = Instantiate(armut, transform.position, armut.transform.rotation);
            armutCounter--;
        }

    }

    public int armutCoolDown()
    {
      return armutCounter++;
        
    }



}
