using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static event Action OnGetCoin = delegate {  };
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.GetComponent<EntityMovement>() != null)
        {
            OnGetCoin();
            Destroy(gameObject);
        }
    }
}
