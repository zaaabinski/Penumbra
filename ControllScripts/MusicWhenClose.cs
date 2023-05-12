using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicWhenClose : MonoBehaviour
{
    public Transform playerL;
    public LayerMask IsPlayerL;
    public bool playerInRangeL;

    public Transform playerD;
    public LayerMask IsPlayerD;
    public bool playerInRangeD;
    float range = 10f;

    public GameObject FoxL1;
    public GameObject FoxD1;

    public GameObject FoxL2;
    public GameObject FoxD2;

    public AudioSource dayMusic;
    public AudioSource nightMusic;
    public bool isDay = true;
    float mVolumeNight, mVolumeDay;
    public WinningLevel WL;

    // Update is called once per frame
    void Update()
    {
        if (!WL.gameWon)
        {
            if (isDay)
            {
                playerInRangeL = Physics.CheckSphere(playerL.transform.position, range, IsPlayerL);
                if (playerInRangeL)
                {
                    float distance = Vector3.Distance(FoxL1.transform.position, FoxD1.transform.position);
                    mVolumeNight = 11 - distance;
                    nightMusic.volume = mVolumeNight / 10;
                }
                else
                {
                    nightMusic.volume = 0;
                }
            }
            else if (!isDay)
            {
                playerInRangeD = Physics.CheckSphere(playerD.transform.position, range, IsPlayerD);
                if (playerInRangeD)
                {
                    float distance = Vector3.Distance(FoxL2.transform.position, FoxD2.transform.position);
                    mVolumeDay = 11 - distance;
                    dayMusic.volume = mVolumeDay / 10;
                }
                else
                {
                    dayMusic.volume = 0;
                }
            }
        }
    }
}
