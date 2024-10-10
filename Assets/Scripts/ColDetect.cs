using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colissionDetector : MonoBehaviour
{
    public int killCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        killCounter++;
        Destroy(gameObject);
        Debug.Log(killCounter);
    }
}
