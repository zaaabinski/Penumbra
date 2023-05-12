using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPlayerActivation : MonoBehaviour
{
    //player
    public GameObject player;
    public LightPlayerMove LPM;
    public GameObject gameOverCanv;

    public PauseMenu PM;

    public OverRealmObj ORO;
    //animations
    public Animator anim;

    //tunnels
    public Transform tunnel1;
    public Transform tunnel12;

    bool isInTunnel1 = false;
    bool isInTunnel12=false;
    public bool isNotTunneling = false;
     Vector3 tun1, tun2;

    //levers
    bool isInLever1 = false; bool isInLever2 = false;bool isInLever3 = false;bool isInLever4 = false; bool isInLever5 = false;
    bool isNotLevering = false;

    //light and dark system
    bool isInDangerL = false;
    bool isInformedL = false;
    bool gameOverL = false;
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

        if (isInTunnel1 || isInTunnel12)
        {

            if (Input.GetKey("f") && !isNotTunneling)
             {
                StartCoroutine(UseTunnel());
            }
        }

        if (isInDangerL && !isInformedL && !gameOverL)
        {
            StartCoroutine(StartDangerL());
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
        else if (other.CompareTag("Tunnel1"))
        {
            isInTunnel1 = true;
        }
        else if (other.CompareTag("Tunnel1.2"))
        {
            isInTunnel12 = true;
        }
        else if (other.CompareTag("DangerForLight"))
        {
            isInDangerL = true;
        }
        else if(other.CompareTag("WinPlace"))
        {
            winL.lightWin = true;
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
        else if (other.CompareTag("Tunnel1"))
        {
            isInTunnel1 = false;
        }
        else if (other.CompareTag("Tunnel1.2"))
        {
            isInTunnel12 = false;
        }
        else if (other.CompareTag("DangerForLight"))
        {
            isInDangerL = false;
            isInformedL = false;
        }
        else if (other.CompareTag("WinPlace"))
        {
            winL.lightWin = false;
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

        LPM.enabled = false;
        isNotTunneling = true;
        anim.SetTrigger("DigTrig");
        digSound.Play();
        yield return new WaitForSeconds(2.7f);
        digSound.Stop();
        if (isInTunnel1)
        {
            tun2.x = tunnel12.position.x;
            tun2.y = tunnel12.position.y + 2;
            tun2.z = tunnel12.position.z;
            player.transform.position = tun2;

        }
        else if (isInTunnel12)
        {
            tun1.x = tunnel1.position.x;
            tun1.y = tunnel1.position.y + 2;
            tun1.z = tunnel1.position.z;
            
            player.transform.position = tun1;
        }
        emergeSound.Play();
        anim.SetTrigger("JumpTrig");
        Instantiate(dirtPoof, transform.position, dirtPoof.transform.rotation);
        isNotTunneling = false;
        yield return new WaitForSeconds(0.25f);
        LPM.enabled = true;
    }

    IEnumerator StartDangerL()
    {
        isInformedL = true;
        Debug.Log("Danger 1");
        Debug.Log("U dead");
        Time.timeScale = 0f;
        gameOverCanv.SetActive(true);
        PM.canPause = false;
        boop.Play();
        yield return new WaitForSeconds(1);
       
       

    }







}
