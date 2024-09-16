using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  [SerializeField] AudioSource musicSource;
  [SerializeField] AudioSource SFXSource;

  public AudioClip background;
  public AudioClip electronic1;
  public AudioClip electronic2;
  public AudioClip heal;
  public AudioClip hit;
  public AudioClip over;

  void Start()
  {
    musicSource.clip = background;
    musicSource.Play();
  }

  public void PlaySFX(AudioClip clip)
  {
    SFXSource.PlayOneShot(clip);
  }
}
