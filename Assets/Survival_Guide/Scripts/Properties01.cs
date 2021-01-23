using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties01 : MonoBehaviour
{
    private float _speed;
    public float Speed { get; private set; }
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
