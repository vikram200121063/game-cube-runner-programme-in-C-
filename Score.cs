using UnityEngine.UI;
using UnityEngine;
public class Score : MonoBehaviour
{
    public Text ScoreText;
    int myScore = 0;
    public Text finalscore;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = myScore.ToString();
        finalscore.text = "Score: "+myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
