using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingSword : MonoBehaviour
{
    private bool available;
    public GameObject swordPicked;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            available = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            available = false;
        }
    }

    private void Update()
    {
        if(available && Input.GetKeyDown(KeyCode.E))
        {
            swordPicked.SetActive(true);
            Destroy(gameObject);
        }
    }
}
