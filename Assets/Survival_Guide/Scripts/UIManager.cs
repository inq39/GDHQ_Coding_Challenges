using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    private static UIManager _instance;
    public static UIManager Instance
   
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("UIManager is NULL.");
            }

            return _instance;
        }
    }
    [SerializeField]
    private TextMeshProUGUI _rText;
    private void Awake()
    {
        _instance = this;
    }
    
    public void UpdateText(int value)
    {
        _rText.SetText("Pressed 'R' : " + value);
    }
 
}
