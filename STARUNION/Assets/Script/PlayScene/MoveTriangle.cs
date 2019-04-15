using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveTriangle : MonoBehaviour,IDragHandler
{
    bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //オブジェクトをドラッグで移動
    public void OnDrag(PointerEventData data)
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 target_pos = Camera.main.ScreenToWorldPoint(data.position);
            target_pos.z = 0;
            transform.position = target_pos;
        }
    }

    public void SetState(bool state)
    {
        this.state = state;
    }

    public bool GetState()
    {
        return state;
    }
}
