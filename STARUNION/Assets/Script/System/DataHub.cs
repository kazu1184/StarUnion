using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHub : MonoBehaviour
{
    //+++++++++[1ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE1 = 6;
    //三角形の数字
    readonly int[] data1 = { 2, 5, 1, 3, 2, 2 };

    readonly int num1 = 10;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[2ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE2 = 7;
    //三角形の数字
    readonly int[] data2 = { 10, 3, 4, 6, 6, 1, 8 };

    readonly int num2 = 20;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[3ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE3 = 7;
    //三角形の数字
    readonly int[] data3 = { 2, 5, -3, 10, 6, 20, -8 };

    readonly int num3 = 30;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[4ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE4 = 8;
    //三角形の数字
    readonly int[] data4 = { 5, 10, 15, -9, 0, 9, 8, 12 };

    readonly int num4 = 40;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[5ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE5 = 8;
    //三角形の数字
    readonly int[] data5 = { 20, 30, 9, -3, -6, 15, 8, 10 };

    readonly int num5 = 50;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[6ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE6 = 8;
    //三角形の数字
    readonly int[] data6 = { 13,7,5,15,18,-3,-5,20 };

    readonly int num6 = 60;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[7ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE7 = 8;
    //三角形の数字
    readonly int[] data7 = {  -25, 90, 15, -30, 20, 80, 70, 5 };

    readonly int num7 = 70;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[8ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE8 = 8;
    //三角形の数字
    readonly int[] data8 = { 10, -9, 29, 15, 35, -20, 8, 9 };

    readonly int num8 = 80;
    //+++++++++++++++++++++++++++++++++//

    //+++++++++[9ステージ目]+++++++++++//
    //三角形の数
    const int NUM_TRIANGLE9 = 8;
    //三角形の数字
    readonly int[] data9 = { 9, 17, 30, 14, 20, 8, 10, -20 };

    readonly int num9 = 90;

    // Start is called before the first frame update
    void Start()
    {
        Data temp = Data.instance;
        //データの保存
        temp.LoadStageData(Data.STAGE_ID.STAGE_1, NUM_TRIANGLE1, data1);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_1, num1);

        temp.LoadStageData(Data.STAGE_ID.STAGE_2, NUM_TRIANGLE2, data2);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_2, num2);

        temp.LoadStageData(Data.STAGE_ID.STAGE_3, NUM_TRIANGLE3, data3);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_3, num3);

        temp.LoadStageData(Data.STAGE_ID.STAGE_4, NUM_TRIANGLE4, data4);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_4, num4);

        temp.LoadStageData(Data.STAGE_ID.STAGE_5, NUM_TRIANGLE5, data5);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_5, num5);

        temp.LoadStageData(Data.STAGE_ID.STAGE_6, NUM_TRIANGLE7, data6);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_6, num6);

        temp.LoadStageData(Data.STAGE_ID.STAGE_7, NUM_TRIANGLE7, data7);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_7, num7);

        temp.LoadStageData(Data.STAGE_ID.STAGE_8, NUM_TRIANGLE8, data8);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_8, num8);

        temp.LoadStageData(Data.STAGE_ID.STAGE_9, NUM_TRIANGLE9, data9);
        temp.LoadTrapezoidData(Data.STAGE_ID.STAGE_9, num9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
