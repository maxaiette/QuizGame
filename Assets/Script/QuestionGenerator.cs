using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    void Start()
    {
      
        

    }

    // Update is called once per frame
    void Update()
    {
        if(displayingQuestion == false)
        {
            questionNumber = Random.Range(1, 10);
            displayingQuestion = true;
            if (questionNumber == 1)
            {
                
                QuestioGen.newQuestion = "When did the Philippines gain independence from Spain?";
                QuestioGen.newAnswerA = "A. June 11, 1898";
                QuestioGen.newAnswerB = "B. June 12, 1898";
                QuestioGen.newAnswerC = "C. June 21, 1889";
                QuestioGen.newAnswerD = "D. July 12, 1898";
                actualAnswer = "B";
            }
            if (questionNumber == 2)
            {
                QuestioGen.newQuestion = "Who discovered the Philippines?";
                QuestioGen.newAnswerA = "A. Christopher Columbus";
                QuestioGen.newAnswerB = "B. Ferdinand Magellan";
                QuestioGen.newAnswerC = "C.  Marco Polo";
                QuestioGen.newAnswerD = "D. Dr. Jose Rizal";
                actualAnswer = "B";
            }
            if (questionNumber == 3)
            {
                
                QuestioGen.newQuestion = "What was the Martial Law era?";
                QuestioGen.newAnswerA = "A. Philippines under President Ferdinand Marcos from 1972 to 1981";
                QuestioGen.newAnswerB = "B.  Philippines under President Cory Aquino from 1986 to 1992";
                QuestioGen.newAnswerC = "C.  Philippines from 1521 to 1898";
                QuestioGen.newAnswerD = "D. None of the Above";
                actualAnswer = "A";
            }
            if (questionNumber == 4)
            {
           
                QuestioGen.newQuestion = "Who is the national hero of the Philippines?";
                QuestioGen.newAnswerA = "A. Andres Bonifacio";
                QuestioGen.newAnswerB = "B.  Jose Rizal";
                QuestioGen.newAnswerC = "C.  Apolinario Mabini";
                QuestioGen.newAnswerD = "D. Emilio Aguinaldo";
                actualAnswer = "B";
            }
            if (questionNumber == 5)
            {
               
                QuestioGen.newQuestion = "What is the name of the first Filipino saint?";
                QuestioGen.newAnswerA = "A. St. Francis of Assisi";
                QuestioGen.newAnswerB = "B.  St. Ignatius of Loyola";
                QuestioGen.newAnswerC = "C.  St. Peter";
                QuestioGen.newAnswerD = "D. St. Lorenzo Ruiz";
                actualAnswer = "D";
            }
            if (questionNumber == 6)
            {
               
                QuestioGen.newQuestion = "What is the name of the largest island in the Philippines?";
                QuestioGen.newAnswerA = "A. Luzon";
                QuestioGen.newAnswerB = "B. Visayas";
                QuestioGen.newAnswerC = "C. Mindanao";
                QuestioGen.newAnswerD = "D. Palawan";
                actualAnswer = "A";
            }
            if (questionNumber == 7)
            {
              
                QuestioGen.newQuestion = "Who is the first female president of the Philippines?";
                QuestioGen.newAnswerA = "A. Corazon Aquino";
                QuestioGen.newAnswerB = "B. Gloria Macapagal-Arroyo";
                QuestioGen.newAnswerC = "C. Imelda Marcos";
                QuestioGen.newAnswerD = "D. Benigno Aquino III";
                actualAnswer = "A";
            }
            if (questionNumber == 8)
            {
             
                QuestioGen.newQuestion = "Who is the founder of the Katipunan?";
                QuestioGen.newAnswerA = "A. Jose Rizal";
                QuestioGen.newAnswerB = "B. Andres Bonifacio";
                QuestioGen.newAnswerC = "C. Emilio Aguinaldo";
                QuestioGen.newAnswerD = "D. Graciano Lopez Jaena";
                actualAnswer = "B";
            }
            if (questionNumber == 9)
            {
              
                QuestioGen.newQuestion = "What is the name of the treaty that ended the Spanish-American War and granted the Philippines to the United States?";
                QuestioGen.newAnswerA = "A. Treaty of Paris";
                QuestioGen.newAnswerB = "B. Treaty of Tordesillas";
                QuestioGen.newAnswerC = "C. Treaty of Tordesillas";
                QuestioGen.newAnswerD = "D. Treaty of Brest-Litovsk";
                actualAnswer = "A";
            }
            if (questionNumber == 10)
            {
                
                QuestioGen.newQuestion = "What is the name of the Philippine national anthem?";
                QuestioGen.newAnswerA = "A.  Bayan Ko";
                QuestioGen.newAnswerB = "B.  Lupang Hinirang";
                QuestioGen.newAnswerC = "C. Ang Pambansang Awit";
                QuestioGen.newAnswerD = "D. Pasyon";
                actualAnswer = "B";
            }

            QuestioGen.pleaseUpdate = false;

        }
        
    }
}
