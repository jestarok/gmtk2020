// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControll.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControll : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControll"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""42dc5bd3-2b53-4c17-922d-60cc9c6663ec"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""104d97db-6476-4d27-8fe9-c8b1b3baa762"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveLight"",
                    ""type"": ""Value"",
                    ""id"": ""cb851cca-ef6c-460d-93fb-340961878af7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d4b4f446-3da5-40d0-a419-5abd8547d267"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button1"",
                    ""type"": ""Button"",
                    ""id"": ""0c1e22df-92bc-42fa-9a83-415bc0701dbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button2"",
                    ""type"": ""Button"",
                    ""id"": ""15ad0c55-592d-4876-8451-75d673093ca6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button3"",
                    ""type"": ""Button"",
                    ""id"": ""8a53e76b-9ffa-43c5-985b-2adc0060713a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button4"",
                    ""type"": ""Button"",
                    ""id"": ""ba5452df-41ac-406c-824c-38165fcacd38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button5"",
                    ""type"": ""Button"",
                    ""id"": ""eddff69a-3225-4c85-ba1e-40c8b1bab311"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button6"",
                    ""type"": ""Button"",
                    ""id"": ""0a376022-66e1-4406-8769-a19ea8b11172"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button7"",
                    ""type"": ""Button"",
                    ""id"": ""bf688dd9-ac3a-4b00-9aa2-6be339076b07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button8"",
                    ""type"": ""Button"",
                    ""id"": ""607d935b-13fd-46fe-a2a7-24409c88498b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button9"",
                    ""type"": ""Button"",
                    ""id"": ""c658dfaf-ccb6-4c70-9ef7-7f3272b9efbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button10"",
                    ""type"": ""Button"",
                    ""id"": ""3a8c1364-4b13-4199-97c6-1c8adc561196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button11"",
                    ""type"": ""Button"",
                    ""id"": ""9aeca7a2-2a4d-4baa-a188-b439b5e4a974"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button12"",
                    ""type"": ""Button"",
                    ""id"": ""80cc031a-d58a-44ff-bf4f-ca861f0474cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7259ccd-a277-43b2-8c6c-c902d95bd59d"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""97a4d795-e25e-4969-b23c-a3e4492beda3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f10ccc94-db4e-478c-b408-8cce14dea03f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""86ec183c-127a-4d1f-9d0e-896c52c19621"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""83221d3b-51bc-4049-bda5-cb1478da19f1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b051b8b4-b5e6-4b90-a5f9-c33cc291f45d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""42c15659-2596-403d-8833-e2bb955ab82d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26b59b8c-9ab4-49a1-bf7f-d34bc1b0f236"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6d4bb599-f393-4704-9ea5-f5dc5b8cf96e"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1dada71c-ebad-4a3b-a0ab-61d6904dca6a"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f42bcf85-1ef1-489c-881e-67fa3525c65e"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f779bd59-ec01-4e2a-a270-66bb26db329f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f3458db-134f-4cfb-ab64-e6d5f8eb7f96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc8fa630-b4c6-44c1-91fc-5de339d572dd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e078e5ff-4079-42a0-8202-383c3d2776df"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c4b1c9e0-a264-4694-9c04-03d482dac8f4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""135a422f-cd25-4a4d-828b-79ab35a774d0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c355de0e-39cf-4208-b6ba-7e051d106c85"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd9965ac-c6f5-476e-85c3-b2711dfe032a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ba9f0fc-2aa0-4466-a4e1-799fd0d9f2ce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3431850d-2824-455c-b096-76e45a991b9d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6503351e-af26-4e22-956b-136a26b7d34e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0457f3a7-c88f-4d62-9946-bab07a04355f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34889f1f-a7f5-4a77-9b95-4fba1226d33a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eb8237e-ffc6-4b32-ae22-9247812d84f5"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73ea9b1f-0b7d-4f4a-adbf-df5e9e443b5b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7ea0cfb-4900-44f2-a833-36d4413b460d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41e42995-1496-46e0-86a5-abfceea5571d"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button10"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""679c2969-1a38-4422-adee-0c1f211257d3"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button11"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35a8f430-70f2-4818-98bf-63f590a24e22"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button12"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_move = m_Gameplay.FindAction("move", throwIfNotFound: true);
        m_Gameplay_moveLight = m_Gameplay.FindAction("moveLight", throwIfNotFound: true);
        m_Gameplay_shoot = m_Gameplay.FindAction("shoot", throwIfNotFound: true);
        m_Gameplay_Button1 = m_Gameplay.FindAction("Button1", throwIfNotFound: true);
        m_Gameplay_Button2 = m_Gameplay.FindAction("Button2", throwIfNotFound: true);
        m_Gameplay_Button3 = m_Gameplay.FindAction("Button3", throwIfNotFound: true);
        m_Gameplay_Button4 = m_Gameplay.FindAction("Button4", throwIfNotFound: true);
        m_Gameplay_Button5 = m_Gameplay.FindAction("Button5", throwIfNotFound: true);
        m_Gameplay_Button6 = m_Gameplay.FindAction("Button6", throwIfNotFound: true);
        m_Gameplay_Button7 = m_Gameplay.FindAction("Button7", throwIfNotFound: true);
        m_Gameplay_Button8 = m_Gameplay.FindAction("Button8", throwIfNotFound: true);
        m_Gameplay_Button9 = m_Gameplay.FindAction("Button9", throwIfNotFound: true);
        m_Gameplay_Button10 = m_Gameplay.FindAction("Button10", throwIfNotFound: true);
        m_Gameplay_Button11 = m_Gameplay.FindAction("Button11", throwIfNotFound: true);
        m_Gameplay_Button12 = m_Gameplay.FindAction("Button12", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_move;
    private readonly InputAction m_Gameplay_moveLight;
    private readonly InputAction m_Gameplay_shoot;
    private readonly InputAction m_Gameplay_Button1;
    private readonly InputAction m_Gameplay_Button2;
    private readonly InputAction m_Gameplay_Button3;
    private readonly InputAction m_Gameplay_Button4;
    private readonly InputAction m_Gameplay_Button5;
    private readonly InputAction m_Gameplay_Button6;
    private readonly InputAction m_Gameplay_Button7;
    private readonly InputAction m_Gameplay_Button8;
    private readonly InputAction m_Gameplay_Button9;
    private readonly InputAction m_Gameplay_Button10;
    private readonly InputAction m_Gameplay_Button11;
    private readonly InputAction m_Gameplay_Button12;
    public struct GameplayActions
    {
        private @PlayerControll m_Wrapper;
        public GameplayActions(@PlayerControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Gameplay_move;
        public InputAction @moveLight => m_Wrapper.m_Gameplay_moveLight;
        public InputAction @shoot => m_Wrapper.m_Gameplay_shoot;
        public InputAction @Button1 => m_Wrapper.m_Gameplay_Button1;
        public InputAction @Button2 => m_Wrapper.m_Gameplay_Button2;
        public InputAction @Button3 => m_Wrapper.m_Gameplay_Button3;
        public InputAction @Button4 => m_Wrapper.m_Gameplay_Button4;
        public InputAction @Button5 => m_Wrapper.m_Gameplay_Button5;
        public InputAction @Button6 => m_Wrapper.m_Gameplay_Button6;
        public InputAction @Button7 => m_Wrapper.m_Gameplay_Button7;
        public InputAction @Button8 => m_Wrapper.m_Gameplay_Button8;
        public InputAction @Button9 => m_Wrapper.m_Gameplay_Button9;
        public InputAction @Button10 => m_Wrapper.m_Gameplay_Button10;
        public InputAction @Button11 => m_Wrapper.m_Gameplay_Button11;
        public InputAction @Button12 => m_Wrapper.m_Gameplay_Button12;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @moveLight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLight;
                @moveLight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLight;
                @moveLight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLight;
                @shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Button1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1;
                @Button1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1;
                @Button1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1;
                @Button2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2;
                @Button2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2;
                @Button2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2;
                @Button3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton3;
                @Button3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton3;
                @Button3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton3;
                @Button4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton4;
                @Button4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton4;
                @Button4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton4;
                @Button5.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton5;
                @Button5.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton5;
                @Button5.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton5;
                @Button6.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton6;
                @Button6.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton6;
                @Button6.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton6;
                @Button7.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton7;
                @Button7.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton7;
                @Button7.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton7;
                @Button8.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton8;
                @Button8.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton8;
                @Button8.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton8;
                @Button9.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton9;
                @Button9.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton9;
                @Button9.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton9;
                @Button10.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton10;
                @Button10.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton10;
                @Button10.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton10;
                @Button11.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton11;
                @Button11.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton11;
                @Button11.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton11;
                @Button12.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton12;
                @Button12.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton12;
                @Button12.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton12;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @moveLight.started += instance.OnMoveLight;
                @moveLight.performed += instance.OnMoveLight;
                @moveLight.canceled += instance.OnMoveLight;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @Button1.started += instance.OnButton1;
                @Button1.performed += instance.OnButton1;
                @Button1.canceled += instance.OnButton1;
                @Button2.started += instance.OnButton2;
                @Button2.performed += instance.OnButton2;
                @Button2.canceled += instance.OnButton2;
                @Button3.started += instance.OnButton3;
                @Button3.performed += instance.OnButton3;
                @Button3.canceled += instance.OnButton3;
                @Button4.started += instance.OnButton4;
                @Button4.performed += instance.OnButton4;
                @Button4.canceled += instance.OnButton4;
                @Button5.started += instance.OnButton5;
                @Button5.performed += instance.OnButton5;
                @Button5.canceled += instance.OnButton5;
                @Button6.started += instance.OnButton6;
                @Button6.performed += instance.OnButton6;
                @Button6.canceled += instance.OnButton6;
                @Button7.started += instance.OnButton7;
                @Button7.performed += instance.OnButton7;
                @Button7.canceled += instance.OnButton7;
                @Button8.started += instance.OnButton8;
                @Button8.performed += instance.OnButton8;
                @Button8.canceled += instance.OnButton8;
                @Button9.started += instance.OnButton9;
                @Button9.performed += instance.OnButton9;
                @Button9.canceled += instance.OnButton9;
                @Button10.started += instance.OnButton10;
                @Button10.performed += instance.OnButton10;
                @Button10.canceled += instance.OnButton10;
                @Button11.started += instance.OnButton11;
                @Button11.performed += instance.OnButton11;
                @Button11.canceled += instance.OnButton11;
                @Button12.started += instance.OnButton12;
                @Button12.performed += instance.OnButton12;
                @Button12.canceled += instance.OnButton12;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveLight(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnButton1(InputAction.CallbackContext context);
        void OnButton2(InputAction.CallbackContext context);
        void OnButton3(InputAction.CallbackContext context);
        void OnButton4(InputAction.CallbackContext context);
        void OnButton5(InputAction.CallbackContext context);
        void OnButton6(InputAction.CallbackContext context);
        void OnButton7(InputAction.CallbackContext context);
        void OnButton8(InputAction.CallbackContext context);
        void OnButton9(InputAction.CallbackContext context);
        void OnButton10(InputAction.CallbackContext context);
        void OnButton11(InputAction.CallbackContext context);
        void OnButton12(InputAction.CallbackContext context);
    }
}
