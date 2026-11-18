using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float speed;
    [SerializeField] private float smoothness;


    private float currentspeedX = 0f;
    private float currentspeedY = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        input *= speed * Time.deltaTime;
        
        currentspeedX = Mathf.Lerp(currentspeedX, input.x, smoothness * Time.deltaTime);
        currentspeedY = Mathf.Lerp(currentspeedY, input.y, smoothness * Time.deltaTime);
        
        transform.Translate(currentspeedX, 0, currentspeedY);
        transform.Rotate(0, 0, currentspeedY);        
    }
}
