using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool HasPackage;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collision");
    }
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Package") && !HasPackage)
        {
            Debug.Log("package grabbed");
            HasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Custom") && HasPackage)
        {
            Debug.Log("Package Delivered");
            HasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject);
        }
    }
}
