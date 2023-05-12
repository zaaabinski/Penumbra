using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFox : MonoBehaviour
{
    public Transform fox1, fox2;
    public  GameObject ghostFox1, ghostFox2;
    Vector3 pos1, rot1, pos2, rot2;
    
    private void Update()
    {
        pos1.x = fox1.position.x;
        pos1.y = fox1.position.y - 1.125f;
        pos1.z = fox1.position.z;

        rot1.x = fox1.rotation.x;
        rot1.y = fox1.rotation.y;
        rot1.z = fox1.rotation.z;

        // Vector3 newRotat = new Vector3(rot1.x, rot1.y, rot1.z);
        Quaternion fox1Rotat = fox1.transform.rotation;
        Quaternion fox2Rotat = fox2.transform.rotation;

        pos2.x = fox2.position.x;
        pos2.y = fox2.position.y - 1.125f;
        pos2.z = fox2.position.z;

        rot2.x = fox2.rotation.x;
        rot2.y = fox2.rotation.y;
        rot2.z = fox2.rotation.z;

        ghostFox1.transform.position = pos1;
        ghostFox2.transform.position = pos2;

        ghostFox1.transform.rotation = fox1Rotat;
        ghostFox2.transform.rotation = fox2Rotat;

    }
}
