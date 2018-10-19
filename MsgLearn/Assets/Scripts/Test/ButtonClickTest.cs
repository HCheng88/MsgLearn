using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonClickTest : MonoBase {

    public Button btn;
    public float h;
    public float v;
    public Vector2 vec2;

    private void Start()
    {
        btn.onClick.AddListener(OnbtnClick);
    }
    public void OnbtnClick()
    {
        //Dispatch(AreaCode.AUDIO, AudioEventIndex.PLAY_AUDIO, "audioName1");
        //Dispatch(AreaCode.UI, UIEventIndex.Click_Button, "audioName1");
        //Dispatch(AreaCode.UI, 1, "audioName1");
        //Dispatch(AreaCode.UI, 2, "audioName1");
        Dispatch(AreaCode.CHARACTER, 0, "audioName1");
    }
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        vec2 = new Vector2(h, v);
        Debug.Log("h:" + Input.GetAxis("Horizontal") + "v:" + Input.GetAxis("Vertical"));
        Dispatch(AreaCode.CHARACTER, 0, vec2);
    }
}
