using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPosition : MonoBehaviour
{
    //スターの初期位置
    Vector2 offset_pos;
    //縦・横のプラス値
    int height, weight;
    //ステージの数
    const int NUM_STAR = 9;
    [SerializeField]
    List<GameObject> star;

    GameObject[] stage_star = new GameObject[NUM_STAR];

    // Start is called before the first frame update
    void Start()
    {
        //初期値の設定
        offset_pos = new Vector2(-330, 560);
        weight = 330;
        height = 300;

        //スターの複製
        GameObject[] clear_star = new GameObject[NUM_STAR];

        for (int i = 0; i < NUM_STAR; i++)
        {
            stage_star[i] = Instantiate(star[0]) as GameObject;
            clear_star[i] = Instantiate(star[1]) as GameObject;

            stage_star[i].GetComponent<OffStar>().num_stage = i + 1;

            //縦の数値・横の数値の計算
            int x = i % 3 * weight + (int)offset_pos.x;
            int y = (int)offset_pos.y - (i / 3 * height);

            //位置の代入
            stage_star[i].transform.position = new Vector3(x, y, 0);
            clear_star[i].transform.position = new Vector3(x, y, 0);

            //描画処理
            stage_star[i].SetActive(true);
            //clear_star[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject GetOffStar(int i)
    {
        return stage_star[i];
    }
}
