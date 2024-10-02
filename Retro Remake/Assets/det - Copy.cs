using UnityEngine;

public class Detcopy : MonoBehaviour
{
    void OnCollisionEnter3D(Collision collision)
    {
        if (collision.gameObject.CompareTag("destroyable"))
        {
            Debug.Log("I am touching Target");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        {
        }
    }
    }
}