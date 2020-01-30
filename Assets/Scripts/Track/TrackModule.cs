using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TrackModule : MonoBehaviour, ITrackModuleQueuePool
{
    private int _queueIndex;

    [SerializeField] private TrackModule_config _trackModuleConfig;

    private Rigidbody _rb;

    public int QueueIndex
    {
        get { return _queueIndex; }
        set
        {
            if (_queueIndex == default)
                _queueIndex = value;
            else
            {
                throw new System.Exception("Bad pool use, this should only set once!");
            }
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveTowardsCamera();
    }

    /// <summary>
    /// Movimiento de los modulos
    /// </summary>
    private void MoveTowardsCamera()
    {
        _rb.MovePosition(_rb.position + (Vector3.back * _trackModuleConfig.speed * Time.fixedDeltaTime));
    }
}
