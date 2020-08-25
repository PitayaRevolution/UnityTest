using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Player : MonoBehaviour
{

    PlayerControl pc;
    CameraListener cl;
    Camera camera;

    public float speed = 5f;
    float move;
    bool jump;
    Vector3 touchPos;

    private void Awake()
    {
        pc = GetComponent<PlayerControl>();
        cl = GetComponent<CameraListener>();
        camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        touchPos.x = pc.location.x;
        touchPos.y = pc.location.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move = Input.GetAxis("Horizontal");
        //jump = Input.GetButton("Jump");
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPos = camera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, camera.nearClipPlane));
            
        }

        Debug.Log("x: " + touchPos.x + " y: " + touchPos.y);
        Debug.Log("mx: " + pc.location.x + " my: " + pc.location.y);


        if (pc.location.x < touchPos.x)
            move = Math.Min(1, touchPos.x - pc.location.x);
        else
            move = Math.Max(-1, touchPos.x - pc.location.x);
    }

    void FixedUpdate()
    {
        move *= speed;
        pc.Move(move, jump);
    }
}
