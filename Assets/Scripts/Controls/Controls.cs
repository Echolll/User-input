//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Scripts/Controls/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""e6d9ff58-2bf0-4705-b602-f191f1bafd58"",
            ""actions"": [
                {
                    ""name"": ""Montion"",
                    ""type"": ""Value"",
                    ""id"": ""021c2e12-ff7c-4ba2-b300-b3306aace2ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""b7d0c723-b75f-4a6e-a69c-96ea7ebd9bbb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fd790aaf-aadc-4e0c-90f5-220c8b868563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MessageInput"",
                    ""type"": ""Button"",
                    ""id"": ""234fe1c6-6f13-4fe4-a599-7f18212a2b21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""2995a9a9-ef71-486d-815c-188efd694ddf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fa315c73-7893-4a46-8813-c53f1099f828"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1f47bdbd-f55e-479a-8376-889dfb570f12"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e929987f-f51d-4509-867f-f2006165835e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""295c0ade-89a2-4e2c-aa79-db66d6b4ddd2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""156e4528-97d0-47d9-9e52-a233e000f944"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""a4e2d1b7-3138-48f8-a38a-9444abaa28ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""45a49651-2625-44f5-b4c4-7bd9de504a23"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aaa5ead2-fae6-4010-b8d3-66f1b95b6429"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ecc8882-240e-490a-8540-473f1dc7df93"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""85599b5a-4b81-487d-8e01-ece999025297"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Montion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e0f38eb7-0184-4a22-bb5e-987cde48a120"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9fb3c488-c78a-47b8-8e3e-816636dd27d6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c74ac93c-b8bc-424d-a175-f5d195142142"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""67f62bff-833b-431e-bcea-ba2d01c6e704"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""162b7d5e-cb76-4426-bf5d-75a0c6fb9e60"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MessageInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85297408-1d7c-4b6f-94e3-f5717e8a01dd"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MessageInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b2b004d-897d-4081-bdac-6c1344047763"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ShapeMontion"",
            ""id"": ""b761aaec-2342-48ce-ba6b-c1b356db845c"",
            ""actions"": [
                {
                    ""name"": ""StartMon"",
                    ""type"": ""Button"",
                    ""id"": ""50e4792b-540a-40d4-bebc-006237a211f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StopMon"",
                    ""type"": ""Button"",
                    ""id"": ""30e1192f-c78f-4135-a56b-11d0b18fbfb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b60877c7-6b08-4243-bcc0-c9c23366c0a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartMon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""928843b1-ff52-40eb-b4ce-929ae87c6a42"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopMon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Montion = m_Character.FindAction("Montion", throwIfNotFound: true);
        m_Character_Rotate = m_Character.FindAction("Rotate", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_MessageInput = m_Character.FindAction("MessageInput", throwIfNotFound: true);
        m_Character_Fire = m_Character.FindAction("Fire", throwIfNotFound: true);
        // ShapeMontion
        m_ShapeMontion = asset.FindActionMap("ShapeMontion", throwIfNotFound: true);
        m_ShapeMontion_StartMon = m_ShapeMontion.FindAction("StartMon", throwIfNotFound: true);
        m_ShapeMontion_StopMon = m_ShapeMontion.FindAction("StopMon", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Montion;
    private readonly InputAction m_Character_Rotate;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_MessageInput;
    private readonly InputAction m_Character_Fire;
    public struct CharacterActions
    {
        private @Controls m_Wrapper;
        public CharacterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Montion => m_Wrapper.m_Character_Montion;
        public InputAction @Rotate => m_Wrapper.m_Character_Rotate;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @MessageInput => m_Wrapper.m_Character_MessageInput;
        public InputAction @Fire => m_Wrapper.m_Character_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Montion.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMontion;
                @Montion.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMontion;
                @Montion.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMontion;
                @Rotate.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRotate;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @MessageInput.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMessageInput;
                @MessageInput.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMessageInput;
                @MessageInput.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMessageInput;
                @Fire.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Montion.started += instance.OnMontion;
                @Montion.performed += instance.OnMontion;
                @Montion.canceled += instance.OnMontion;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MessageInput.started += instance.OnMessageInput;
                @MessageInput.performed += instance.OnMessageInput;
                @MessageInput.canceled += instance.OnMessageInput;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // ShapeMontion
    private readonly InputActionMap m_ShapeMontion;
    private IShapeMontionActions m_ShapeMontionActionsCallbackInterface;
    private readonly InputAction m_ShapeMontion_StartMon;
    private readonly InputAction m_ShapeMontion_StopMon;
    public struct ShapeMontionActions
    {
        private @Controls m_Wrapper;
        public ShapeMontionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartMon => m_Wrapper.m_ShapeMontion_StartMon;
        public InputAction @StopMon => m_Wrapper.m_ShapeMontion_StopMon;
        public InputActionMap Get() { return m_Wrapper.m_ShapeMontion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShapeMontionActions set) { return set.Get(); }
        public void SetCallbacks(IShapeMontionActions instance)
        {
            if (m_Wrapper.m_ShapeMontionActionsCallbackInterface != null)
            {
                @StartMon.started -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStartMon;
                @StartMon.performed -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStartMon;
                @StartMon.canceled -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStartMon;
                @StopMon.started -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStopMon;
                @StopMon.performed -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStopMon;
                @StopMon.canceled -= m_Wrapper.m_ShapeMontionActionsCallbackInterface.OnStopMon;
            }
            m_Wrapper.m_ShapeMontionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartMon.started += instance.OnStartMon;
                @StartMon.performed += instance.OnStartMon;
                @StartMon.canceled += instance.OnStartMon;
                @StopMon.started += instance.OnStopMon;
                @StopMon.performed += instance.OnStopMon;
                @StopMon.canceled += instance.OnStopMon;
            }
        }
    }
    public ShapeMontionActions @ShapeMontion => new ShapeMontionActions(this);
    public interface ICharacterActions
    {
        void OnMontion(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMessageInput(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
    public interface IShapeMontionActions
    {
        void OnStartMon(InputAction.CallbackContext context);
        void OnStopMon(InputAction.CallbackContext context);
    }
}
