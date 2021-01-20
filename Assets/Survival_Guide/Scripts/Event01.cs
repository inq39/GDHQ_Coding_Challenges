using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event01 : MonoBehaviour
{
    public delegate void ChangeCubePosition(Vector3 pos);
    public static event ChangeCubePosition onSpace;
    

    public void Update()
    {
        if (onSpace != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 newPosition = new Vector3(5, 2, 0);
                onSpace(newPosition);
            }
        }
    }
}
