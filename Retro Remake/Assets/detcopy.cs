using UnityEngine;

public class detcopy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
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