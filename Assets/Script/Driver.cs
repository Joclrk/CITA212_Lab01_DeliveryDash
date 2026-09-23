using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float Steer = 200f;
    [SerializeField] float CurrentSpeed = 10f;
    [SerializeField] float BoostSpeed = 20f;
    [SerializeField] float BaseSpeed = 10f;
    [SerializeField] TMP_Text BoostText;

    void Start() 
    {
        BoostText.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
       if (Collision.CompareTag("Boost"))
        {
            CurrentSpeed = BoostSpeed;
            BoostText.gameObject.SetActive(true);
            Destroy(Collision.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        CurrentSpeed = BaseSpeed;
        BoostText.gameObject.SetActive(false);
    }

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
            Cspeed = -1f;
        }
        //Calculated variable to make editing easier at a later time
        float spdAmount = CurrentSpeed * Cspeed * Time.deltaTime;
        float strAmount = Steer * Csteer * Time.deltaTime;

        transform.Rotate(0, 0,strAmount);
        transform.Translate(0,spdAmount,0);
    }
}
