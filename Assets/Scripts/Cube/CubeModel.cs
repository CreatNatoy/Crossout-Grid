using System;

public class CubeModel : ICubeModel
{
    private int _value;

    public event Action<int> CubeValueEvent;
    public event Action<int> �lickCubeEvent;

    public CubeModel() => _value = UnityEngine.Random.Range(1, 12);


    public void SetValueCube() => CubeValueEvent?.Invoke(_value);

    public void ClickCube() => �lickCubeEvent?.Invoke(_value);
}