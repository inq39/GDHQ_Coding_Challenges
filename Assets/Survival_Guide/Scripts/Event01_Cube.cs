using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event01_Cube : MonoBehaviour
{
    private MeshRenderer _mr;

    private void Start()
    {
        _mr = GetComponent<MeshRenderer>();

        if (_mr == null)
        {
            Debug.Log("MR is null.");
        }

        Event01.onSpace += ChangePosition;
    }

    void ChangeColor()
    {
        _mr.material.color = new Color(Random.value, Random.value, Random.value);
    }

    void ChangePosition(Vector3 pos)
    {
        transform.Translate(pos);
    }

    private void OnDisable()
    {
        Event01.onSpace -= ChangePosition;
    }
}
