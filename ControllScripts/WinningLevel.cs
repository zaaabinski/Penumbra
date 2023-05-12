using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningLevel : MonoBehaviour
{
    public GameObject lightPlayer;
    public GameObject darkPlayer;
    public GameObject winUI;
    public bool darkWin=false, lightWin=false;
    bool test = false;
    public PauseMenu PM;
    public bool gameWon = false;
    public AudioSource daySong;
    public AudioSource nightSong;
    public AudioSource daySounds;
    public AudioSource nightSounds;
    public AudioSource endStinger;

    // Update is called once per frame
    void Update()
    {
        if(darkWin && lightWin && !test)
        {
            Debug.Log("You won!");
            gameWon = true;
            test = true;
            Time.timeScale = 0f;
            winUI.SetActive(true);
            PM.canPause = false;
            endStinger.Play();
           // daySong.volume = 0;
           // nightSong.volume = 0;
           //endStinger.volume = 1;
            StartCoroutine(StartFade(daySong, 3, 0));
            StartCoroutine(StartFade(nightSong, 3, 0));
            StartCoroutine(StartFade(endStinger, 3, 1));


        }
    }
    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.unscaledDeltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
