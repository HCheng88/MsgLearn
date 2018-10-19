using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : PlayerBase {
    public float speed = 1;

    private void Awake()
    {
        Bind(AudioEventIndex.PLAY_AUDIO);       
    }
    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AudioEventIndex.PLAY_AUDIO:
                
                Vector2 vector2 = (Vector2)message;
                Debug.Log(vector2);
                transform.Translate(vector2.x * Time.deltaTime * speed, 0, vector2.y * Time.deltaTime * speed);

                break;
            default:
                break;
        }
    }
}
