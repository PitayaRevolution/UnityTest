using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerControl pc;

    public float speed = 5f;
    float move;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        jump = Input.GetButton("Jump");
    }

    private void FixedUpdate()
    {
        move *= speed;
        pc.Move(move, jump);
    }
}
