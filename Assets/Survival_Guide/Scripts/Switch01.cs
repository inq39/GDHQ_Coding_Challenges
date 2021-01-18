using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch01 : MonoBehaviour
{
    [SerializeField] private int _value;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _value = 50;
            PrintValue();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _value = 100;
            PrintValue();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _value = 0;
            PrintValue();
        }
    }

    void PrintValue()
    {
        switch (_value)
        {
            case 100:
                Debug.Log("Value = 100");
                break;
            case 50:
                Debug.Log("Value = 50");
                break;
            case 0:
                Debug.Log("Value = 0");
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
