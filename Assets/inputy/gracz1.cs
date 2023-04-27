// GENERATED AUTOMATICALLY FROM 'Assets/inputy/gracz1.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Gracz1 : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Gracz1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""gracz1"",
    ""maps"": [
        {
            ""name"": ""gracz1"",
            ""id"": ""173fc898-74e5-4546-b149-9e1ffc0ae462"",
            ""actions"": [
                {
                    ""name"": ""poruszanie"",
                    ""type"": ""Value"",
                    ""id"": ""c03c8200-5b41-4c1d-b197-9c63973cfcf7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""atak"",
                    ""type"": ""Button"",
                    ""id"": ""fc56ff50-523d-4af3-9898-237b5414eea2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wsad"",
                    ""id"": ""d07dfd28-1d7b-4678-be73-95e33a1d1f63"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b767472e-51d7-4a64-9223-3e6701ea7d5b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""362933d1-1c12-46db-8237-72d766266441"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de1ac5c3-4381-4bd4-8124-ab3540663624"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b0dafb9-2b4f-4f5c-b4bf-2d850d4fe28f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f35bd727-e727-46aa-a6dd-0184c1fc05b8"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0fc5e26-bf98-4ce7-8bba-93e7e00b667f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""atak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""gracz2"",
            ""id"": ""ddb50e86-d4d4-45c9-9dc5-8ae7098d4bf5"",
            ""actions"": [
                {
                    ""name"": ""poruszanie"",
                    ""type"": ""Value"",
                    ""id"": ""45aefb57-77bb-4aa9-8da4-74465630ab18"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""atak"",
                    ""type"": ""Button"",
                    ""id"": ""8a709365-e3f0-438b-8f57-09bf7b7800e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""strzalki"",
                    ""id"": ""36d1723a-6e20-4e21-b3a5-2cfc56337f64"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8a18888c-99ae-4ef6-a9a2-6ba6f849dd8f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85a59ef0-a792-486b-a793-cbf4a2d2eebc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aaeca48d-6284-44d7-9df2-ede9b3258dfd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0d985482-dc68-4576-b710-cd1d03b975ce"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5fad9dd5-3e8c-429f-af9a-aaa58008387c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""poruszanie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e99e70c-b6f2-4e73-9d9f-1f69ed9d9198"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""atak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gracz1
        m_gracz1 = asset.FindActionMap("gracz1", throwIfNotFound: true);
        m_gracz1_poruszanie = m_gracz1.FindAction("poruszanie", throwIfNotFound: true);
        m_gracz1_atak = m_gracz1.FindAction("atak", throwIfNotFound: true);
        // gracz2
        m_gracz2 = asset.FindActionMap("gracz2", throwIfNotFound: true);
        m_gracz2_poruszanie = m_gracz2.FindAction("poruszanie", throwIfNotFound: true);
        m_gracz2_atak = m_gracz2.FindAction("atak", throwIfNotFound: true);
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

    // gracz1
    private readonly InputActionMap m_gracz1;
    private IGracz1Actions m_Gracz1ActionsCallbackInterface;
    private readonly InputAction m_gracz1_poruszanie;
    private readonly InputAction m_gracz1_atak;
    public struct Gracz1Actions
    {
        private @Gracz1 m_Wrapper;
        public Gracz1Actions(@Gracz1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @poruszanie => m_Wrapper.m_gracz1_poruszanie;
        public InputAction @atak => m_Wrapper.m_gracz1_atak;
        public InputActionMap Get() { return m_Wrapper.m_gracz1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Gracz1Actions set) { return set.Get(); }
        public void SetCallbacks(IGracz1Actions instance)
        {
            if (m_Wrapper.m_Gracz1ActionsCallbackInterface != null)
            {
                @poruszanie.started -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnPoruszanie;
                @poruszanie.performed -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnPoruszanie;
                @poruszanie.canceled -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnPoruszanie;
                @atak.started -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnAtak;
                @atak.performed -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnAtak;
                @atak.canceled -= m_Wrapper.m_Gracz1ActionsCallbackInterface.OnAtak;
            }
            m_Wrapper.m_Gracz1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @poruszanie.started += instance.OnPoruszanie;
                @poruszanie.performed += instance.OnPoruszanie;
                @poruszanie.canceled += instance.OnPoruszanie;
                @atak.started += instance.OnAtak;
                @atak.performed += instance.OnAtak;
                @atak.canceled += instance.OnAtak;
            }
        }
    }
    public Gracz1Actions @gracz1 => new Gracz1Actions(this);

    // gracz2
    private readonly InputActionMap m_gracz2;
    private IGracz2Actions m_Gracz2ActionsCallbackInterface;
    private readonly InputAction m_gracz2_poruszanie;
    private readonly InputAction m_gracz2_atak;
    public struct Gracz2Actions
    {
        private @Gracz1 m_Wrapper;
        public Gracz2Actions(@Gracz1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @poruszanie => m_Wrapper.m_gracz2_poruszanie;
        public InputAction @atak => m_Wrapper.m_gracz2_atak;
        public InputActionMap Get() { return m_Wrapper.m_gracz2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Gracz2Actions set) { return set.Get(); }
        public void SetCallbacks(IGracz2Actions instance)
        {
            if (m_Wrapper.m_Gracz2ActionsCallbackInterface != null)
            {
                @poruszanie.started -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnPoruszanie;
                @poruszanie.performed -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnPoruszanie;
                @poruszanie.canceled -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnPoruszanie;
                @atak.started -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnAtak;
                @atak.performed -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnAtak;
                @atak.canceled -= m_Wrapper.m_Gracz2ActionsCallbackInterface.OnAtak;
            }
            m_Wrapper.m_Gracz2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @poruszanie.started += instance.OnPoruszanie;
                @poruszanie.performed += instance.OnPoruszanie;
                @poruszanie.canceled += instance.OnPoruszanie;
                @atak.started += instance.OnAtak;
                @atak.performed += instance.OnAtak;
                @atak.canceled += instance.OnAtak;
            }
        }
    }
    public Gracz2Actions @gracz2 => new Gracz2Actions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    public interface IGracz1Actions
    {
        void OnPoruszanie(InputAction.CallbackContext context);
        void OnAtak(InputAction.CallbackContext context);
    }
    public interface IGracz2Actions
    {
        void OnPoruszanie(InputAction.CallbackContext context);
        void OnAtak(InputAction.CallbackContext context);
    }
}
