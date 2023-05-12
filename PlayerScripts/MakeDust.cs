using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDust : MonoBehaviour
{
    public GameObject dustCloud;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
            Debug.Log("Works");
        }
    }
}
