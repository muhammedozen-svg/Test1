using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform playertransform;
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float rotationspeed; 

    Vector2 angles = new Vector2(0f, 0f);


    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        input *= rotationspeed;

        
        angles.y += input.x;
        angles.x += -input.y;
        angles.x = Mathf.Clamp(angles.x, -18, 90);

        Vector3 camerarotation = new Vector3(angles.x, angles.y, 0f);
        Vector3 playerrotation = new Vector3(0f, angles.y, 0f);
    
        playertransform.rotation = Quaternion.Euler(playerrotation);
        transform.localRotation = Quaternion.Euler(camerarotation);

        transform.position = playertransform.position;

    }
}
