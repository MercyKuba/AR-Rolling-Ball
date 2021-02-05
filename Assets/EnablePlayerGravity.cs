using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePlayerGravity : DefaultTrackableEventHandler
{
    public Rigidbody player;

    override protected void OnTrackingLost()
    {
        player.useGravity = false;
    }
    override protected void OnTrackingFound()
    {
        player.useGravity = true;
    }
}