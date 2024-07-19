using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInputSystem : MotionController
{
    private Controls _control;

    protected override void Awake()
    {
        base.Awake();
        _control = new();
    }

    private void OnEnable()
    {
        _control.Enable();
        _control.Character.Montion.performed += callbackContext => SetMotion(callbackContext.ReadValue<Vector2>().x, callbackContext.ReadValue<Vector2>().y);
        _control.Character.Montion.canceled += callbackContext => StopMon();
        _control.Character.Jump.performed += callbackContext => Jump();
        _control.Character.Rotate.performed += callbackContext => SetRotate(callbackContext.ReadValue<float>());
        _control.Character.Rotate.canceled += callbackContext => StopRotate();
        _control.Character.Fire.performed += callbackContext => Fire();
        _control.Character.MessageInput.performed += callbackContext => SendMessage();

    }

    private void StopMon()
    {
        _motion.x = _motion.z = 0;
    }

    private void StopRotate()
    {
        _rotation = 0;
    }

    private void OnDisable()
    {
        _control.Disable(); 
    }
}
