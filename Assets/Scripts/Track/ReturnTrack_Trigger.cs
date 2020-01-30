using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTrack_Trigger : MonoBehaviour
{
    public event Action<TrackModule> OnReturnModuleToPool = delegate {  };
    private void OnTriggerEnter(Collider other)
        {
            TrackModule lastModule = other.transform.parent.GetComponent<TrackModule>();
            if (lastModule != null)
            {
                Debug.Log("Hay que devolver el modulo al pool");
                OnReturnModuleToPool(lastModule);
            }
        }
    
}
