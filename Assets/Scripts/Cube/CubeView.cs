using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeView : MonoBehaviour, ICubeView
{
    [SerializeField] private TMP_Text _textValue;
    [SerializeField] private Material _green;
    [SerializeField] private Material _red;
    [SerializeField] private MeshRenderer _render;
    [SerializeField] private Button _buttonClick; 

    private Score _score;
    private bool _stateCube = true;

    public Button ButtonClick => _buttonClick; 

    public void SetScore(Score score)
    {
        _score = score;
    }

    public void PrintCubeValue(int value)
    {
        _textValue.text = value.ToString();
    }   

    public void ClickCube(int value)
    {
        _stateCube = !_stateCube;

        if (_stateCube)
        {
            _render.material = _green;
            _score.UpdateScore( - value);
        }
        else
        {
            _render.material = _red;
            _score.UpdateScore(value);
        }
    }
}
