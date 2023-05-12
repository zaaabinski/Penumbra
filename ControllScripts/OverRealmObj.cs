using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRealmObj : MonoBehaviour
{
    //button 1
    bool button1 = false;
    public bool onTheButton1 = false;
    bool BP1 = false; bool BNP1 = false; //button pressed /button not pressed
    public GameObject ButtonTrue1;
    public GameObject ButtonFalse1;

    //button 2
    bool button2 = false;
    public bool onTheButton2 = false;
    bool BP2 = false; bool BNP2 = false;
    public GameObject ButtonTrue2;
    public GameObject ButtonFalse2;

    //button 3
    bool button3 = false;
    public bool onTheButton3 = false;
    bool BP3 = false; bool BNP3 = false;
    public GameObject ButtonTrue3;
    public GameObject ButtonFalse3;

    //button 4
    bool button4 = false;
    public bool onTheButton4 = false;
    bool BP4 = false; bool BNP4 = false;
    public GameObject ButtonTrue4;
    public GameObject ButtonFalse4;

    //button 5
    bool button5 = false;
    public bool onTheButton5 = false;
    bool BP5 = false; bool BNP5 = false;
    public GameObject ButtonTrue5;
    public GameObject ButtonFalse5;

    //lever 1
    bool lever1 = false;
    public bool onTheLever1 = false;
    bool LD1 = false; bool LU1 = false;
    public GameObject LeverTrue1;
    public GameObject LeverFalse1;

    //lever 2 
    bool lever2 = true;
    public bool onTheLever2 = false;
    bool LD2 = false; bool LU2 = false;
    public GameObject LeverTrue2;
    public GameObject LeverFalse2;

    //lever 3
    bool lever3 = true;
    public bool onTheLever3 = false;
    bool LD3 = false; bool LU3 = false;
    public GameObject LeverTrue3;
    public GameObject LeverFalse3;

    //lever 4
    bool lever4 = true;
    public bool onTheLever4 = false;
    bool LD4 = false; bool LU4 = false;
    public GameObject LeverTrue4;
    public GameObject LeverFalse4;

    //lever 5
    bool lever5 = true;
    public bool onTheLever5 = false;
    bool LD5 = false; bool LU5 = false;
    public GameObject LeverTrue5;
    public GameObject LeverFalse5;

    private void Update()
    {
        //button 1 start
        if(onTheButton1 && !BP1 && !button1)
        {
            StartCoroutine(ButtonOn1());
        }
        else if (!onTheButton1 && button1 && !BNP1)
        {
            StartCoroutine(ButtonOff1());
        }

        //button 2 start
        if (onTheButton2 && !BP2 && !button2)
        {
            StartCoroutine(ButtonOn2());
        }
        else if (!onTheButton2 && button2 && !BNP2)
        {
            StartCoroutine(ButtonOff2());
        }

        //button 3 start
        if (onTheButton3 && !BP3 && !button3)
        {
            StartCoroutine(ButtonOn3());
        }
        else if (!onTheButton3 && button3 && !BNP3)
        {
            StartCoroutine(ButtonOff3());
        }

        //button 4 start
        if (onTheButton4 && !BP4 && !button4)
        {
            StartCoroutine(ButtonOn4());
        }
        else if (!onTheButton4 && button4 && !BNP4)
        {
            StartCoroutine(ButtonOff4());
        }
        //button 5 start
        if (onTheButton5 && !BP5 && !button5)
        {
            StartCoroutine(ButtonOn5());
        }
        else if (!onTheButton5 && button5 && !BNP5)
        {
            StartCoroutine(ButtonOff5());
        }



        //lever 1 start
        else if (onTheLever1 && !LD1 && !lever1)
        {
            StartCoroutine(LeverOn1());
        }
        else if (!onTheLever1 && !LU1! && lever1)
        {
            StartCoroutine(LeverOff1());
        }
        //lever 2 start
        else if (onTheLever2 && !LD2 && lever2)
        {
            StartCoroutine(LeverOn2());
        }
        else if (!onTheLever2 && !LU2 && !lever2)
        {
            StartCoroutine(LeverOff2());
        }
        //lever 3 start
        else if (onTheLever3 && !LD3 && lever3)
        {
            StartCoroutine(LeverOn3());
        }
        else if (!onTheLever3 && !LU3 && !lever3)
        {
            StartCoroutine(LeverOff3());
        }
        //lever 4 start
        else if (onTheLever4 && !LD4 && lever4)
        {
            StartCoroutine(LeverOn4());
        }
        else if (!onTheLever4 && !LU4 && !lever4)
        {
            StartCoroutine(LeverOff4());
        }
        //lever 5 start
        else if (onTheLever5 && !LD5 && lever5)
        {
            StartCoroutine(LeverOn5());
        }
        else if (!onTheLever5 && !LU5 && !lever5)
        {
            StartCoroutine(LeverOff5());
        }

    }

    IEnumerator ButtonOn1()
    {
        BP1 = true;
        Debug.Log("Taking off");
        ButtonFalse1.SetActive(false);
        ButtonTrue1.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        button1 = true;
        BP1 = false;
    }
    IEnumerator ButtonOff1()
    {
        BNP1 = true;
        Debug.Log("Taking on");
        ButtonFalse1.SetActive(true);
        ButtonTrue1.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        button1 = false;
        BNP1 = false;
    }

    IEnumerator ButtonOn2()
    {
        BP2 = true;
        Debug.Log("Taking off");
        ButtonFalse2.SetActive(false);
        ButtonTrue2.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        button2 = true;
        BP2 = false;
    }
    IEnumerator ButtonOff2()
    {
        BNP2 = true;
        Debug.Log("Taking on");
        ButtonFalse2.SetActive(true);
        ButtonTrue2.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        button2 = false;
        BNP2 = false;
    }

    IEnumerator ButtonOn3()
    {
        BP3 = true;
        Debug.Log("Taking off");
        ButtonFalse3.SetActive(false);
        ButtonTrue3.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        button3 = true;
        BP3 = false;
    }
    IEnumerator ButtonOff3()
    {
        BNP3 = true;
        Debug.Log("Taking on");
        ButtonFalse3.SetActive(true);
        ButtonTrue3.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        button3 = false;
        BNP3 = false;
    }

    IEnumerator ButtonOn4()
    {
        BP4 = true;
        Debug.Log("Taking off");
        ButtonFalse4.SetActive(false);
        ButtonTrue4.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        button4 = true;
        BP4 = false;
    }
    IEnumerator ButtonOff4()
    {
        BNP4 = true;
        Debug.Log("Taking on");
        ButtonFalse4.SetActive(true);
        ButtonTrue4.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        button4 = false;
        BNP4 = false;
    }

    IEnumerator ButtonOn5()
    {
        BP5 = true;
        Debug.Log("Taking off");
        ButtonFalse5.SetActive(false);
        ButtonTrue5.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        button5 = true;
        BP5 = false;
    }
    IEnumerator ButtonOff5()
    {
        BNP5 = true;
        Debug.Log("Taking on");
        ButtonFalse5.SetActive(true);
        ButtonTrue5.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        button5 = false;
        BNP5 = false;
    }


    IEnumerator LeverOn1()
    {
        LD1 = true;
        LeverFalse1.SetActive(false);
        LeverTrue1.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        lever1 = true;
        LD1 = false;
    }
    IEnumerator LeverOff1()
    {
        LU1 = true;
        LeverFalse1.SetActive(true);
        LeverTrue1.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        lever1 = false;
        LU1 = false;
    }

    IEnumerator LeverOn2()
    {
        LD2 = true;
        LeverTrue2.SetActive(true);
        LeverFalse2.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        lever2 = false;
        LD2 = false;
    }
    IEnumerator LeverOff2()
    {
        LU2 = true;
        LeverTrue2.SetActive(false);
        LeverFalse2.SetActive(true);
        Debug.Log("Taking on");
        yield return new WaitForSeconds(0.01f);
        lever2 = true;
        LU2 = false;
    }

    IEnumerator LeverOn3()
    {
        LD3 = true;
        LeverTrue3.SetActive(true);
        LeverFalse3.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        lever3 = false;
        LD3 = false;
    }
    IEnumerator LeverOff3()
    {
        LU3 = true;
        LeverTrue3.SetActive(false);
        LeverFalse3.SetActive(true);
        Debug.Log("Taking on");
        yield return new WaitForSeconds(0.01f);
        lever3 = true;
        LU3 = false;
    }

    IEnumerator LeverOn4()
    {
        LD4 = true;
        LeverTrue4.SetActive(true);
        LeverFalse4.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        lever4 = false;
        LD4 = false;
    }
    IEnumerator LeverOff4()
    {
        LU4 = true;
        LeverTrue4.SetActive(false);
        LeverFalse4.SetActive(true);
        Debug.Log("Taking on");
        yield return new WaitForSeconds(0.01f);
        lever4 = true;
        LU4 = false;
    }

    IEnumerator LeverOn5()
    {
        LD5 = true;
        LeverTrue5.SetActive(true);
        LeverFalse5.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        lever5 = false;
        LD5 = false;
    }
    IEnumerator LeverOff5()
    {
        LU5 = true;
        LeverTrue5.SetActive(false);
        LeverFalse5.SetActive(true);
        Debug.Log("Taking on");
        yield return new WaitForSeconds(0.01f);
        lever5 = true;
        LU5 = false;
    }






}
