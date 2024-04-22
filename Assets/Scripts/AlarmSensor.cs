using UnityEngine;

public class AlarmSensor : MonoBehaviour
{
    [SerializeField] private bool _isActive = false;

    [SerializeField] private AudioSource _alarmSound;

    [SerializeField] private float _volume;
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _riseStep;

    private void Update()
    {
        if (_isActive)
            _volume = _maxVolume;
        else
            _volume = 0f;

        _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _volume, _riseStep * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Theif"))
            _isActive = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Theif"))
            _isActive = false;
    }
}