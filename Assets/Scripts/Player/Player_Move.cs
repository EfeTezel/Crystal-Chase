using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour
{
    private Vector2 moveInput;
    
    void Start()
    {
        
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector2 vector2d = new Vector2(transform.position.x + (moveInput.x * 0.01f), transform.position.y + (moveInput.y * 0.01f));
        
        transform.position = vector2d;
    }
}
