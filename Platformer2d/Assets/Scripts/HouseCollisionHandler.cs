using UnityEngine;

[RequireComponent(typeof(AlarmSystem))]
public class HouseCollisionHandler : MonoBehaviour
{
	[SerializeField] private AlarmSystem _alarmSystem;

	private float _maxVolume = 1f;
	private float _minVolume = 0f;
	private float _duration = 2f;

	private void Start()
	{
		_alarmSystem = GetComponent<AlarmSystem>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		_alarmSystem.ChangeVolume(_maxVolume, _duration);
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		_alarmSystem.ChangeVolume(_minVolume, _duration);
	}
}