using UnityEngine;

public class gameManager : MonoBehaviour
{
    public Animator player;
    public Animator enemy;

    public Animator playerRock;
    public Animator playerPaper;
    public Animator playerScissors;

    public Animator enemyRock;
    public Animator enemyPaper;
    public Animator enemyScissors;

    public void StartGame(int playerChoice)
    {
        int enemyChoice = Random.Range(0, 3);

        if (playerChoice == 0)
        {
            if (enemyChoice == 0)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else if (enemyChoice == 1)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else
            {
                player.enabled = true;
                enemy.enabled = true;
            }
        }

        else if (playerChoice == 1)
        {
            if (enemyChoice == 0)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else if (enemyChoice == 1)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else
            {
                player.enabled = true;
                enemy.enabled = true;
            }
        }

        else
        {
            if (enemyChoice == 0)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else if (enemyChoice == 1)
            {
                player.enabled = true;
                enemy.enabled = true;
            }
            else
            {
                player.enabled = true;
                enemy.enabled = true;
            }
        }
    }
}
