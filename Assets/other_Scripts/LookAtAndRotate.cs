using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtAndRotate : MonoBehaviour
{
    [SerializeField]
    private Transform _lookAt;
    [SerializeField] [Range (0f, 10f)]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _speed, 0, Space.World);
        //transform.LookAt(_lookAt);
    }
}
