using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    //星となる三角形
    [SerializeField]
    List<GameObject> triangle;
    //GameObject[] childe_triangle;
    //GetCompornent用
    TakeOrverText[] star;
    //五角形
    GameObject trapezoid;
    //GetCompornent用
    TrapezoidText set_text;
    //Time用
    GameObject time;
    [SerializeField]
    ClearStarManager csm;

    // Start is called before the first frame update
    void Start()
    {
        
        //スコアにタイムを渡す
        time = GameObject.Find("TimeContollor");
        //台形を探す
        trapezoid = GameObject.FindWithTag("Trapezoid");
        set_text = trapezoid.GetComponent<TrapezoidText>();

        //TakeOverTextのインスタンス化
        star = new TakeOrverText[5];

        for(int i = 0; i<5;i++)
        {
            //Listにアタッチされているものを入れる
            //childe_triangle[i] = triangle[i];
            star[i] = triangle[i].GetComponent<TakeOrverText>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0;i<5;i++)
        {
            //台形に三角形がくっついているかつ、まだ足されたことがないか
            if(star[i].gameObject.activeInHierarchy != false &&
               star[i].GetFlag() != true)
            {
                //計算
                set_text.SetSubtraction(star[i].GetNum());
                //足されたフラグを立たせる
                star[i].SetFlag(true);
            }

            //クリアの数字と合計値が等しくなったらクリアシーンに遷移するかつ星が完成している
            if (set_text.GetClear()== 0 && star[0].GetFlag() != false && 
                star[1].GetFlag() != false && star[2].GetFlag() != false && 
                star[3].GetFlag() != false && star[4].GetFlag() != false)
            {
                //データの保存
                SharedData.instance.clear_time = time.GetComponent<TimeContollor>().GetTime();
                //クリアアニメーション
                csm.OnActive();

                SceneManager.LoadScene("ResultScene");
            }
        }
    }
}
