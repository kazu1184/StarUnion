using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseTextContoller : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    GameObject pause_ui;
    //　ポーズUIのインスタンス
    GameObject pause_instance;
    [SerializeField]
    Text count;

    float last_real_time;
    float real_delta_time;

    float seconds;
    int time;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 3.0f;

        if (pause_instance == null)
        {
            pause_instance = GameObject.Instantiate(pause_ui) as GameObject;
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalcRealDeltaTime();
       if(seconds >= 0)
        {
            seconds -= real_delta_time;
            time = (int)seconds;
            count.text = time.ToString();
        }
        else
        {
            Destroy(pause_instance);
            count.text = null;
            Time.timeScale = 1f;
        }
    }

    //リアルタイム（タイムスケールに関与しない）
    void CalcRealDeltaTime()
    {
        if (last_real_time == 0)
        {
            last_real_time = Time.realtimeSinceStartup;
        }
        real_delta_time = Time.realtimeSinceStartup - last_real_time;
        last_real_time = Time.realtimeSinceStartup;
    }
}
