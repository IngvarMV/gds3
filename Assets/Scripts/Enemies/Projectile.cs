﻿using System.Runtime.CompilerServices;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private ProjectileSettings _settings = null;
    [SerializeField]
    private Collider _collider = null;

    public bool IsReflected { get; set; } = false;

    private float _elapsedTime = 0.0f;
    private Vector3 _startingPosition = Vector3.zero;

    public Vector3 Dir { get; set; } = Vector3.zero;

    private void Reflect()
    {
        Debug.Log("Reflect");
        Dir = -Dir;
        IsReflected = true;
    }

    private void Destroy()
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Weapon"))
        {
            if (other.gameObject.GetComponent<Weapon>().IsInSweetSpot(transform.position))
            {
                Reflect();
                return;
            }
        }
    }

    private void Start()
    {
        _collider.enabled = false;
        _startingPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var deltaTime = Time.deltaTime;

        var moveVec = Dir * _settings.projectileSpeed;
        transform.Translate(moveVec * deltaTime);

        if (_settings.frequency != 0)
        {
            var sin = transform.up * (_startingPosition.y + Mathf.Sin(_elapsedTime * _settings.frequency) * _settings.magnitude);
            transform.position = new Vector3(transform.position.x, sin.y, transform.position.z);
        }

        if(_elapsedTime >= 0.1f)
        {
            _collider.enabled = true;
        }

        _elapsedTime += deltaTime;
    }
}
