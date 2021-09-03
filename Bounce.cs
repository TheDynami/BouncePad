using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce;

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector2.up * bounceForce, ForceMode.Impulse);
    }
}
