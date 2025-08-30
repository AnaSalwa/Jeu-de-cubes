using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Moving moving;

    // Start is called before the first frame update
    void Start()
    {
        moving = GetComponent<Moving>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            moving.enabled = false;
        }
    }
}
