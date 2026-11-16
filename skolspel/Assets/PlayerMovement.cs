using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float speed;

    private float speedMultiplier = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();
        if (input.x != 0 || input.y != 0)
        {
            speedMultiplier = Mathf.Lerp(speedMultiplier, 1, Time.deltaTime);
        }
        else
        {
            speedMultiplier = Mathf.Lerp(speedMultiplier, 0, Time.deltaTime);
        }
        input *= speed * speedMultiplier * Time.deltaTime;
        transform.Translate(input.x, 0, input.y);
    }
}
