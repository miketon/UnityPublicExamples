using UnityEngine;
using System.Collections;

//Attach this script to the same object as your AnimatorController
[RequireComponent(typeof(AudioSource))]
public class zzzAnimEventTest : MonoBehaviour {

  public GameObject[] emitTransform ; //stores list of emitter points
  public GameObject fx_Emitter      ;
  public AudioClip  fx_Audio        ; //play when jumping
  public float audio_Volume = 1.0f  ;

  void PlayAtObjectTransform(int in_Int){ //in_Int points to index of emitTransform list
	Instantiate(fx_Emitter, emitTransform[in_Int].transform.position, emitTransform[in_Int].transform.rotation) ; 
    PlaySoundFx()                                                                                               ;
  }

	/*** --- UTILITIES --- ***/

  void PlaySoundFx(){
    audio.volume = audio_Volume ;
    audio.clip   = fx_Audio     ;
    audio.Play ()               ;
  }
}
