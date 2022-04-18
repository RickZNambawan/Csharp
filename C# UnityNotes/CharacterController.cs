using UnityEngine;

public class PlayerController : MonoBehaviour {

  // Animator Component Class
  // to access the Animator Component
  // need first to reference the Animator Component to the property of the Script component
  public Animator myAnimator;
  public Rigidbody2D rigidbody2d;
  private float horizontalMove = 0f;
  [Range(0, 100)] public float runSpeed = 5f;

  void Update() {
    // to move/run/walk
    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; // the movement and speed for horizontal move
    verticalMove = Input.GetAxisRaw("Vertical") * runSpeed; // the movement and speed for vertical move
    myAnimator.SetFloat("MovementSpeed", (horizontalMove)); // to set the parameter you made in Animator
    transform.position = new Vector2((transform.position.x + (horizontalMove * Time.deltaTime)), (transform.position.y + (verticalMove * Time.deltaTime))); // to move to Horizontal axis

    // jump
    if(Input.GetKeyDown(KeyCode.Space)) {
      rigidbody2d.velocity = Vector2.up * jumpVelocity;
    }
  }
}
