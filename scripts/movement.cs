using UnityEngine;
//imports the scene manager which allows you to change scenes from this script
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //global variable for controlling different elements of the game
   public float MovementSpeed = 1;
   public float JumpForce = 1;
   public float respawnHeight = 50;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        //Creates a rigidbody variable that we can use and compare against
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //This function allows the player to move and jump along with handling screen changes and reloads based on player location
    private void Update()
    {

        //Tells the game that we will be moving along the x axis(horizontal)
        var movement = Input.GetAxis("Horizontal");


        //Tells the game how much to move the character based on these variables
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;


        //If you press down spacebar and the character is not moving or falling then it will jump
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {

            //Adds verticle force to the character so it will jump. This is based on the JumpForce variable that can be changed in the character inspector
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            
        }

        //If the character is below the respawn height it will be taken back to the beginning of the game
        if (transform.position.y < respawnHeight)
        {

            //reloads the scene taking the character back to the beginning
            SceneManager.LoadScene("level1");
        }

        //If the character is between x=-30 and x=-28 and it is still then you will be taken back to the menu
        if (transform.position.x > -30 && transform.position.x <-28 && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            SceneManager.LoadScene("menu");
        }

    }


}
