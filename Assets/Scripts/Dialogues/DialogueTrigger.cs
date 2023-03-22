using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private bool DialogueAllowed;
    private bool AlreadyPlayed = false;

    private void Update()
    {
           if(DialogueAllowed && Input.GetKeyDown(KeyCode.E) && AlreadyPlayed == false)
        {
            Talk();
            AlreadyPlayed = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            DialogueAllowed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            DialogueAllowed = false;
        }
    }

    void Talk()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
