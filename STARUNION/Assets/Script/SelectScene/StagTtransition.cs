using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagTtransition : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        GameObject temp = GetClickObject();

        if (temp != null&&temp.tag == "StageStar")
        {
            int num = temp.GetComponent<OffStar>().num_stage;
            //データの保存
            SharedData.instance.num_stage = num;

            SceneManager.LoadScene("PlayScene");
        }
    }

    //クリックしたゲームオブジェクトを取得する
    public GameObject GetClickObject()
    {
        GameObject result = null;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 ray_direction = ray.direction;
            Vector2 new_origin = new Vector2(ray.origin.x, ray.origin.y);
            Vector2 new_direction = new Vector2(ray_direction.x, ray_direction.y);

            RaycastHit2D hitObj = Physics2D.Raycast(new_origin, new_direction);
            if (hitObj != false)
            {
                result = hitObj.collider.gameObject;
            }
        }
        return result;
    }
}
