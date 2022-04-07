using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private StateCube _cube;
    [SerializeField] private int _size = 4;
    [SerializeField] private float _spacing = 2f;
    [SerializeField] private Score _score; 

    private List<StateCube> _cubes = new List<StateCube>();

    private void Start()
    {
        SpawnCube();
    }


    private void SpawnCube()
    {
        float center = GetCenter(_spacing, _size);

        for (int i = 0; i < _size; i++)
        {
            float positionY = center + (i * _spacing);

            for (int j = 0; j < _size; j++)
            {
                StateCube cube = Instantiate(_cube, transform);
                cube.SetScore(_score); 
                _cubes.Add(cube);

                float positionX = center + (j * _spacing);
                Vector3 spawnPosition = new Vector3(positionX, positionY, transform.position.z);
                cube.transform.localPosition = spawnPosition;
            }
        }
    }

    private float GetCenter(float spacing, int size)
    {
        float result = spacing * (size - 1);
        result = -result / 2;
        return result; 
    }
}
