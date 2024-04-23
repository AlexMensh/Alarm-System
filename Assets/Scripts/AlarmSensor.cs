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
        _volume = _isActive ? _maxVolume : 0f;
        _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _volume, _riseStep * Time.deltaTime);
    }

    public void ActivateAlarm()
    {
        _isActive = true;
        _alarmSound.Play();
    }

    public void DeactivateAlarm()
    {
        _isActive = false;
        _alarmSound.Stop();
    }
}