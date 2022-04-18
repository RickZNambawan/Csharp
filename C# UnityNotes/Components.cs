using UnityEngine;

public class Components : MonoBehaviour {

  public static int _staticField; // static fields doesn't show in the script component

  // SerializeField private variable can only access inside script but show in the script component
  [Range(1, 100)] [SerializeField] private int _int; // number enabled label
  [Range(0, 50)] [SerializeField] private bool _boolean; // checkbox button true/false
  [SerializeField] private string _string; // type words
  [SerializeField] private MyEnum _enum; // drop box menu

  public enum MyEnum {
    OptionA, OptionB
  }

  private void Awake() {
    // this runs as soon as the component initialized whether or not the script is enabled
  }

  private void Start() {
    // this only runs if the script is enabled
    // initialization
  }

  private void Update() {
    // this called once every frame
    // movements must inside this method
  }

  private void LateUpdate() {
    // also called once every frame but after all of the update method
  }

  private void FixedUpdate() {
    // called at a fixed rate
    // physics must inside this method
  }

  private void OnEnable() {
    // called when the script/object is enabled
  }

  private void OnDisable() {
    // called when the script/object is disabled
  }

  // if you want your program to run the scripts in order
  // go to Project Settings > Script Execution Order > Drag the scripts in order as you like
}
