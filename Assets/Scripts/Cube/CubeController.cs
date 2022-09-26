public class CubeController
{
    private CubeView _cubeView;
    private CubeModel _cubeModel;

    public CubeController(CubeView cubeView, CubeModel cubeModel) {
        _cubeView = cubeView;
        _cubeModel = cubeModel;
    }

    public void Enable() {
        _cubeModel.CubeValueEvent += PrintValueCube;
        _cubeModel.ÑlickCubeEvent += ClickCube;
    }

    public void Disable() {
        _cubeModel.CubeValueEvent -= PrintValueCube;
        _cubeModel.ÑlickCubeEvent -= ClickCube;
    }

    private void PrintValueCube(int value) => _cubeView.PrintCubeValue(value);

    private void ClickCube(int value) => _cubeView.ClickCube(value);
}