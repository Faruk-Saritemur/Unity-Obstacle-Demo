using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropperDebug : MonoBehaviour
{
    [SerializeField] float dropperText = 5.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.time > dropperText)
            Debug.Log("5 secs left");
        else
        {
            Debug.Log("5 secs wait");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
