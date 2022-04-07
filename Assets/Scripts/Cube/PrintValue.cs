using TMPro;
using UnityEngine;

public class PrintValue : MonoBehaviour
{
    [SerializeField] private TMP_Text _textValue;
    [SerializeField] private RandomValue _valueCube;

    private void OnEnable()
    {
        _valueCube.ValueCube += OnValueCube;
    }

    private void OnDisable()
    {
        _valueCube.ValueCube -= OnValueCube;
    }

    private void OnValueCube(int value)
    {
        _textValue.text = value.ToString();
    }
}
