using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, speed, 0f) * Time.deltaTime);
    }

    void OnTriggerEnter()
    {
        FindObjectOfType<AudioManager>().Play("grabCoin");
        FindObjectOfType<AudioManager>().Play("talkAtCoin");
        Destroy(gameObject);
        Score.count -= 1;
    }
}
