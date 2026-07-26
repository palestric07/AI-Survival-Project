using UnityEngine;
public class PlayerController : MonoBehaviour
{

    [SerializeField] 
    private float moveSpeed = 5.0f;

    void Start()
    {
        
    }
    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
 