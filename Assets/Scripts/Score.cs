using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text coinLeft;
    public static int count = 12;

    void Start()
    {
        coinLeft = GetComponent<Text>();
        coinLeft.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinLeft.text = count.ToString();
    }
}
