using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public enum InputType
{
    Movement,MouseX,MouseY
}

public class PlayerBash : Agent
{
    public static PlayerBash Instance;
    public Dictionary<InputType, UnityAction<InputAction.CallbackContext>> Inputs;

    public PlayerInputSO playerInput;
    public PlayerMoveCompo playerMovement;
    public UnityAction jumpInputAction;

    protected override void Awake()
    {
        
        Instance = this;
        //playerInput = GetComponent<PlayerInputSO>();
        base.Awake();
        playerMovement = GetComponent<PlayerMoveCompo>();
    }

    
}
