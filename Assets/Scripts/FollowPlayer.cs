using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    private Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos.x = player.transform.position.x;
        cameraPos.y = player.transform.position.y;
        cameraPos.z = -10;
        transform.position = cameraPos;

    }
}
