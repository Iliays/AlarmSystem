using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class AlarmSystem : MonoBehaviour
{
	[SerializeField] private AudioSource _alarm;

	private float _maxVolume = 1f;
	private float _minVolume = 0f;
	private float _duration = 3f;

	private void Start()
	{
		_alarm = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		DOTweenModuleAudio.DOFade(_alarm, _maxVolume, _duration);
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		DOTweenModuleAudio.DOFade(_alarm, _minVolume, _duration);
	}
}