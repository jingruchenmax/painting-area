// GENERATED AUTOMATICALLY FROM 'Assets/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""XboxController"",
            ""id"": ""220d7c84-e656-4c5a-b8d6-654c5687df67"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""efc16eb1-c065-4887-9dfa-a028dd3a65e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""21235b8e-6ae8-4275-bb54-eb224dfbc871"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""d029726d-9b9e-49f7-ba16-ec5d3c0093c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""787526b8-9eaa-4584-8001-71d92e465d69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NewGame"",
                    ""type"": ""Button"",
                    ""id"": ""a2712df9-a8e6-46a8-a63a-0bd9edd11622"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b997a9df-dbdd-4a91-93e3-fca9d62795d4"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c547084-c590-45e1-b818-bf68d9379192"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ff92977-4faa-4673-bd71-8b82bfeb579c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37c7e4f0-6408-4789-9222-54a50691d749"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cca13031-5534-4116-a550-990f98491f78"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ba286dc-5479-4f29-ab7e-fd5b753ab309"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33ca9400-b62d-4a38-82d9-587cfe9807ac"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65a5cd16-4e55-4815-bde3-6f1c3da2fd56"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39f3c0af-2ffc-45f9-a5ae-afaa86267bc1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""220df8c9-88b1-484a-9845-61856df1905a"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c57cb911-d954-4e4e-bc38-74360eef8ba7"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcc289e7-0af2-4d0e-90aa-d83ac2dfe1c2"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe7bf590-e36a-4ede-9cb4-8b2fee571b94"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""009f709a-f401-4f71-8118-1c43248da88c"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f48ba261-fde2-48c9-a96e-376fbb8ab071"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32c14651-c7e7-44c9-ae71-2931c0e3249f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed3ba4b0-d365-4e48-b1d7-68036df38da9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""NewGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10cf7e32-b88f-4659-b1b7-741d87f41d78"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""NewGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""xbox"",
            ""bindingGroup"": ""xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // XboxController
        m_XboxController = asset.FindActionMap("XboxController", throwIfNotFound: true);
        m_XboxController_Left = m_XboxController.FindAction("Left", throwIfNotFound: true);
        m_XboxController_Right = m_XboxController.FindAction("Right", throwIfNotFound: true);
        m_XboxController_Up = m_XboxController.FindAction("Up", throwIfNotFound: true);
        m_XboxController_Down = m_XboxController.FindAction("Down", throwIfNotFound: true);
        m_XboxController_NewGame = m_XboxController.FindAction("NewGame", throwIfNotFound: true);
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

    // XboxController
    private readonly InputActionMap m_XboxController;
    private IXboxControllerActions m_XboxControllerActionsCallbackInterface;
    private readonly InputAction m_XboxController_Left;
    private readonly InputAction m_XboxController_Right;
    private readonly InputAction m_XboxController_Up;
    private readonly InputAction m_XboxController_Down;
    private readonly InputAction m_XboxController_NewGame;
    public struct XboxControllerActions
    {
        private @InputController m_Wrapper;
        public XboxControllerActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_XboxController_Left;
        public InputAction @Right => m_Wrapper.m_XboxController_Right;
        public InputAction @Up => m_Wrapper.m_XboxController_Up;
        public InputAction @Down => m_Wrapper.m_XboxController_Down;
        public InputAction @NewGame => m_Wrapper.m_XboxController_NewGame;
        public InputActionMap Get() { return m_Wrapper.m_XboxController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XboxControllerActions set) { return set.Get(); }
        public void SetCallbacks(IXboxControllerActions instance)
        {
            if (m_Wrapper.m_XboxControllerActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnRight;
                @Up.started -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnDown;
                @NewGame.started -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnNewGame;
                @NewGame.performed -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnNewGame;
                @NewGame.canceled -= m_Wrapper.m_XboxControllerActionsCallbackInterface.OnNewGame;
            }
            m_Wrapper.m_XboxControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @NewGame.started += instance.OnNewGame;
                @NewGame.performed += instance.OnNewGame;
                @NewGame.canceled += instance.OnNewGame;
            }
        }
    }
    public XboxControllerActions @XboxController => new XboxControllerActions(this);
    private int m_xboxSchemeIndex = -1;
    public InputControlScheme xboxScheme
    {
        get
        {
            if (m_xboxSchemeIndex == -1) m_xboxSchemeIndex = asset.FindControlSchemeIndex("xbox");
            return asset.controlSchemes[m_xboxSchemeIndex];
        }
    }
    public interface IXboxControllerActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnNewGame(InputAction.CallbackContext context);
    }
}
