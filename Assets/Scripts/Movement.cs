using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;

    private int _wayPointIndex;

    private void Start()
    {
        GetWayPoint();
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_wayPointIndex].transform.position)
            GetWayPoint();

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_wayPointIndex].transform.position, _speed * Time.deltaTime);
    }

    private void GetWayPoint()
    {
        _wayPointIndex = Random.Range(0, _wayPoints.Length);
    }
}