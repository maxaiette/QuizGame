using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestioGen : MonoBehaviour

{
    public GameObject question;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public static string newQuestion;
    public static string newAnswerA;
    public static string newAnswerB;
    public static string newAnswerC;
    public static string newAnswerD;
    public static bool pleaseUpdate= false;

    
    

    // Update is called once per frame
    void Update()
    {
        if(pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(displayTextOnScreen());
        }
    }

    IEnumerator displayTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        question.GetComponent<TMPro.TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TMPro.TextMeshProUGUI>().text = newAnswerA;
        answerB.GetComponent<TMPro.TextMeshProUGUI>().text = newAnswerB;
        answerC.GetComponent<TMPro.TextMeshProUGUI>().text = newAnswerC;
        answerD.GetComponent<TMPro.TextMeshProUGUI>().text = newAnswerD;
    }
}
