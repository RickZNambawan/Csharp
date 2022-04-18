using UnityEngine;

public class TheGameObject : MonoBehaviour {
  // access modifier default to private if not specify.
  // if access modifier set to public, it will show in inspector

  void Start() {
      // to create a gameObject and add component seprately.
      GameObject oneObj = new GameObject("Frederick"); // to create gameObject manually with name.
      oneObj.AddComponent<SpriteRenderer>(); // to add component to the object.

      // if you want to add quickly the components you want on your gameObject.
      GameObject secondObj = new GameObject("Lyka", typeof(BoxCollider2D)));
      GameObject thirdObj = new GameObject("Florante", typeof(SpriteRenderer), typeof(BoxCollider2D)));
  }
}
