using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldInputSystem : MotionController
    {
        protected override void Update()
        {
            SetMotion(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            SetRotate(Input.GetAxisRaw("Rotation"));
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Fire();

            if (Input.GetKeyDown(KeyCode.Space))
                Jump();

            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.LeftCommand))
                SendMessage();

            base.Update();
        }
    }