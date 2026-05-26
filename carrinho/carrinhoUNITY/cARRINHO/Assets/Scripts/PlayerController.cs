using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float verticalInput;
    private float horizontalInput;
    private InputAction moveAction;
    [SerializeField] InputActionAsset inputAction;
    
    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        horizontalInput = moveInput.x;
        verticalInput = moveInput.y;
        if (verticalInput > 0)
        {
            // Move o ve�culo para frente a partir do Input vertical
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        }
        // Rotaciona o carro a partir do Input horizontal
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    void Awake()
    {
        
        moveAction = inputAction.FindAction("Move");

    }
}
