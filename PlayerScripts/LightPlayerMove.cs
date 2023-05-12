
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float speed = 6f;
    public float jump = 6f;
    public float turnSmoothTime = 0.1f;
    public float gravity = -9.81f;
    public float groundDistance = 0.2f;
    bool canJump=false;
    private float turnSmoothVelocity;
    private Vector3 velocity;
    private bool isGrounded;
    public Animator anim;
    bool isWalking, isSitting, isChecking=false;
    public PauseMenu PM;
    public AudioSource jumpSound;
    public GameObject dustCloud;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (!PM.gamePaused)
        {
            float moveLR = Input.GetAxisRaw("Horizontal");
            float moveFB = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(moveLR, 0f, moveFB).normalized;

            if (direction.magnitude > 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDir * speed * Time.deltaTime);

                anim.SetBool("IsWalkingBool", true);
                isWalking = true;
                isSitting = false;

            }
            //animations
            else
            {

                isWalking = false;
                if (!isWalking)
                {
                    anim.SetBool("IsWalkingBool", false);
                }
                if (!isWalking && !isSitting && !isChecking)
                {
                    StartCoroutine(SitIdle());
                }
            }

            if ((Input.GetButtonDown("Jump")) && (canJump))
            {
                jumpSound.Play();
                velocity.y = Mathf.Sqrt(jump * -2.0f * gravity);
                anim.SetTrigger("JumpTrig");
            }

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Jumpable"))
        {
            Debug.Log("can jump");
            canJump = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Jumpable"))
        {
            Debug.Log("cant jump");
            canJump = false;
        }
    }

    //sit thing
    IEnumerator SitIdle()
    {
        isChecking = true;
        int j = 0;
        for(int i=0; i<5; i++)
        {
            yield return new WaitForSeconds(1);
            if(!isSitting && !isWalking)
            {
                j++;
            }
            else
            {
                j = 0;
            }
        }
        if(j==5)
        {
            isSitting = true;
            anim.SetTrigger("SitTrig");
        }
        isChecking = false;
    }
}
