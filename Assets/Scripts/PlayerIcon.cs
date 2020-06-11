using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerIcon : MonoBehaviour
{
    private float checkTime = 0.001f;
    private Vector2 oldPos;
    public Transform mapIcon;
    private float initialX;
    private float initialY;
    // Update is called once per frame
    /*void Start()
    {
        initialX = mapIcon.position.x;
        initialY = mapIcon.position.y;
    }*/

    void Update()
    {
        if (checkTime <= 0)
        {
            //oldPos = transform.position;
            mapIcon.position = new Vector3(transform.position.x - 929, transform.position.y + 169,0);
            checkTime = 0.1f;
        }
        else
        {
            checkTime -= Time.deltaTime;
        }

        if(Vector2.Distance(transform.position, oldPos) < 0.1f)
        {
            //mapIcon.speed = 0;
        }
        else
        {
            //mapIcon.speed = 18;
        }
    }
}
