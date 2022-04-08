using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private CubeView _cube;
    [SerializeField] private int _size = 4;
    [SerializeField] private float _spacing = 2f;
    [SerializeField] private Score _score;

    private List<CubeController> _cubeControllers = new List<CubeController>();
    private List<CubeView> _cubes = new List<CubeView>();

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
                CubeView cube = CreateCube();

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

    private CubeView CreateCube()
    {
        CubeModel model = new CubeModel();

        CubeView cube = Instantiate(_cube, transform);

        var controller = new CubeController(cube, model);

        controller.Enable();
        model.SetValueCube();
        _cubeControllers.Add(controller);
        cube.SetScore(_score);
        cube.ButtonClick.onClick.AddListener(model.ClickCube);

        _cubes.Add(cube);

        return cube;
    }

    private void OnDisable()
    {
        for (int i = 0; i < _cubeControllers.Count; i++)
        {
            _cubeControllers[i].Disable();
        }
    }
}
