using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // ref to screenmanager
    private ScreenManager sm;

    // grab themes for each character
    [Header("Audio Objects")]
    public GameObject intenseMusic;
    public GameObject backgroundMusic;
    public GameObject pusheenMusic;
    public GameObject thomasMusic;
    public GameObject nyancatMusic;
    public GameObject pinkpantherMusic;
    public GameObject catdogMusic;
    public GameObject bongoCatMusic;

    // current music object playing
    private GameObject currentMusic;


    private void Awake()
    {
        // play background music when game starts 
        currentMusic = Instantiate(backgroundMusic);
    }

    void Start()
    {
        // get ref to screen manager 
        sm = GameObject.Find("Screen Manager").GetComponent<ScreenManager>();

    }

    // Update is called once per frame
    void Update()
    {
        // play different songs depending on the scene number 
        if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter==11)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(intenseMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 16)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 19)
        {

            Destroy(currentMusic);
            currentMusic = Instantiate(pusheenMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 31)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(thomasMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 38)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 39)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(nyancatMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 41)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 42)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(pinkpantherMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 48)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 49)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(catdogMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 63)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 64)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(bongoCatMusic);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && sm.statementCounter == 65)
        {
            Destroy(currentMusic);
            currentMusic = Instantiate(backgroundMusic);
        }

    }
}
