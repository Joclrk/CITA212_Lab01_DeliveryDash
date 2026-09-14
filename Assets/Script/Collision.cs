using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ouch");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
    }
}
