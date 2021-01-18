using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Coroutine : MonoBehaviour
{
    private GameObject _cube;
    private bool _isActive = true;
    private bool _coRoutineStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_coRoutineStarted)
        {
            Debug.Log("Space");
            _cube.SetActive(!_isActive);
            _isActive = !_isActive;
            _coRoutineStarted = true;
            StartCoroutine("Invisibility");
           
        }
    }

    IEnumerator Invisibility()
    {
        Debug.Log("Start Coroutine");
        yield return new WaitForSeconds(5.0f);
        _coRoutineStarted = false;
    }

}
