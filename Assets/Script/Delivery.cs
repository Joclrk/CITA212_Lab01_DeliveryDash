using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool HasPackage;
    //float health = 3f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collision");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("package grabbed");
            HasPackage = true;
        }
        if (collision.CompareTag("Custom") && HasPackage)
        {
            Debug.Log("Package Delivered");
            HasPackage = false;
        }
    }
}
