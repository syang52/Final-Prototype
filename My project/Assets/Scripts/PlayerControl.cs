using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField]
    Vector3 Force;
    [SerializeField]
    KeyCode keyPos;
    [SerializeField]
    KeyCode keyNeg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    
        if (Input.GetKey(keyPos))
            GetComponent<Rigidbody>().velocity += Force;

        if (Input.GetKey(keyNeg))
            GetComponent<Rigidbody>().velocity -= Force;

    }
}
