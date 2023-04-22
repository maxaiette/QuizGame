using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ansBtn : MonoBehaviour
{
   public GameObject ansAMain ;
   public GameObject ansAWrong;
   public GameObject ansARight;

    public GameObject ansBMain;
    public GameObject ansBWrong;
    public GameObject ansBRight;

    public GameObject ansCMain;
    public GameObject ansCWrong;
    public GameObject ansCRight;



    public GameObject ansDMain;
    public GameObject ansDWrong;
    public GameObject ansDRight;

    public GameObject ansA;
    public GameObject ansB;
    public GameObject ansC;
    public GameObject ansD;

    public AudioSource correctFX;   
    public AudioSource wrongFx;

    public GameObject crrntScore;
    public int scoreVal;
    
    public int highscoreVal;
    public GameObject bestDisplay;

    void Start()
    {
      highscoreVal = PlayerPrefs.GetInt("BestScore");
      bestDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + highscoreVal;
    }
    void Update()
    {
        crrntScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + scoreVal;
    }
    public void answerA()
    {
        if(QuestionGenerator.actualAnswer == "A")
        {
            ansAMain.SetActive(false);
            ansARight.SetActive(true);
            correctFX.Play();
            scoreVal += 1;

        }
        else 
        {
           ansAMain.SetActive(false) ;
            ansAWrong.SetActive(true);
            wrongFx.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuestion());

    }

    public void answerB()
    {
        if(QuestionGenerator.actualAnswer == "B")
        {
            ansBMain.SetActive(false);
            ansBRight.SetActive(true);
            correctFX.Play();
            scoreVal += 1;

        }
        else
        {
            ansBMain.SetActive(false) ;
            ansBWrong.SetActive(true) ;
            wrongFx.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuestion());
    }

    public void answerC()
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            ansCMain.SetActive(false);
            ansCRight.SetActive(true);
            correctFX.Play();
            scoreVal += 1;

        }
        else
        {
            ansCMain.SetActive(false);
            ansCWrong.SetActive(true);
            wrongFx.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuestion());
    }

    public void answerD()
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            ansDMain.SetActive(false);
            ansDRight.SetActive(true);
            correctFX.Play();
            scoreVal += 1;

        }
        else
        {
            ansDMain.SetActive(false);
            ansDWrong.SetActive(true);
            wrongFx.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(nextQuestion());
    }
    IEnumerator nextQuestion()
    {
        if (highscoreVal < scoreVal)
        {
            PlayerPrefs.SetInt("BestScore",scoreVal);
            highscoreVal = scoreVal;
            bestDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + scoreVal;
        }
        yield return new WaitForSeconds(3);
        ansARight.SetActive(false);
        ansBRight.SetActive(false);
        ansCRight.SetActive(false);
        ansDRight.SetActive(false);
        ansAWrong.SetActive(false);
        ansBWrong.SetActive(false);
        ansCWrong.SetActive(false);
        ansDWrong.SetActive(false);
        ansAMain.SetActive(true);
        ansBMain.SetActive(true);
        ansCMain.SetActive(true);
        ansDMain.SetActive(true);



        ansA.GetComponent<Button>().enabled = true;
        ansB.GetComponent<Button>().enabled = true;
        ansC.GetComponent<Button>().enabled = true;
        ansD.GetComponent<Button>().enabled = true;

        QuestionGenerator.displayingQuestion = false;

    }

}
