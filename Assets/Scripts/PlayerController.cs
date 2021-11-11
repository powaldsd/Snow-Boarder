using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] InputAction movement;
    [SerializeField] float torqueSpeed = 5f;
    [SerializeField] float boostSpeed = 2f;
    
    SurfaceEffector2D surfaceffector;
    Player controls;
    void Speeder()
    {
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceffector = FindObjectOfType<SurfaceEffector2D>();
        
        controls = new Player();

        controls.GameAction.SpeedUp.performed += ctx => Speeder();
    }
    void OnEnable()
    {
        controls.GameAction.Enable();
        movement.Enable();
    }
    void OnDisable()
    {
        controls.GameAction.Disable();
        movement.Disable();
    }
    public void Disable()
    {
        FindObjectOfType<PlayerController>().enabled = false;
        surfaceffector.speed = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Speeder();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        float horizonatalForce = movement.ReadValue<Vector2>().x;
        rb.AddTorque(-horizonatalForce * ( torqueSpeed * Time.deltaTime));
    }
}
