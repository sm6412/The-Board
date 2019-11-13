using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenController : MonoBehaviour
{
    private AudioSource audioSource; //reference to audio source on the score object

    // have a sound effect for when the user hits enter 
    [Header("Sound Effects")]
    public AudioClip selectSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        // when the user hits enter, start the game
        if (Input.GetKeyDown(KeyCode.Return))
        {
            audioSource.PlayOneShot(selectSound);
            SceneManager.LoadScene("Gameplay");
        }
        // when the user hits escape, exit the game 
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}
