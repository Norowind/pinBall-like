using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public bool isGameOver;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI yourScoreText;
    private ScoreCounter scoreScript;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

        scoreScript = GameObject.Find("Ball").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            currentScore = scoreScript.score;
            yourScoreText.text = "Your score is: " + currentScore;
            yourScoreText.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
        }
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            MakeGameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Ball entered dead zone");
            Destroy(other.gameObject);
            isGameOver = true;
        }
    }

    void MakeGameOver()
    {
        if (isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}//end of class
