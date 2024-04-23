using Unity.VisualScripting;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    [SerializeField] private AlarmSensor _alarmSensor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Thief>(out Thief thief))
        {
            _alarmSensor.ActivateAlarm();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Thief>(out Thief thief))
        {
            _alarmSensor.DeactivateAlarm();
        }
    }
}