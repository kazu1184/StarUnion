using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeContollor : MonoBehaviour
{
    //public Text timer_text;

    public Text time;
    public float total_time;
    int seconds;
    GameObject re_start_button;

    // Use this for initialization
    void Start()
    {
        re_start_button = GameObject.Find("ReStart");
        re_start_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(total_time >= 0)
        {
            //時間を経過させる
            total_time -= Time.deltaTime;
            seconds = (int)total_time;
            time.text = "TIME  " + seconds.ToString();
        }
        else
        {
            //制限時間が０になった時ボタンを出す
            re_start_button.SetActive(true);
        }
    }

    public int GetTime()
    {
        return seconds;
    }
 }
