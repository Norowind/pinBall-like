using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    public float bouncePower;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        playerRb.AddForce((Vector3.right * horizontalInput * speed * Time.deltaTime), ForceMode.Impulse);
        //Debug.Log(" " + horizontalInput);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            collision.rigidbody.AddForce(Vector3.up * bouncePower, ForceMode.Impulse);
        }
    }
}//end of class
