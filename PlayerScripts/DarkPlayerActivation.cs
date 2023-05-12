using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkPlayerActivation : MonoBehaviour
{
    //player
    public GameObject playerD;
    public DarkPlayerMove DPM;
    public GameObject gameOverCanv;

    public PauseMenu PM;

    public OverRealmObj ORO;
    //animations
    public Animator anim;
    //tunnels
    public Transform tunnel1D;
    public Transform tunnel12D;

    bool isInTunnel1D = false;
    bool isInTunnel12D = false;
    public bool isNotTunnelingD = false;
    Vector3 tun1D, tun2D;

    //levers
    bool isInLever1 = false; bool isInLever2 = false; bool isInLever3 = false; bool isInLever4 = false; bool isInLever5 = false;
    bool isNotLevering = false;

    //light and dark system
    bool isInDangerD = false;
    bool isInformedD = false;
    bool gameOverD = false;
    public AudioSource boop;
    //winning
    public WinningLevel winL;
    public AudioSource leverSound;
    public AudioSource digSound;
    public AudioSource emergeSound;
    public AudioSource buttonSound;
    public GameObject dirtPoof;

    private void Update()
    {
        if (Input.GetKey("f") && !isNotLevering)
        {
            if (isInLever1)
            {
                StartCoroutine(SwitchLever1());
                anim.SetTrigger("LeverTrig");
                leverSound.Play();
            }
            if (isInLever2)
            {
                StartCoroutine(SwitchLever2());
                anim.SetTrigger("LeverTrig");
                leverSound.Play();
            }
            if (isInLever3)
            {
                StartCoroutine(SwitchLever3());
                anim.SetTrigger("LeverTrig");
                leverSound.Play();
            }
            if (isInLever4)
            {
                StartCoroutine(SwitchLever4());
                anim.SetTrigger("LeverTrig");
                leverSound.Play();
            }
            if (isInLever5)
            {
                StartCoroutine(SwitchLever5());
                anim.SetTrigger("LeverTrig");
                leverSound.Play();
            }
        }

        if (isInTunnel1D || isInTunnel12D)
        {

            if (Input.GetKey("f") && !isNotTunnelingD)
            {
                StartCoroutine(UseTunnel());
            }
        }
        if (isInDangerD && !isInformedD && !gameOverD)
        {
            StartCoroutine(StartDangerD());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button1"))
        {
            ORO.onTheButton1 = true;
            buttonSound.Play();
        }
        if (other.CompareTag("Button2"))
        {
            ORO.onTheButton2 = true;
            buttonSound.Play();
        }
        if (other.CompareTag("Button3"))
        {
            ORO.onTheButton3 = true;
            buttonSound.Play();
        }
        if (other.CompareTag("Button4"))
        {
            ORO.onTheButton4 = true;
            buttonSound.Play();
        }
        if (other.CompareTag("Button5"))
        {
            ORO.onTheButton5 = true;
            buttonSound.Play();
        }
        else if (other.CompareTag("Lever1"))
        {
            isInLever1 = true;
        }
        else if (other.CompareTag("Lever2"))
        {
            isInLever2 = true;
        }
        else if (other.CompareTag("Lever3"))
        {
            isInLever3 = true;
        }
        else if (other.CompareTag("Lever4"))
        {
            isInLever4 = true;
        }
        else if (other.CompareTag("Lever5"))
        {
            isInLever5 = true;
        }
        if (other.CompareTag("Tunnel1D"))
        {
            isInTunnel1D = true;
        }
         else if (other.CompareTag("Tunnel1.2D"))
        {
            isInTunnel12D = true;
        }
         if(other.CompareTag("DangerForDark"))
        {
            isInDangerD = true;
        }
         if (other.CompareTag("WinPlace"))
        {
            winL.darkWin = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Button1"))
        {
            ORO.onTheButton1 = false;
        }
        if (other.CompareTag("Button2"))
        {
            ORO.onTheButton2 = false;
        }
        if (other.CompareTag("Button3"))
        {
            ORO.onTheButton3 = false;
        }
        if (other.CompareTag("Button4"))
        {
            ORO.onTheButton4 = false;
        }
        if (other.CompareTag("Button5"))
        {
            ORO.onTheButton5 = false;
        }
        else if (other.CompareTag("Lever1"))
        {
            isInLever1 = false;
        }
        else if (other.CompareTag("Lever2"))
        {
            isInLever2 = false;
        }
        else if (other.CompareTag("Lever3"))
        {
            isInLever3 = false;
        }
        else if (other.CompareTag("Lever4"))
        {
            isInLever4 = false;
        }
        else if (other.CompareTag("Lever5"))
        {
            isInLever5 = false;
        }
        else if (other.CompareTag("Tunnel1D"))
        {
            isInTunnel1D = false;
        }
        else if (other.CompareTag("Tunnel1.2D"))
        {
            isInTunnel12D = false;
        }
        else if (other.CompareTag("DangerForDark"))
        {
            isInDangerD = false;
            isInformedD = false;
        }
        else if (other.CompareTag("WinPlace"))
        {
            winL.darkWin = false;
        }
    }





    IEnumerator SwitchLever1()
    {
        isNotLevering = true;
        if (!ORO.onTheLever1)
        {
            ORO.onTheLever1 = true;
        }
        else
        {
            ORO.onTheLever1 = false;
        }
        yield return new WaitForSeconds(1);
        isNotLevering = false;
    }

    IEnumerator SwitchLever2()
    {
        isNotLevering = true;
        if (!ORO.onTheLever2)
        {
            ORO.onTheLever2 = true;
        }
        else
        {
            ORO.onTheLever2 = false;
        }
        yield return new WaitForSeconds(1);
        isNotLevering = false;
    }

    IEnumerator SwitchLever3()
    {
        isNotLevering = true;
        if (!ORO.onTheLever3)
        {
            ORO.onTheLever3 = true;
        }
        else
        {
            ORO.onTheLever3 = false;
        }
        yield return new WaitForSeconds(1);
        isNotLevering = false;
    }

    IEnumerator SwitchLever4()
    {
        isNotLevering = true;
        if (!ORO.onTheLever4)
        {
            ORO.onTheLever4 = true;
        }
        else
        {
            ORO.onTheLever4 = false;
        }
        yield return new WaitForSeconds(1);
        isNotLevering = false;
    }

    IEnumerator SwitchLever5()
    {
        isNotLevering = true;
        if (!ORO.onTheLever5)
        {
            ORO.onTheLever5 = true;
        }
        else
        {
            ORO.onTheLever5 = false;
        }
        yield return new WaitForSeconds(1);
        isNotLevering = false;
    }

    IEnumerator UseTunnel()
    {

        DPM.enabled = false;
        isNotTunnelingD = true;
        anim.SetTrigger("DigTrig");
        digSound.Play();
        yield return new WaitForSeconds(2.7f);
        digSound.Stop();
        if (isInTunnel1D)
        {
            tun2D.x = tunnel12D.position.x;
            tun2D.y = tunnel12D.position.y + 2;
            tun2D.z = tunnel12D.position.z;
            playerD.transform.position = tun2D;
        }
        else if (isInTunnel12D)
        {
            tun1D.x = tunnel1D.position.x;
            tun1D.y = tunnel1D.position.y + 2;
            tun1D.z = tunnel1D.position.z;
            playerD.transform.position = tun1D;
        }
        emergeSound.Play();
        anim.SetTrigger("JumpTrig");
        isNotTunnelingD = false;
        Instantiate(dirtPoof, transform.position, dirtPoof.transform.rotation);
        yield return new WaitForSeconds(0.25f);
        DPM.enabled = true;
    }

    IEnumerator StartDangerD()
    {
        isInformedD = true;
        Debug.Log("Danger 1");
        Debug.Log("U dead");
        Time.timeScale = 0f;
        gameOverCanv.SetActive(true);
        PM.canPause = false;
        boop.Play();
        yield return new WaitForSeconds(1);

    }




}
