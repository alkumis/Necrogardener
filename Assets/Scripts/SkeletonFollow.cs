using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonFollow : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _stoppingDistance;
    [SerializeField]
    private Transform _player;

    public Transform Player { set { _player = value; } }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector2.Distance(transform.position, _player.position) > _stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, _player.position, _speed * Time.fixedDeltaTime);
        }
    }
}
