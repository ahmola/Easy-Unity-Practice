using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
