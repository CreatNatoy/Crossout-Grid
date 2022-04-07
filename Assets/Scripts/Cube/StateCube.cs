using UnityEngine;

public class StateCube : MonoBehaviour
{
    [SerializeField] private Material _green;
    [SerializeField] private Material _red;
    [SerializeField] private MeshRenderer _render;
    [SerializeField] private RandomValue _valueCube;

    private Score _score; 
    private bool _stateCube = true; 

    public void SetScore(Score score)
    {
        _score = score;
    }

    public void ClickCube()
    {
        _stateCube = !_stateCube;
        
        if( _stateCube )
        {
            _render.material = _green;
            _score.UpdateScore(-_valueCube.Value);
        }
        else
        {
            _render.material = _red;
            _score.UpdateScore(_valueCube.Value);
        }
    }
}
