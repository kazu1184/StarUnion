using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTriangle : MonoBehaviour
{
    GameObject data_tri;
    GameObject new_tri;
    GameObject click_obj;
    GameObject trapezoid;
    TrapezoidText subtraction;
    // Start is called before the first frame update
    void Start()
    {
        GameObject new_tri = new GameObject();
        trapezoid = GameObject.FindWithTag("Trapezoid");
        subtraction = trapezoid.GetComponent<TrapezoidText>();
    }

    // Update is called once per frame
    void Update()
    {
        click_obj = GetClickObject();
        if(click_obj != null && click_obj.tag == "StarTri")
        {
            /*
            //動かせる三角形の複製
            data_tri.transform.position = click_obj.transform.position;
            new_tri = Instantiate(data_tri) as GameObject;
            //テキスト・数字の格納
            new_tri.GetComponent<TriangleText>().SetNum(data_tri.GetComponent<TriangleText>().GetNum());
            new_tri.GetComponent<TriangleText>().SetText(data_tri.GetComponent<TriangleText>().GetText());
            click_obj.SetActive(false);
            */
            //オブジェクトの取得
            GameObject show_obj = click_obj.GetComponent<TakeOrverText>().GetOriginalObject();

            //つけている三角形の描画OFF・新しい三角形の描画ON
            show_obj.SetActive(true);

            click_obj.SetActive(false);

            //テキストの初期化
            click_obj.GetComponent<TakeOrverText>().SetText(null);

            //足してもいいようにする
            click_obj.GetComponent<TakeOrverText>().SetFlag(false);

            //引かれた三角形をもとに戻す
            subtraction.SetSubtraction(-click_obj.GetComponent<TakeOrverText>().GetNum());

            //  マウスにくっついて動くようにする
            show_obj.GetComponent<MoveTriangle>().SetState(false);
        }
    }

    //クリックしたゲームオブジェクトを取得する
    public GameObject GetClickObject()
    {
        GameObject result = null;
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit = new RaycastHit();

            Vector3 rayDirection = ray.direction;
            Vector2 newOrigin = new Vector2(ray.origin.x, ray.origin.y);
            Vector2 newDirection = new Vector2(rayDirection.x, rayDirection.y);
            RaycastHit2D hitObj = Physics2D.Raycast(newOrigin, newDirection);
            if (hitObj != false)
            {
                result = hitObj.collider.gameObject;
            }
        }
        return result;
    }
}
