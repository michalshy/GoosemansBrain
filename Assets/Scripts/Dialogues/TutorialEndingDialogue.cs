using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialEndingDialogue : MonoBehaviour
{
    
    public Dialogue dialogue;
    public GameObject ending;
    public GameObject sword;

    private bool BugsKilled;
    private bool DialogueAllowed;
    private bool AlreadyPlayed = false;

    private float fade;

    private void Update()
    {
        if(GameObject.FindWithTag("Bug") == null)
        {
            BugsKilled = true;
        }
        if (BugsKilled && DialogueAllowed && Input.GetKeyDown(KeyCode.E) && AlreadyPlayed == false)
        {
            Talk();
            AlreadyPlayed = true;
            ending.SetActive(true);
            sword.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DialogueAllowed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DialogueAllowed = false;
        }
    }

    void Talk()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    
}


