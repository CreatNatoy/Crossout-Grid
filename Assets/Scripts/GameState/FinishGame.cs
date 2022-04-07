using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject _textFinish;
    [SerializeField] private GameObject _cubesRoot;

    public void Finish()
    {
        _textFinish.SetActive(true);
        _cubesRoot.SetActive(false);
    }
}
