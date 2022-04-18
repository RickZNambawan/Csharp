using UnityEngine;

public class Debugging {

  void Start() {
      Debug.Log("Normal Log");
      Debug.LogWarning("Warning Message");
      Debug.LogError("Error Message");

      Debug.LogFormat("Current Time: {0}", Time.time);
      Debug.LogWarningFormat("Time since last frame: {0}", Time.deltaTime);
      Debug.LogErrorFormat("Time scale: {0}", Time.timeScale);
  }

}
