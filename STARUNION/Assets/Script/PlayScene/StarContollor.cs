using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarContollor : MonoBehaviour
{
    //public MoveTriangle move; スクリプトの宣言
    [SerializeField]
    GameObject star_value;
    GameObject hit_obj;

    // Start is called before the first frame updat
    void Start()
    {
        //描画の停止
        star_value.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが離されたとき三角形を置く
        if(Input.GetMouseButtonUp(0) && hit_obj != null)
        {
            TakeOrverText values_text = star_value.GetComponent<TakeOrverText>();
            TriangleText hit_triangle_text = hit_obj.GetComponent<TriangleText>();

            //音を鳴らす
            hit_triangle_text.OnAudio();

            if (values_text != null && hit_triangle_text != null)
            {
                if (star_value.activeInHierarchy != true)
                {
                    //三角形の描画OFF
                    hit_obj.SetActive(false);

                    //数字を星に送る
                    values_text.SetText(hit_triangle_text.GetText());
                }
                //星の描画をON
                star_value.SetActive(true);
                values_text.SetNum(hit_triangle_text.GetNum());
                //当たっている三角形の格納
                values_text.SetOriginalObject(hit_obj);
            }
        }
    }
    
    //当たっているとき値を入れる
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Triangle" && col.gameObject.GetComponent<MoveTriangle>().GetState() != false)
        {
            hit_obj = col.gameObject;
        }
    }
    //外れたらnull
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Triangle")
        {
            //くっついてもよい状態にする
            col.gameObject.GetComponent<MoveTriangle>().SetState(true);
            hit_obj = null;
        }
    }
}
