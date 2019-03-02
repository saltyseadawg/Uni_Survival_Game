using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Triggers the 
 */
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
