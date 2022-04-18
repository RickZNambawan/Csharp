using UnityEngine;

public class TransformComponent : MonoBehaviour {
  // every gameObject has a Transform Component
  // meaning it is already instantiated with a reference variable of 'transform'
  // no need to create an object of Transform

  /* In 2D Design:
     - You can only position the object with X and Y coordinates.
     - You can only rotate the object by its Z coordinates.
     - In scale, the size of the object dependent on the sprites when imported.
  */

  // Start is called before the first frame update
  void Start() {

    /* for global space */
    // transform.position; // to access the x, y, z direction of an object
    // transform.eulerAngles; // to access the x, y, z rotation of an object
    // transform.localScale; // to access the x, y, z scale of an object

    /* for local space */
    // transform.localPosition;
    // transform.localEulerAngles;
    // transform.localScale;

    // to change the x, y, z of an object
    // transform.position = new Vector3(0, 0, 0);
    // transform.eulerAngles = new Vector3(0, 0, 0);
    // transform.localScale = new Vector3(0, 0, 0);

    // for parenting : local space vs global space
    Transform healthBarChild; // to create a Transform Object
    healthBarChild = transform.Find("HealthBar"); // to find the transform component of parent object and put to child object
    healthBarChild.localPosition = new Vector3(-.3f, 0, 0);

    // for setting the parent manually
    GameObject childGameObj = new GameObject("ChildGameObject");
    childGameObj.transform.SetParent(healthBarChild); // to set the child object into their parent object
    childGameObj.transform.SetAsLastSibling(); // to arrange the child objects to last
    childGameObj.transform.SetAsFirstSibling(); // to arrange the child objects to firt

    // to get the list of the child object of parent object
    foreach(Transform childObj in transform) {
      Debug.Log(childObj);
    }

    for(int i = 0; i < healthBarChild.childCount; i++) {
      Debug.Log(healthBarChild.GetChild(i));
    }
  }

  // Update is called once per frame
  void Update() {
    // to move the object in the specified direction
    transform.position = transform.position + new Vector3(.01f, 0, 0);
    // transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, .1f);
    // transform.localScale = transform.localScale + new Vector3(.01f, .01f, 0);
  }
}
