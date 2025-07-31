using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    int money;
    int apples;
    

    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI applesText;

    public void MyFuntion()
    {
        Debug.Log("Stuff happens");
    }

    public void AddScore()
    {
        score++;
        //or score += 1;

        Debug.Log("Score: " + score);
        if (score >= 10)
        {
            Debug.Log("We won so much moolaa!!");
        }

    }

    public void AddMoney()
    {
        money += 1 ;
        moneyText.text = "Money: " + money.ToString();
    }

    public void BuyApple()
    {
        if (money >= 5)
        {
            Debug.Log("Bought Apple");
            apples++;
            money -= 5;

            applesText.text = "Apples: " + apples.ToString();
            moneyText.text = "Money: " + money.ToString();

        }

        else
        {
            Debug.Log("Sorry too poor LMAO");
        }

    }
}
