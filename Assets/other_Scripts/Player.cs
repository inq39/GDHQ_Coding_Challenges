using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _gravity;
    [SerializeField]
    private float _playerSpeed;
    [SerializeField]
    private float _jumpHeight;
    private CharacterController _cc;
    private float _yVelocity;
    private int _pressedR;

    // Start is called before the first frame update
    void Start()
    {
        _cc = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();

        if (_cc == null)
        {
            Debug.Log("CC is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.R))
        {
            _pressedR++;
            UIManager.Instance.UpdateText(_pressedR);
        }
    }

    private void CalculateMovement()
    {
        float hInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(hInput, 0, 0);
        Vector3 velocity = direction * _playerSpeed;

        if (_cc.isGrounded)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _yVelocity = _jumpHeight;
            }
        }
        else
        {
            _yVelocity -= _gravity * Time.deltaTime;
        }

        velocity.y = _yVelocity;
        _cc.Move(velocity * Time.deltaTime);
    }
}
