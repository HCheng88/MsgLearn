using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObj : AudioBase {

    private void Awake()
    {
        Bind(AudioEventIndex.PLAY_AUDIO);
    }
    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AudioEventIndex.PLAY_AUDIO:
                Debug.Log("正在播放：" + message.ToString());
                break;
            default:
                break;
        }
    }
}
