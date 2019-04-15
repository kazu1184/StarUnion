using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleContollor : MonoBehaviour
{
    readonly Vector2[] position = { new Vector2(300,450), new Vector2(100,450),new Vector2(-100,450),new Vector2(-300,450),
                                    new Vector2(300,220),new Vector2(100,220),new Vector2(-100,220),new Vector2(-300,220)};

    [SerializeField]
    GameObject triangle_pre;
    [SerializeField]
    GameObject my_canvas;

    int num_triangle;

    GameObject[] tri;
// Start is called before the first frame update
    void Start()
    {
        //座標をランダムにする
        for (int i = 0; i < 10; i++)
        {
            int pX = Random.Range(0, 8);
            int pY = Random.Range(0, 8);

            Vector2 tmp = new Vector2(0, 0);
            tmp = position[pX];
            position[pX] = position[pY];
            position[pY] = tmp;
        }

        //インスタンスのゲット
        Data temp = Data.instance;
        int judge = SharedData.instance.num_stage;

        switch(judge)
        {
            case 1: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_1); break;
            case 2: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_2); break;
            case 3: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_3); break;
            case 4: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_4); break;
            case 5: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_5); break;
            case 6: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_6); break;
            case 7: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_7); break;
            case 8: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_8); break;
            case 9: num_triangle = temp.GetNumStar(Data.STAGE_ID.STAGE_9); break;
        }

        int[] data = new int[num_triangle];

        for (int i= 0;i<num_triangle;i++)
        {
            switch (judge)
            {
                case 1: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_1, i); break;
                case 2: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_2, i); break;
                case 3: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_3, i); break;
                case 4: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_4, i); break;
                case 5: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_5, i); break;
                case 6: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_6, i); break;
                case 7: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_7, i); break;
                case 8: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_8, i); break;
                case 9: data[i] = (int)temp.GetNum(Data.STAGE_ID.STAGE_9, i); break;
                default:break;
            }
        }

        //ゲームオブジェクトのインスタンス化
        tri = new GameObject[num_triangle];

        for (int i = 0; i < num_triangle; i++)
        {
            //三角形の複製
            tri[i] = Instantiate(triangle_pre) as GameObject;
            //数字の描画
            TriangleText tri_text = tri[i].GetComponent<TriangleText>();
            tri_text.SetText(data[i].ToString());
            //三角形に数字を持たせる
            tri_text.SetNum(data[i]);

            //キャンバスの子供に追加
            tri[i].transform.parent = my_canvas.transform;

            //位置を決める
            tri[i].transform.position = new Vector3(position[i].x, position[i].y, 0);

            //角度を変える
            int r = Random.Range(0, 360);
            tri[i].transform.rotation = Quaternion.Euler(0.0f, 0.0f, r);

            //描画ON
            tri[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
