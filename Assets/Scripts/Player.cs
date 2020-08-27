using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Player : MonoBehaviour
{

    PlayerControl pc;
    Camera camera;

    public float speed = 5f;
    float move = 0f;
    bool jump;
    Vector3 touchPos;

    private void Awake()
    {
        pc = GetComponent<PlayerControl>();
        camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        touchPos.x = pc.transform.position.x;
        touchPos.y = pc.transform.position.y;
        

        Debug.Log("x: " + touchPos.x + " y: " + touchPos.y);
        Debug.Log("mx: " + pc.transform.position.x + " my: " + pc.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move()
    {
        //move = Input.GetAxis("Horizontal");
        //jump = Input.GetButton("Jump");
        //Debug.Log("move: " + move.ToString());

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPos = camera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, camera.nearClipPlane));

        }
        //Debug.Log("x: " + touchPos.x + " y: " + touchPos.y);
        //Debug.Log("mx: " + pc.location.x + " my: " + pc.location.y);
        if (Input.GetMouseButtonDown(0))
        {
            touchPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.x, camera.nearClipPlane));
        }


        if (pc.transform.position.x < touchPos.x)
            move = Math.Min(1, touchPos.x - pc.transform.position.x);
        else
            move = Math.Max(-1, touchPos.x - pc.transform.position.x);
    }

    void FixedUpdate()
    {
        Move();
        move *= speed;
        pc.Move(move, jump);
    }
}
