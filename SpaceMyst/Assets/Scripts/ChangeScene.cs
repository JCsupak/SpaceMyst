using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void loadScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
