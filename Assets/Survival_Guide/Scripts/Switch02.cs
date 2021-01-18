using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch02 : MonoBehaviour
{
    [SerializeField]
    private Weapon _currentWeapon;
    public enum Weapon
    {
        Gun,
        Knife,
        Rifle
    } 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UserInput();
        
    }

    private void ChangeWeapon()
    {
        switch(_currentWeapon)
        {
            case Weapon.Gun:
                Debug.Log("Weapon: " + _currentWeapon);
                break;
            case Weapon.Knife:
                Debug.Log("Weapon: " + _currentWeapon);
                break;
            case Weapon.Rifle:
                Debug.Log("Weapon: " + _currentWeapon);
                break;
            default:
                Debug.Log("no Weapon");
                break;
        }
    }

    #region UserInput
    private void UserInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _currentWeapon = Weapon.Gun;
            ChangeWeapon();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _currentWeapon = Weapon.Knife;
            ChangeWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _currentWeapon = Weapon.Rifle;
            ChangeWeapon();
        }
        #endregion
    }
}
