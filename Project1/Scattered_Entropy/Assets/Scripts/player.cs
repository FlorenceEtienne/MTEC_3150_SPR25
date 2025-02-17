using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
    
{
    // public shows any variable or function 
    // into the editor (usually uppercase them to know the difference)

    //float variable that assigns the vertical speed(movement) of player
    public float SpdX;

    // float variable that assigns the horizontal speed (movement) of player
    public float SpdY;
    public string InputAxisNameVert;
    public string InputAxisNameHori;

    public Rigidbody2D r2d;   

    // Start is called before the first frame update
    void Start()
    {
        // anything that uses () that isn't a function is a method
        r2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // create a float variable that gets input strings' value 
        // from the input manager in the editor
        float directionVert = Input.GetAxis(InputAxisNameVert);
        float directionHori = Input.GetAxis(InputAxisNameHori);

        // a 2D vector (x,y) variable that assigns a new Vector2 for the velocity
        Vector2 vel = new Vector2(directionHori, directionVert);

        // . calls any properties associated with variables, methods, etc.
        vel.x *= SpdX;
        vel.y *= SpdY;
    }
}
