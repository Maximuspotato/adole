using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadMainScene(){
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
