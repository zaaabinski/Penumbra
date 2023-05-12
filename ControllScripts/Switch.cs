using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool isDark = false;
    bool isSwitching = false;

    public Light lt;
    public Color Color1;
    public Color Color2;

    public Animator animator;
    public GameObject lightEnv;
    public GameObject darkEnv;

    public Material mat1;
    public Material mat2;

    public AudioSource daySong;
    public AudioSource nightSong;
    public AudioSource daySounds;
    public AudioSource nightSounds;

    public MusicWhenClose MWC;
    float volDay, volNight;

    public LightPlayerActivation LPA;
    public DarkPlayerActivation DPA;

    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            if((isDark)&&(isSwitching==false)&&(LPA.isNotTunneling==false) && (DPA.isNotTunnelingD == false))
            {
                StartCoroutine(LightUp());
            }

            else if ((!isDark) && (isSwitching == false) && (LPA.isNotTunneling == false) && (DPA.isNotTunnelingD == false))
            {
                StartCoroutine(DarkUp());
            }
        }

    }
    IEnumerator LightUp()
    {
        volDay = daySong.volume;
        volNight = nightSong.volume;
        MWC.isDay = true;
        isSwitching = true;
        animator.SetTrigger("LightTrig");
        StartCoroutine(StartFade(daySong, 1, volNight));
        StartCoroutine(StartFade(nightSong, 1, volDay));
        StartCoroutine(StartFade(daySounds, 1, 1));
        StartCoroutine(StartFade(nightSounds, 1, 0));
        yield return new WaitForSeconds(1f);
      //  daySong.volume = volNight;
      // nightSong.volume = volDay;
        Color1 = new Color32(221, 152, 16, 1);
        RenderSettings.skybox = mat1; 
        lt.color = Color1;
        darkEnv.SetActive(false);
        lightEnv.SetActive(true);
        isDark = false;
        isSwitching = false;
    }
    IEnumerator DarkUp()
    {
        volDay = daySong.volume;
        volNight = nightSong.volume;
        MWC.isDay = false;
        isSwitching = true;
        animator.SetTrigger("DarkTrig");
        StartCoroutine(StartFade(daySong, 1, volNight));
        StartCoroutine(StartFade(nightSong, 1, volDay));
        StartCoroutine(StartFade(daySounds, 1, 0));
        StartCoroutine(StartFade(nightSounds, 1, 1));
        yield return new WaitForSeconds(1f);
        RenderSettings.skybox = mat2;
        Color2 = new Color32(16, 112, 221, 1);
        lt.color = Color2;
        
        darkEnv.SetActive(true);
        lightEnv.SetActive(false);
        isDark = true;
        isSwitching = false;
    }

    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

}
