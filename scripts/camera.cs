using UnityEngine;


//This script makes the camera follow the player freely
public class camera : MonoBehaviour
{
    //Creates a target object which allows you to follow the player
    public Transform target;

    //Creates a Vector3 variable which allows you to adjust xyz postions
    public Vector3 offset;

    void Update()
    {
        //Sets the camera position equal to the player position with an offset of 10 so the camera is not on the same plane as the player
        //If that occurs you will not be able to see the game environment
        transform.position = target.position + offset;
    }
}
