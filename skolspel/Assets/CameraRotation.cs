using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] private InputActionReference controls;
    [SerializeField] private float rotationspeed; 

    Vector2 angles = new Vector2(0f, 0f);


    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        input *= rotationspeed;

        
        angles.y += input.x;
        angles.x += -input.y;
        angles.x = Mathf.Clamp(angles.x, -90, 90);

        Vector3 rotation = new Vector3(angles.x, angles.y, 0f);
        transform.rotation = Quaternion.Euler(rotation);

    }
}
