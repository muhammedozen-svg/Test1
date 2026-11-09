using UnityEngine;

public class Cubemove : MonoBehaviour
{
    
    [SerializeField]private float xspeed;
    
    
    void Start()
    {
        Debug.Log("Move har startat");
    }

    void Update()
    {
        transform.Translate(0 , 0, xspeed * Time.deltaTime);
    }
}
