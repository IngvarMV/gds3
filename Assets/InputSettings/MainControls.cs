// GENERATED AUTOMATICALLY FROM 'Assets/InputSettings/MainControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""66210bd8-833b-4a45-904c-ef9bc6e195ff"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""42fb0ae0-9afb-4cae-beab-c04fc2550565"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""a6425645-077e-4339-a781-60b9c74ab216"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""60047e4c-35e4-4590-acc3-c0eb5c2110af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GravitySwitch"",
                    ""type"": ""Button"",
                    ""id"": ""faae704f-86cc-480b-9acb-ef01d09970c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackHigh"",
                    ""type"": ""Button"",
                    ""id"": ""3410a797-60ff-4219-afa5-63bfee8fcc71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackLow"",
                    ""type"": ""Button"",
                    ""id"": ""2cb10a96-e2e1-4873-8440-6df4b4a60728"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""013137e2-3518-4a4b-90eb-1ce34e8d1886"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""d6123752-86c7-463b-ae5d-71dbf574f94f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f6044859-c0c2-479e-8766-0ed6d3136449"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c04e00c-6c1a-4b5b-98b4-f895ca98bb82"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d0845629-c7d2-4a49-8433-88fbeddff09c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ebe046a6-6396-453c-ab4b-09b882776265"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ad75c96f-ee61-40c7-a8d9-04bab31a98e7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4abf7528-1c32-4d25-82e9-d62afadf0106"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""d48928c3-ea5f-4337-b031-2196c22b57a3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aee28baa-669b-4a4f-a81c-f990e6e80d3c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8b4ce511-193c-417d-8977-233890e4e568"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2f6c1dae-b173-47ba-95ba-b2e701a463af"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c8148435-ef9c-4c0d-9cf4-a24e9a6bcbb3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ddcaea36-611f-4051-a49b-c40898e53acd"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""29154bdd-2076-4722-bc6f-f3b73156d279"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2880b32-9511-45bb-8070-6ee1ee8a9d96"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8df2fe41-bb98-48e4-b050-8b68c77672ed"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f8c0b5f-9e58-4298-8da7-a16adc1093c0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GravitySwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""070465cc-d943-4348-a886-b514e2d937c1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GravitySwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""138d8183-a2fe-4c04-91db-8d9e803da550"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f7ee4b0-39cc-4cc5-9d1f-d6a4d10ac46e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63cc610b-36f2-4a96-a6bd-49160659d1c6"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4032b819-8349-4d76-ab24-207e2258bf52"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AttackLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75222ac7-711a-4b69-b4a1-aa6bfb6ce133"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb5dd53f-14b9-4670-9503-3358193b3d78"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_HorizontalMovement = m_Player.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Player_VerticalMovement = m_Player.FindAction("VerticalMovement", throwIfNotFound: true);
        m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
        m_Player_GravitySwitch = m_Player.FindAction("GravitySwitch", throwIfNotFound: true);
        m_Player_AttackHigh = m_Player.FindAction("AttackHigh", throwIfNotFound: true);
        m_Player_AttackLow = m_Player.FindAction("AttackLow", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_HorizontalMovement;
    private readonly InputAction m_Player_VerticalMovement;
    private readonly InputAction m_Player_Dash;
    private readonly InputAction m_Player_GravitySwitch;
    private readonly InputAction m_Player_AttackHigh;
    private readonly InputAction m_Player_AttackLow;
    private readonly InputAction m_Player_Interact;
    public struct PlayerActions
    {
        private @MainControls m_Wrapper;
        public PlayerActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Player_HorizontalMovement;
        public InputAction @VerticalMovement => m_Wrapper.m_Player_VerticalMovement;
        public InputAction @Dash => m_Wrapper.m_Player_Dash;
        public InputAction @GravitySwitch => m_Wrapper.m_Player_GravitySwitch;
        public InputAction @AttackHigh => m_Wrapper.m_Player_AttackHigh;
        public InputAction @AttackLow => m_Wrapper.m_Player_AttackLow;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontalMovement;
                @VerticalMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVerticalMovement;
                @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @GravitySwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGravitySwitch;
                @GravitySwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGravitySwitch;
                @GravitySwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGravitySwitch;
                @AttackHigh.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackHigh;
                @AttackHigh.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackHigh;
                @AttackHigh.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackHigh;
                @AttackLow.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackLow;
                @AttackLow.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackLow;
                @AttackLow.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackLow;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @VerticalMovement.started += instance.OnVerticalMovement;
                @VerticalMovement.performed += instance.OnVerticalMovement;
                @VerticalMovement.canceled += instance.OnVerticalMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @GravitySwitch.started += instance.OnGravitySwitch;
                @GravitySwitch.performed += instance.OnGravitySwitch;
                @GravitySwitch.canceled += instance.OnGravitySwitch;
                @AttackHigh.started += instance.OnAttackHigh;
                @AttackHigh.performed += instance.OnAttackHigh;
                @AttackHigh.canceled += instance.OnAttackHigh;
                @AttackLow.started += instance.OnAttackLow;
                @AttackLow.performed += instance.OnAttackLow;
                @AttackLow.canceled += instance.OnAttackLow;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnVerticalMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnGravitySwitch(InputAction.CallbackContext context);
        void OnAttackHigh(InputAction.CallbackContext context);
        void OnAttackLow(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
