using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanle : UIBase {

    private void Awake()
    {
        Bind(UIEventIndex.Click_Button,1,2); //正确
        //Bind(1);    --------错误示范
        //Bind(2);    --------错误示范
    }
    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case UIEventIndex.Click_Button:
                Debug.Log("Panle面板：" + message.ToString());
                //GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);                
                break; 
            case 1:
                Debug.Log("Panle面板：111");
                break;
            case 2:
                Debug.Log("Panle面板：222");
                break;
            default:
                break;
        }
    }
}
