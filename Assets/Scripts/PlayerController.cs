using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] InputAction movement;
    [SerializeField] float torqueSpeed = 5f;
    SurfaceEffector2D surfaceffector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceffector = FindObjectOfType<SurfaceEffector2D>();
    }
    public void Disable()
    {
        FindObjectOfType<PlayerController>().enabled = false;
        surfaceffector.speed = 0;
    }
    void OnEnable()
    {
        movement.Enable();
    }

    void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
        float horizonatalForce = movement.ReadValue<Vector2>().x;
        rb.AddTorque(-horizonatalForce * ( torqueSpeed * Time.deltaTime));
    }
}
