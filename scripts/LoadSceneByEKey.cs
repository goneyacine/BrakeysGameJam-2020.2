using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneByEKey : MonoBehaviour
{
    public string targetScene;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(targetScene);
        }
    }
}