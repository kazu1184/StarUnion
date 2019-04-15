using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score;
    int time;
    int initialize_time;
    TimeContollor current_time;

    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.Find("TimeContollor");
        //Debug.Log(temp);
        current_time = temp.GetComponent<TimeContollor>();
        Debug.Log(current_time);
        initialize_time = (int)current_time.total_time;
    }

    // Update is called once per frame
    void Update()
    {
        if(time != 0 && initialize_time != 0)
        {
            score = time / (int)initialize_time;
        }
    }

    public void SetTime(int time)
    {
        this.time = time;
    }

    public int GetScore()
    {
        return score;
    }
}
