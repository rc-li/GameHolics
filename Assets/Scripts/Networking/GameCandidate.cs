using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using Bolt.Matchmaking;
using UdpKit;
using UdpKit.Platform.Photon;
using UnityEngine;

public class GameCandidate : GlobalEventListener
{
    // Start is called before the first frame update
    public void StartClient()
    {
        BoltLauncher.StartClient();
    }

    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        //base.SessionListUpdated(sessionList);
        foreach(var session in sessionList)
        {
            UdpSession udpSession = session.Value as UdpSession;
            if (udpSession.Source == UdpSessionSource.Photon)
                BoltMatchmaking.JoinSession(udpSession);
        }
    }
}
