using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingFlashlight : MonoBehaviour
{  
    public GameObject toDestroy;
    public GameObject PromptOn;
    public GameObject FlashlightOn;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            FlashlightOn.GetComponent<FlashLightBehaviour>().enabled = true;
            PromptOn.SetActive(true);
            Destroy(toDestroy);
            Destroy(gameObject);
        }
    }

}
