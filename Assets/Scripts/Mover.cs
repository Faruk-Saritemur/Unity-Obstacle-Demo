using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;
    [SerializeField] float zValue = 0;

    [SerializeField] float moveSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        GameStarted();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void GameStarted()
    {
        Debug.Log("test run started...");
    }

    void MovePlayer() 
    {
        xValue = Input.GetAxis("Horizontal") * (Time.deltaTime * 3)* moveSpeed;
        zValue = Input.GetAxis("Vertical") * (Time.deltaTime * 3) * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
