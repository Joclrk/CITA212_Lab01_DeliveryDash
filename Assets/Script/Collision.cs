using UnityEngine;

public class Collision : MonoBehaviour
{
    //float health = 3f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        //health = health - 1f;
        //if (health == 0f)
        //{ 
        //    Destroy(collision.gameObject);
        //}
    }
}
