using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    [SerializeField]
    int score = 0;

    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.ScoreUpdate(score);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(speed * Time.deltaTime * move);
    }

    public void AddScore()
    {
        score++;
        uiManager.ScoreUpdate(score);
    }
}
