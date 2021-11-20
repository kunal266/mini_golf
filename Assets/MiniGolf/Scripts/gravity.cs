using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

//Declare Variables:
//BBB adding volume calculations
//NOPE
//BBB adding density (...does nothing yet...)
public float density;

//BBB NOPE!

//Strength of attraction from your game-object, ideally this will be derived from a calculation involving the objects volume and density, but for now it's entered from the inspector)
public float RelativeWeight;

//BBB Here, we name our target object (s)
GameObject blockALPHA;

//Initialise code:
void Start () 
{
    //BBB here, we define our target object by searching for its tag (setup in editor)
    blockALPHA = GameObject.FindGameObjectWithTag("Player");
    print(blockALPHA);
}

//Use FixedUpdate because we are controlling the orbit with physics
void FixedUpdate () {
    //Declare Variables:

    //magsqr will be the offset squared between the object and the planet
    float magsqr;

    //offset is the distance to the planet
    Vector3 offset;

    //get offset between each planet and the player
    offset = blockALPHA.transform.position - transform.position;

    //Offset Squared:
    magsqr = offset.sqrMagnitude;

    //Check distance is more than 1 to prevent division by 0 (because my blocks are all 1x1x1 so, any closer than 1 and they'd be intersecting)
    if (magsqr > 1f)
    {
        //Create the gravity- make it realistic through division by the "magsqr" variable

        GetComponent<Rigidbody>().AddForce((RelativeWeight * offset.normalized / magsqr) * GetComponent<Rigidbody>().mass);
    }
}
}