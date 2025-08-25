using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadLevelScene()
    {
        SceneManager.LoadScene("Level 1");
    }
}