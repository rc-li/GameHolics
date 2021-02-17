using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Bolt.Matchmaking;
using UnityEngine;

public class GameHost : GlobalEventListener
{
    /// <summary>
    /// PhotonBolt的UDP sessionID
    /// </summary>
    string sessionId;

    /// <summary>
    /// 点击host按钮之后进入的scene
    /// </summary>
    string sceneToLoad;

    // Start is called before the first frame update
    public void StartServer()
    {
        sessionId = "test";
        sceneToLoad = "PhotonBoltTestGame";
        BoltLauncher.StartServer();
    }


    /// <summary>
    /// 这个函数在StartServer之后进行调用
    /// </summary>
    public override void BoltStartDone()
    {
        //base.BoltStartDone();
        BoltMatchmaking.CreateSession(sessionID:sessionId,sceneToLoad:sceneToLoad);
    }

}
