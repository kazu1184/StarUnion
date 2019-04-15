using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarEffect : MonoBehaviour
{
    [SerializeField]
    GameObject[] on_star = new GameObject[3];
    [SerializeField]
    GameObject[] off_star = new GameObject[3];
    Score score = null;
    int s_num;

    // Start is called before the first frame update
    void Start()
    {
        //Scriptの取得
        GameObject temp = GameObject.Find("Score");
        score = temp.GetComponent<Score>();

        //スコアの取得
        s_num = score.GetComponent<Score>().GetScore();

        //描画OFF
        for(int i=0;i<3;i++)
        {
            on_star[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<3;i++)
        {
            //スコアに合わせて星を変える
            if (s_num >= 70)
            {
                on_star[i].SetActive(true);

                off_star[i].SetActive(false);
            }
            else if (s_num >= 30)
            {
                on_star[0].SetActive(true);
                on_star[1].SetActive(true);

                off_star[0].SetActive(true);
                off_star[1].SetActive(true);
            }            
            else
            {
                on_star[0].SetActive(true);

                off_star[0].SetActive(true);
            }
        }
    }
}
