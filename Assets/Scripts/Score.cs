using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _textScore; 
    [SerializeField] private TMP_Text _textCounterScore;
    [SerializeField] private FinishGame _finishGame;
    [SerializeField] private int _finishScore = 60; 

    private int _currentScore = 0;
    private int _counterScore = 0;

    public void UpdateScore(int score)
    {
        _counterScore += score;

        if ( _counterScore == 21)
        {
            UpdateCurrentScore(_counterScore);
        }
        else if( _counterScore > 21)
        {
            UpdateCurrentScore( - _counterScore / 2); 
        }

        _textCounterScore.text = _counterScore.ToString("D2");
    }

    private void UpdateCurrentScore(int counterScore)
    {
        _currentScore += counterScore;
        _counterScore = 0; 

        _textScore.text = _currentScore.ToString("D2");
        
        if(_currentScore >= _finishScore)
        {
            _finishGame.Finish(); 
        }
    }
}
