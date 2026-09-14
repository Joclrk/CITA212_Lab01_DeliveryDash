using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steer = 0.5f;
    [SerializeField] float speed = 0.05f;
    //void Start() useless for now but maybe used later.
    //{
    //}
    void Update()
    {
        //Everchanging variables C = Changing variable
        //right/left
        float Csteer = 0f;
        //up//down
        float Cspeed = 0f;
        //Movement Keys
        if (Keyboard.current.wKey.isPressed)
        {
            Cspeed = 1f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Csteer = -1f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Csteer = 1f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Cspeed = 0f;
        }

        transform.Rotate(0, 0,steer * Csteer);
        transform.Translate(0,speed * Cspeed,0);
    }
}
