using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float speed = 8f;
    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if(rb != null )
        {
            rb.linearVelocity = new Vector3(speed, 0, 0);
        }
    }
}
