using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class AlarmSystem : MonoBehaviour
{
	[SerializeField] private AudioSource _alarm;

	private Tweener _volumeTween;

	private void Start()
	{
		_alarm = GetComponent<AudioSource>();
	}

	public void ChangeVolume(float targetVolume, float duration)
	{
		if (_volumeTween.IsActive())
		{
			_volumeTween.Kill();
			_volumeTween = DOTweenModuleAudio.DOFade(_alarm, targetVolume, duration);
		}
		else
		{
			_volumeTween = DOTweenModuleAudio.DOFade(_alarm, targetVolume, duration);
		}
	}
}