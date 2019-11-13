using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // create singleton
    public static GameManager Instance;

    // bool to keep track of if the left answer is chosen
    private bool selectLeftAnswer = true;

    // create bools to represent which buttons
    // are being pressed
    private bool rightPressed = false;
    private bool leftPressed = false;

    // create counts for correct and incorrect answers 
    private int correctCount;
    private int incorrectCount;

    // create a bool to rep if the player won or not
    public bool win = false;

    // ref to screenmanager 
    private ScreenManager sm;

    // ref to audio source
    private AudioSource audioSource; 

    // sound effects for when the players makes a decision
    [Header("Sound Effects")]
    public AudioClip choiceSound;
    public AudioClip selectedSound;
    
    // game object that asks the user at the end if they want to restart
    public GameObject reset;


    // Start is called before the first frame update
    private void Awake()
    {
        // set singleton 
        Instance = this;

        // ref screenmanager 
        sm = GameObject.Find("Screen Manager").GetComponent<ScreenManager>();
        
        // ref audiosource 
        audioSource = GetComponent<AudioSource>();

        // set chosen word to left initially 
        SetChosenWord("left chosen");
        leftPressed = true;

        // set count
        correctCount = 0;
        incorrectCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // if the outcome screen is displayed, display the reset object 
        if (Input.GetKeyDown(KeyCode.Return) && sm.outcomeDisplayed == true)
        {
            Instantiate(reset);
        }


        
        if (sm.answerList.Contains(sm.statementCounter-1))
        {
            // use arrow keys and wasd to select answer
            if (leftPressed == false && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)))
            {
                audioSource.PlayOneShot(choiceSound);
                SetChosenWord("right chosen");
                rightPressed = true;
            }
            else
            {
                rightPressed = false;
            }
            if (rightPressed == false && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)))
            {
                audioSource.PlayOneShot(choiceSound);
                SetChosenWord("left chosen");
                leftPressed = true;
            }
            else
            {
                leftPressed = false;
            }
        }

        // handle the counts for when a answer is chosen according to the scene
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (sm.statementCounter == 3)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 18)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }

            }
            else if (sm.statementCounter == 26)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 27)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 28)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 29)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 30)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 33)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 36)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 37)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 38)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 40)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 45)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 46)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == true)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }
            else if (sm.statementCounter == 47)
            {
                audioSource.PlayOneShot(selectedSound);
                if (selectLeftAnswer == false)
                {
                    correctCount++;
                }
                else
                {
                    incorrectCount++;
                }
            }

            // get final outcome based on questions 
            if (sm.statementCounter == 48)
            {
                if (correctCount>incorrectCount)
                {
                    win = true;
                }
            }
        }
    }

    void SetChosenWord(string optionChosen)
    {
        // if the chosen word is on the left, make the text white
        if (optionChosen == "left chosen")
        {
            sm.leftAnswer.color = new Color(0f, 0.1084151f, .5f);
            sm.rightAnswer.color = Color.white;
            selectLeftAnswer = true;

        }
        // if the chosen word is on the right, make the text blue
        else
        {
            sm.leftAnswer.color = Color.white;
            sm.rightAnswer.color = new Color(0f, 0.1084151f, .5f); 
            selectLeftAnswer = false;
        }
    }
}
