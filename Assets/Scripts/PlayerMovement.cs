using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick_player;
    public float speed;

    float xMovement , zMovement;
    [Tooltip ("enable it if you want to use your keyboard's arrow keys as a joystick too.")]
    public bool ArrowKeysSimulationEnabled = false ;

    void Update()
    {
        if(ArrowKeysSimulationEnabled)
        {
           xMovement=Input.GetAxis ("Horizontal");
           zMovement=Input.GetAxis ("Vertical");
        }
         else
        {
          xMovement=joystick_player.Horizontal;
          zMovement=joystick_player.Vertical;
        }
        

        transform.position += new Vector3(xMovement , 0 , zMovement) * speed * Time.deltaTime;
    }
}
