using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public Text newGameText;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    private bool gameStarted = false;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ResetGame();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ResetGame();
    }

    public void ResetGame()
    {
        this.gameStarted = false;
        this.newGameText.enabled = true;
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            this.newGameText.enabled = false;
            this.gameStarted = true;
            this.ball.AddStartingForce();
        }
    }
}
