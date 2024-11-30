using UnityEngine;
public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && gameObject.CompareTag("Cube"))
        {
            Debug.Log("The asteroid has hit the earth!");
        }
    }
}