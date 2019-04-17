using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriangleText : MonoBehaviour
{
    [SerializeField]
    Text num_tri;
    int num; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //テキストのセット
    public void SetText(string newText)
    {
        num_tri.text = newText;
    }
    //テキストの取得
    public string GetText()
    {
        return num_tri.text;
    }
    //数字のセット
    public void SetNum(int num)
    {
        this.num = num;
    }
    //数字の取得
    public int GetNum()
    {
        return this.num;
    }
}
