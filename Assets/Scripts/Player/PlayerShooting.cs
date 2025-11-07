using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject Bullet;

    public void OnShooting(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        Instantiate(Bullet,transform.position, transform.Find("Body").rotation);
        
    }
    
}
