using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steer = 20f;
    [SerializeField] float speed = 5f;
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
            if (Keyboard.current.dKey.isPressed)
            {
                Csteer = -1f;
            }
            if (Keyboard.current.aKey.isPressed)
            {
                Csteer = 1f;
            }
        }

        if (Keyboard.current.sKey.isPressed)
        {
            Cspeed = -1f;
        }
        //Calculated variable to make editing easier at a later time
        float spdAmount = speed * Cspeed * Time.deltaTime;
        float strAmount = steer * Csteer * Time.deltaTime;

        transform.Rotate(0, 0,strAmount);
        transform.Translate(0,spdAmount,0);
    }
}
