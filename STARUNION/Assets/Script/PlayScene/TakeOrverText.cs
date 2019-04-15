using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeOrverText : MonoBehaviour
{
    [SerializeField]
    Text num_text;

    GameObject original_obj;

    int num;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //テキストの位置の同期
        num_text.transform.position = gameObject.transform.position;
    }

    //テキストの設定
    public void SetText(string text)
    {
        num_text.text = text;
    }

    //数字を持たせる
    public void SetNum(int num)
    {
        this.num = num;
    }

    //数字の確認
    public int GetNum()
    {
        return this.num;
    }

    //足されたかどうか
    public bool GetFlag()
    {
        return flag;
    }

    //フラグを立てる
    public void SetFlag(bool flag)
    {
        this.flag = flag;
    }

    public void SetOriginalObject(GameObject original)
    {
        original_obj = original;
    }

    public GameObject GetOriginalObject()
    {
        return original_obj;
    }
}
