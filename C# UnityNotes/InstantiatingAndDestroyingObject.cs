using UnityEngine;

public class InstiatiatingAndDestroyingObject : MonoBehaviour
{

  [SerializeField] private GameObject Enemy; // to create reference property to the prefab you drag in.
  [SerializeField] private KeyCode keyToDestroy; // to create keys to destroy an object.

  void Update() {
    Transform enemyTransform = Enemy.transform; // every object has transform component
    Vector3 enemyPosition = enemyTransform.position; // store the position of an object to a variable

    if(Input.GetKeyDown(KeyCode.Space)) {
      Instantiate(Enemy); // function to Instantiate an object.
      enemyPosition = new Vector3(0.1f, 0, 0);
    }

    if(Input.GetKeyDown(keyToDestroy)) {
      Destroy(gameObject);
    }
  }
}
