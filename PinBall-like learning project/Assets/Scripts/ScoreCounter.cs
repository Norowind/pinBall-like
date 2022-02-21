using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoresUI;
    private GameObject failRegister;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        failRegister = GameObject.Find("FailRegister");
        gameOverScript = failRegister.GetComponent<GameOver>();

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoresUI.text = "Score: " + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(gameOverScript.isGameOver != true)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                score += 10;
            }
            else if (collision.gameObject.CompareTag("Pivots"))
            {
                score += 50;
            }
            else if (collision.gameObject.CompareTag("Platform"))
            {
                score += 25;
            }
        }
    }
}//end of class
