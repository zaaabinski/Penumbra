using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public int state=1;
    public Animator animator;
    bool madeMove = false;
    bool canMove = true;
    void Update()
    {
  

        if (Input.GetKeyDown("e"))
        {
            if((state==1)&&(canMove))
            {
            StartCoroutine(Trigger0());
            }
            else if ((state == 2) && (canMove))
            {
                StartCoroutine(Trigger1());
            }
            else if ((state == 3) && (canMove))
            {
                StartCoroutine(Trigger2());
            }
            else if ((state == 4) && (canMove))
            {
                StartCoroutine(Trigger3());
            }
        }

        if (Input.GetKeyDown("q"))
        {
            if ((state == 1) && (canMove))
            {
                StartCoroutine(Trigger7());
            }
            else if ((state == 2) && (canMove))
            {
                StartCoroutine(Trigger4());
            }
            else if ((state == 3) && (canMove))
            {
                StartCoroutine(Trigger5());
            }
            else if ((state == 4) && (canMove))
            {
                StartCoroutine(Trigger6());
            }
        }





        IEnumerator Trigger0()
        {
            canMove = false;
            state++;
            if (madeMove == false)
            {
                animator.SetTrigger("Trig0");
                madeMove = true;
            }
            else
            {
                animator.SetBool("Trig0", true);
            }

            yield return new WaitForSeconds(2);
            canMove = true;
        }

        IEnumerator Trigger1()
        {
            canMove = false;
            state++;
            animator.SetTrigger("Trig1");

            yield return new WaitForSeconds(2);
            canMove = true;
        }
        IEnumerator Trigger2()
        {
            canMove = false;
            state++;
            animator.SetTrigger("Trig2");

            yield return new WaitForSeconds(2); 
            canMove = true;
        }
        IEnumerator Trigger3()
        {
            canMove = false;
            state =1;
            animator.SetTrigger("Trig3");

            yield return new WaitForSeconds(2);
            canMove = true;
        }
        IEnumerator Trigger4()
        {
            canMove = false;
            state --;
            animator.SetTrigger("Trig4");

            yield return new WaitForSeconds(2);
            canMove = true;
        }
        IEnumerator Trigger5()
        {
            canMove = false;
            state--;
            animator.SetTrigger("Trig5");

            yield return new WaitForSeconds(2);
            canMove = true;
        }
        IEnumerator Trigger6()
        {
            canMove = false;
            state--;
            animator.SetTrigger("Trig6");

            yield return new WaitForSeconds(2);
            canMove = true;
        }
        IEnumerator Trigger7()
        {
            canMove = false;
            state=4;
            animator.SetTrigger("Trig7");

            yield return new WaitForSeconds(2);
            canMove = true;
        }


    }



    

}
