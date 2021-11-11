// GENERATED AUTOMATICALLY FROM 'Assets/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""GameAction"",
            ""id"": ""049c96e5-c492-41b1-8bb0-f1e535f92ab9"",
            ""actions"": [
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Button"",
                    ""id"": ""5fede04c-a9c6-43af-a237-b4689809e991"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f23d23b8-bf20-4140-b936-2e4527a38ddf"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameAction
        m_GameAction = asset.FindActionMap("GameAction", throwIfNotFound: true);
        m_GameAction_SpeedUp = m_GameAction.FindAction("SpeedUp", throwIfNotFound: true);
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

    // GameAction
    private readonly InputActionMap m_GameAction;
    private IGameActionActions m_GameActionActionsCallbackInterface;
    private readonly InputAction m_GameAction_SpeedUp;
    public struct GameActionActions
    {
        private @Player m_Wrapper;
        public GameActionActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpeedUp => m_Wrapper.m_GameAction_SpeedUp;
        public InputActionMap Get() { return m_Wrapper.m_GameAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActionActions set) { return set.Get(); }
        public void SetCallbacks(IGameActionActions instance)
        {
            if (m_Wrapper.m_GameActionActionsCallbackInterface != null)
            {
                @SpeedUp.started -= m_Wrapper.m_GameActionActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.performed -= m_Wrapper.m_GameActionActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.canceled -= m_Wrapper.m_GameActionActionsCallbackInterface.OnSpeedUp;
            }
            m_Wrapper.m_GameActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpeedUp.started += instance.OnSpeedUp;
                @SpeedUp.performed += instance.OnSpeedUp;
                @SpeedUp.canceled += instance.OnSpeedUp;
            }
        }
    }
    public GameActionActions @GameAction => new GameActionActions(this);
    public interface IGameActionActions
    {
        void OnSpeedUp(InputAction.CallbackContext context);
    }
}
