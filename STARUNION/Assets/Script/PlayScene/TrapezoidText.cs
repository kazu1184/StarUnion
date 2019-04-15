using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapezoidText : MonoBehaviour
{
    [SerializeField]
    Text num_clear;
    int add;
    // Start is called before the first frame update
    void Start()
    {
        Data temp = Data.instance;
        int judge = SharedData.instance.num_stage;

        switch(judge)
        {
            case 1: add = temp.GetNum(Data.STAGE_ID.STAGE_1); break;
            case 2: add = temp.GetNum(Data.STAGE_ID.STAGE_2); break;
            case 3: add = temp.GetNum(Data.STAGE_ID.STAGE_3); break;
            case 4: add = temp.GetNum(Data.STAGE_ID.STAGE_4); break;
            case 5: add = temp.GetNum(Data.STAGE_ID.STAGE_5); break;
            case 6: add = temp.GetNum(Data.STAGE_ID.STAGE_6); break;
            case 7: add = temp.GetNum(Data.STAGE_ID.STAGE_7); break;
            case 8: add = temp.GetNum(Data.STAGE_ID.STAGE_8); break;
            case 9: add = temp.GetNum(Data.STAGE_ID.STAGE_9); break;
        }

        //テキストに数値を入れる
        num_clear.text = add.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //三角形とテキストのポジションの同期
        num_clear.transform.position = gameObject.transform.position;
    }

    public int GetClear()
    {
        return add;
    }

    public void SetSubtraction(int subtraction)
    {
        add -= subtraction;
    }
}
