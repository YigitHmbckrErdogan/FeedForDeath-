using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
           
        }
       if(gameObject.transform.position.z < -15)
        {
            Debug.Log("Game Over!");
        }
        
    }
}
