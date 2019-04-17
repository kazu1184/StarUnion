using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Score : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    //STARTより早く処理する
    void Awake()
    {
        //データのロード
        int time = SharedData.instance.clear_time;
        score = time * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetScore()
    {
        return score;
    }
}
