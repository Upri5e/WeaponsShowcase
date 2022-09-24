//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Player/Input/PlayerDefault.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerDefault : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerDefault()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerDefault"",
    ""maps"": [
        {
            ""name"": ""RightHand"",
            ""id"": ""2bc37a17-af4c-48c2-8f65-c40c7ab33deb"",
            ""actions"": [
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""d902a215-f994-4c01-8e68-557e20b401f5"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c6799982-753b-4cdf-a5c6-a204533718a2"",
                    ""path"": ""<OculusTouchController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // RightHand
        m_RightHand = asset.FindActionMap("RightHand", throwIfNotFound: true);
        m_RightHand_Trigger = m_RightHand.FindAction("Trigger", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RightHand
    private readonly InputActionMap m_RightHand;
    private IRightHandActions m_RightHandActionsCallbackInterface;
    private readonly InputAction m_RightHand_Trigger;
    public struct RightHandActions
    {
        private @PlayerDefault m_Wrapper;
        public RightHandActions(@PlayerDefault wrapper) { m_Wrapper = wrapper; }
        public InputAction @Trigger => m_Wrapper.m_RightHand_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_RightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandActions set) { return set.Get(); }
        public void SetCallbacks(IRightHandActions instance)
        {
            if (m_Wrapper.m_RightHandActionsCallbackInterface != null)
            {
                @Trigger.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_RightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public RightHandActions @RightHand => new RightHandActions(this);
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IRightHandActions
    {
        void OnTrigger(InputAction.CallbackContext context);
    }
}
