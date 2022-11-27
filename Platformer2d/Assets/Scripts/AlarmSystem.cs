using UnityEngine;
using DG.Tweening;
using System.Collections;

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
		_tween = DOTweenModuleAudio.DOFade(_alarm, volume, duration);
	}
}