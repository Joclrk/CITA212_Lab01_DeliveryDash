using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steer = 0.5f;
    [SerializeField] float speed = 0.05f;
   

    void Start()
    {
        //transform.Rotate(0, 0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0,steer);
        transform.Translate(0,speed,0);
    }
}
