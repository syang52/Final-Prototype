using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumControl : MonoBehaviour
{

    Rigidbody rb;
    public int jumpspeed = 0;
    private bool isTouching = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space)) && isTouching == true)
        {
            Vector3 ballJump = new Vector3(0.0f, 6.0f, 0.0f);
            rb.AddForce(ballJump * jumpspeed);
        }

        isTouching = false;
    }
    private void OnCollisionStay()
    {
        isTouching = true;
    }
}
