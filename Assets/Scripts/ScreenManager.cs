using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    // get text to be displayed 
    [Header("Text")]
    public Text statement;
    public Text speaker;
    public Text leftAnswer;
    public Text rightAnswer;

    // gather scene statements
    [Header("Statements")]
    [TextArea(2, 10)]
    public List<string> statements;

    // gather scene speakers
    [Header("Speaker")]
    [TextArea(2, 10)]
    public List<string> speakers;

    // gather game outcomes 
    [Header("Outcomes")]
    [TextArea(2, 10)]
    public List<string> outcomes;

    // gather outcome music
    [Header("Outcome Music")]
    public GameObject winMusic;
    public GameObject loseMusic;

    // gather scene answers
    [Header("Answers")]
    [TextArea(2, 10)]
    public List<string> answers;

    // gather cat objects displayed in every scene 
    [Header("Cat Images")]
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject cat5;
    public GameObject cat6;
    public GameObject cat7;
    public GameObject cat8;
    public GameObject cat9;
    public GameObject cat10;
    public GameObject cat11;
    public GameObject cat12;
    public GameObject cat13;
    public GameObject cat14;
    public GameObject cat15;
    public GameObject cat16;
    public GameObject cat17;
    public GameObject cat18;
    public GameObject cat19;
    public GameObject cat20;
    public GameObject cat21;
    public GameObject cat22;
    public GameObject cat23;
    public GameObject cat24;
    public GameObject cat25;
    public GameObject cat26;
    public GameObject cat27;
    public GameObject cat28;
    public GameObject cat29;
    public GameObject cat30;
    public GameObject cat31;
    public GameObject cat32;
    public GameObject cat33;
    public GameObject cat34;
    public GameObject cat35;
    public GameObject cat36;
    public GameObject cat37;
    public GameObject cat38;
    public GameObject cat39;
    public GameObject cat40;
    public GameObject cat41;
    public GameObject cat42;
    public GameObject cat43;
    public GameObject cat44;
    public GameObject cat45;
    public GameObject cat46;
    public GameObject cat47;
    public GameObject cat48;
    public GameObject cat49;
    public GameObject cat50;
    public GameObject cat51;
    public GameObject cat52;
    public GameObject cat53;
    public GameObject cat54;
    public GameObject cat55;
    public GameObject cat56;
    public GameObject cat57;
    public GameObject cat58;
    public GameObject cat59;
    public GameObject cat60;
    public GameObject cat61;
    public GameObject cat62;
    public GameObject cat63;
    public GameObject cat64;
    public GameObject cat65;
    public GameObject cat66;
    public GameObject cat67;
    public GameObject cat68;

    // gather ending scene cat objects
    [Header("Ending Cats")]
    public GameObject goodEndingCat;
    public GameObject badEndingCat;

    // create a list to hold all cat game objects 
    private List<GameObject> cats;

    // create counters to keep track of what gets displayed
    // and what music gets played
    public int statementCounter;
    private int speakerCounter;
    private int leftAnswerCounter;
    private int rightAnswerCounter;
    private int displayCatCounter;

    // current cat game object of scene
    private GameObject currentCat;

    // bool represents whether the user has reached the 
    // end of the game
    public bool endGame = false;

    // list of scene in which you answer questions 
    public List<int> answerList = new List<int>{ 2, 17, 25, 26, 27, 28, 29, 32, 35, 36, 37, 39, 44, 45, 46 };

    // get the outcome music 
    private GameObject outcomeMusic;

    // bool to rep if the result screen has displayed
    public bool outcomeDisplayed = false;


    // Start is called before the first frame update
    void Start()
    {
        // fill the cat objects list
        cats = new List<GameObject> { cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9,cat10,
                                     cat11,cat12,cat13,cat14,cat15,cat16,cat17,cat18,cat19,cat20,
                                     cat21,cat22,cat23,cat24,cat25,cat26,cat27,cat28,cat29,cat30,
                                     cat31,cat32,cat33,cat34,cat35,cat36,cat37,cat38,cat39,cat40,
                                     cat41,cat42,cat43,cat44,cat45,cat46,cat47,cat48,cat49,cat50,
                                     cat51,cat52,cat53,cat54,cat55,cat56,cat57,cat58,cat59,cat60,
                                     cat61,cat62,cat63,cat64,cat65,cat66,cat67,cat68};
        // set counters
        statementCounter = 0;
        speakerCounter = 0;
        leftAnswerCounter = 0;
        rightAnswerCounter = 1;
        displayCatCounter = 0;

        // first display the initial statement
        statement.text = statements[statementCounter];

        // increment counter
        statementCounter++;

        // first display the initial speaker
        speaker.text = speakers[speakerCounter];

        // increment counter
        speakerCounter++;

        // display initial cat object 
        currentCat = Instantiate(cats[displayCatCounter]);

        // increment the counter
        displayCatCounter++;

    }

    // Update is called once per frame
    void Update()
    {
        // if enter is hit, change scenes
        if (Input.GetKeyDown(KeyCode.Return) && statementCounter<70 && endGame==false)
        {
            if (statementCounter == 69)
            {
                endGame = true;
            }
            else
            {
                DisplayNewScene();

            }
        }

        // display possible ending scenes 
        if (Input.GetKeyDown(KeyCode.Return) && endGame==true && outcomeDisplayed==false)
        {
            outcomeDisplayed = true;
            speaker.text = "You";
            if (GameManager.Instance.win == true)
            {
                Destroy(GameObject.FindWithTag("music"));
                outcomeMusic = Instantiate(winMusic);
                statement.text = outcomes[0];
                Destroy(currentCat);
                currentCat = Instantiate(goodEndingCat);
            }
            else
            {
                Destroy(GameObject.FindWithTag("music"));
                outcomeMusic = Instantiate(loseMusic);
                statement.text = outcomes[1];
                Destroy(currentCat);
                currentCat = Instantiate(badEndingCat);
            }

        }

    }

    // displays the next scene's statement and speaker  
    public void DisplayNewScene()
    {
        // display statement 
        statement.text = statements[statementCounter];

        // display speaker
        speaker.text = speakers[speakerCounter];

        DisplayAnswers();
        DisplayNewCat();
        
        // increment counter
        statementCounter++;
        // increment counter
        speakerCounter++;


    }

    // displays new cat object for scene 
    public void DisplayNewCat()
    {
        if (statementCounter!=67)
        {
            Destroy(currentCat);
            currentCat = Instantiate(cats[displayCatCounter]);
            displayCatCounter++;
        }
        else
        {
            Destroy(currentCat);
        }
    }

    // displays possible answers
    public void DisplayAnswers()
    {
        if (answerList.Contains(statementCounter))
        {
            leftAnswer.text = answers[leftAnswerCounter];
            rightAnswer.text = answers[rightAnswerCounter];

            leftAnswerCounter += 2;
            rightAnswerCounter += 2;
        }
        else
        {
            leftAnswer.text = "";
            rightAnswer.text = "";

        }
    }
}
