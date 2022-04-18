using UnityEngine;

public class SpriteComponent : MonoBehaviour {

  // need to have first a sprite component before creating manual sprite render
  public Sprite robotSprite; // to create Sprite Reference Property in the Script Component
  public Sprite anotherSprite; // to create another sprite reference property in the script component
  public Color newColor; // to create Color Reference Property in the Script Component

  void Start() {
    // access the SpriteRenderer Component of the object
    SpriteRenderer mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    mySpriteRenderer.sprite = robotSprite; // place the reference property of Sprite Renderer in script component
    mySpriteRenderer.color = newColor;

    CreateAnotherSprite();
  }

    // manually creating a game object and adding sprite renderer to script component
  void CreateAnotherSprite() {
    GameObject secondRobot = new GameObject("SecondRobot", typeof(SpriteRenderer));
    SpriteRenderer secondRobotSprite = secondRobot.GetComponent<SpriteRenderer>();
    secondRobotSprite.sprite = anotherSprite;
  }
}
