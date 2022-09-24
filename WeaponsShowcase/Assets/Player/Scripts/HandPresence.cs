using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandPresence : MonoBehaviour
{
    public Hand hand;

    ActionBasedController controller;
    void Start()
    {
        controller = GetComponent<ActionBasedController>();

        controller.selectAction.action.performed += GripAction;
        controller.activateAction.action.performed += TriggerAction;

        controller.selectAction.action.canceled -= GripAction;
        controller.activateAction.action.canceled -= TriggerAction;
    }

    private void TriggerAction(InputAction.CallbackContext obj)
    {
        hand.SetTrigger(obj.ReadValue<float>());
    }

    private void GripAction(InputAction.CallbackContext obj)
    {
        hand.SetGrip(obj.ReadValue<float>());
    }
}
