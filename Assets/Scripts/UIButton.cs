using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{
    public void ReplayLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
