using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollowPlayer : MonoBehaviour
{
    private GameObject player;
    private Vector2 objectPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.Rotate(0, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        objectPos.x = player.transform.position.x+1;
        objectPos.y = player.transform.position.y;
        transform.position = objectPos;
        
    }
}
