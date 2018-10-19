using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : ManagerBase {

    public static PlayerManager Instance = null;

    void Awake()
    {
        Instance = this;
    }
}
