using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAwakeDialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    private void Awake()
    {
        dialogueBox.SetActive(true);
    }
}
