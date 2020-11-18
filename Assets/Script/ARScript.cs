using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARScript : DefaultTrackableEventHandler
{
    private TrackableBehaviour trackableImage;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(TrackableBehaviour.Status);
    }

    public void onTrackableStateChanged(TrackableBehaviour.Status newStatus)
    {
        
    }
}
