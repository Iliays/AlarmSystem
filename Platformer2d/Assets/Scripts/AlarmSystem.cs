using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class AlarmSystem : MonoBehaviour
{
	[SerializeField] private AudioSource _alarm;

	private Tweener _tween;

	private void Start()
	{
		_alarm = GetComponent<AudioSource>();
	}

	public void ChangeVolume(float volume, float duration)
	{
		if (_tween.IsActive())
		{
			_tween.Kill();
			_tween = DOTweenModuleAudio.DOFade(_alarm, volume, duration);
		}
		else
		{
			_tween = DOTweenModuleAudio.DOFade(_alarm, volume, duration);
		}
	}
}