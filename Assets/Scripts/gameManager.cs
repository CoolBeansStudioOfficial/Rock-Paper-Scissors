using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject crown;

    public Animator player;
    public Animator enemy;

    public GameObject playerRock;
    public GameObject playerPaper;
    public GameObject playerScissors;

    public GameObject enemyRock;
    public GameObject enemyPaper;
    public GameObject enemyScissors;

    int playerChoice;
    int enemyChoice;

    public void StartGame(int pc)
    {
        playerChoice = pc;
        enemyChoice = Random.Range(0, 3);

        Animate(playerChoice, enemyChoice);

        
    }

    void Animate(int pc, int ec)
    {
        canvas.SetActive(false);

        player.enabled = true;
        enemy.enabled = true;

        if (pc == 0)
        {
            playerRock.SetActive(true);
        }
        else if (pc == 1)
        { 
            playerPaper.SetActive(true);
        }
        else
        {
            playerScissors.SetActive(true);
        }

        if (ec == 0)
        {
            enemyRock.SetActive(true);
        }
        else if (ec == 1)
        {
            enemyPaper.SetActive(true);
        }
        else
        {
            enemyScissors.SetActive(true);
        }

        Invoke("ShowWinner", 1f);
        Invoke("HideWinner", 3f);
        Invoke("FinishAnimation", 4f);

        
    }

    void FinishAnimation()
    {
        player.enabled = false;
        enemy.enabled = false;

        playerRock.SetActive(false);
        playerPaper.SetActive(false);
        playerScissors.SetActive(false);

        enemyRock.SetActive(false);
        enemyPaper.SetActive(false);
        enemyScissors.SetActive(false);

        canvas.SetActive(true);
    }

    void ShowWinner()
    {
        string winState;

        if (playerChoice == 0)
        {
            if (enemyChoice == 0)
            {
                winState = "tie";
            }
            else if (enemyChoice == 1)
            {
                winState = "lose";
            }
            else
            {
                winState = "win";
            }
        }

        else if (playerChoice == 1)
        {
            if (enemyChoice == 0)
            {
                winState = "win";
            }
            else if (enemyChoice == 1)
            {
                winState = "tie";
            }
            else
            {
                winState = "lose";
            }
        }

        else
        {
            if (enemyChoice == 0)
            {
                winState = "lose";
            }
            else if (enemyChoice == 1)
            {
                winState = "win";
            }
            else
            {
                winState = "tie";
            }
        }

        if (winState == "win")
        {
            crown.transform.position = new Vector2(-4.25f, 1f);
            crown.SetActive(true);
        }
        else if (winState == "lose")
        {
            crown.transform.position = new Vector2(4.25f, 1f);
            crown.SetActive(true);
        }
        else
        {
            crown.SetActive(false);
        }
    }

    void HideWinner()
    { 
        crown.SetActive(false); 
    }
}
