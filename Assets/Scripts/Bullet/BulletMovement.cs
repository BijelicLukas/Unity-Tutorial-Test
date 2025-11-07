using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float LifeSpan;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
        if(LifeSpan <= 0) Destroy(gameObject);
        LifeSpan -= Time.deltaTime;
    }
}
