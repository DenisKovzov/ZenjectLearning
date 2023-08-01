using UnityEngine;
using UnityEngine.SceneManagement;

public class BootSceneEntryPoint : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene(1);
    }
}
