using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    // public shows any variable or function 
    // into the editor (usually uppercase them to know the difference)

    //float variable that assigns the vertical speed(movement) of player
    public float SpdX;

    // float variable that assigns the horizontal speed (movement) of player
    public float SpdY;
    public string InputAxisNameVert;
    public string InputAxisNameHori;

    private Rigidbody2D MyRigidBody2D;   

    // Start is called before the first frame update
    void Start()
    {
        // anything that uses () that isn't a function is a method
        MyRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        // // create a float variable that gets input strings' value 
        // // from the input manager in the editor
        // float directionVert = Input.GetAxis(InputAxisNameVert);
        // float directionHori = Input.GetAxis(InputAxisNameHori);

        // // a 2D vector (x,y) variable that assigns a new Vector2 for the velocity
        // Vector2 velVert = new Vector2(0f, directionVert);
        // Vector2 velHori = new Vector2(directionHori, 0f);

        // // . calls any properties associated with variables, methods, etc. in 
        // // in this case, calls the values on the x or y coordinates of each direction
        // // vel.x *= SpdX;
        // // vel.y *= SpdY;

        // velHori.x *= SpdX;
        // velVert.y *= SpdY;

        // /* to add speed to movement later
        // if () {

        // }*/

        // //calls the rigidbody2d variable's property velocity and assigns vel variable to it
        // // r2d.velocity = vel;

        // // if (Input.GetAxis("PlayerMoveHori") > 0f) {

        // //     // rigidbody2d variable calls a method that requires 
        // //     // transform (where object change on coords) which 
        // //     // multiplied by the x axis values timed the mentioned input's value
        // //     r2d.AddForce(transform.right * (SpdX * Input.GetAxis("PlayerMoveHori")));
        // // }

        // // if (Input.GetAxis("PlayerMoveHori") < 0f) {
        // //     r2d.AddForce(-transform.right * (-SpdX * Input.GetAxis("PlayerMoveHori")));
        // // }
    }

    void PlayerMove() {
        float directionHori = Input.GetAxis(InputAxisNameHori);
        float directionVert = Input.GetAxis(InputAxisNameVert);
        Vector2 vel = new Vector2(directionHori, directionVert);

        MyRigidBody2D.velocity = vel;
    }
}
