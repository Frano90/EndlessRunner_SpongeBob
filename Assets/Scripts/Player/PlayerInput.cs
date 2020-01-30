using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Esta por verse si uso esto. 
    //Creo que si uso los booleans, voy a tener varios frames con las cosas prendidas,
    //lo que puede llegar a un mal funcionamiento
    public event Action OnRightCommand = delegate {  };
    public event Action OnLeftCommand = delegate {  };
    public event Action OnUpCommand = delegate {  };
    public event Action OnDownCommand = delegate {  };
    public event Action OnCheerCommand = delegate {  };

    
    private void Update()
    {
        ReadInputs();
    }

    private void ReadInputs()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnLeftCommand();
            Debug.Log("LeftInput");
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnRightCommand();
            Debug.Log("RightInput");
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnUpCommand();
            Debug.Log("UpInput");
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            OnDownCommand();
            Debug.Log("DownInput");
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnCheerCommand();
            Debug.Log("CheerInput");
        }
    }
}
