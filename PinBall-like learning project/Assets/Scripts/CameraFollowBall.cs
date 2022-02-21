using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    private GameObject cam;
    private float xPos;
    private float yPos;
    private Vector3 startPos;
    public GameObject ball;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        gameOverScript = GameObject.Find("FailRegister").GetComponent<GameOver>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameOverScript.isGameOver != true)
        {
            transform.position = new Vector3(startPos.x, ball.transform.position.y, startPos.z);
            if (transform.position.y < startPos.y)
            {
                transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
            }
        }
    }
}//end of class
