using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    //クリア時に出す星の数
    readonly int NUM_STAR = 8;
    //どこの方向に飛ばすか
    readonly float[] x_way = { 0.0f,1.0f,1.0f,1.0f,0.0f,-1.0f,-1.0f,-1.0f};
    readonly float[] y_way = { 1.0f,1.0f,0.0f,-1.0f,-1.0f,-1.0f,0.0f,1.0f};
    //プレハブのスター
    [SerializeField]
    GameObject pr_star;
    //星の色を変える
    [SerializeField]
    ClearStarManager csm;
    //インスタンス用
    GameObject[] star;
    //速度
    Vector3[] vel;
    
    // Start is called before the first frame update
    void Start()
    {
        //インスタンス化
        star = new GameObject[NUM_STAR];
        vel = new Vector3[NUM_STAR];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<NUM_STAR;i++)
        {
            if(star[i] != null)
            {
                star[i].transform.position += vel[i];
            }
        }
    }

    public bool AnimationClear()
    {
        //アニメーションが終了したいかどうか
        bool flag = false;

        //星を光らせる
        csm.OnActive();

        for (int i=0;i<NUM_STAR;i++)
        {
            //プレハブのインスタンス化
            star[i] = Instantiate(pr_star) as GameObject;

            vel[i] = new Vector3(x_way[i], y_way[i], 0);

            Debug.Log(i+"番目" + star[i].transform.position);
        }

        if (star[NUM_STAR -1] != null)
        {
            flag = true;
        }

        return flag;
    }
}
