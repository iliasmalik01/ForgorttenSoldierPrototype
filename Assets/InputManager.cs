using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Controls controls;
    AnimatorManager animatorManager;

    public Vector2 movementInput;
    private float moveAmount;
    public float verticalInput;
    public float horizontalInput;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
    }

    private void OnEnable()
    {
        if (controls == null)
        {
            controls = new Controls();
            controls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        
        }

        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        //Handleotherstufflater
    }
    
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        animatorManager.UpdateAnimatorValues(0, moveAmount);
    }
}
