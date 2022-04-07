using UnityEngine;
using UnityEngine.Events;

public class RandomValue : MonoBehaviour
{
    [SerializeField] private int _minValue = 1;
    [SerializeField] private int _maxValue = 11;

    private int _value;

    public int Value => _value; 

    public event UnityAction<int> ValueCube;

    private void Start()
    {
        _value = Random.Range(_minValue, _maxValue + 1);

        ValueCube?.Invoke(_value);
    }
}
