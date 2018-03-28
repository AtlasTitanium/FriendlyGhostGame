using UnityEngine;
using System.Collections;

    public class SoundManager : MonoBehaviour 
    {
        [Header("Basics")]                
        public static SoundManager instance = null;//Allows other scripts to call functions from SoundManager.             
        public float Pitch = 1f;
        public bool playerisinside = false;
        
        [Space] 
        [Header("Sounds")]     
        public AudioSource musicSource; //Drag a reference to the audio source which will play the music.
        public AudioClip[] musicClips;
        public AudioSource[] soundeffectSources;//Drag a reference to the audio source which will play the sound effects. 
        public AudioClip[] Audioclips;  
        public Collider[] AudioTrigger; 

        void Awake ()
        {
            DontDestroyOnLoad (gameObject);
        }
        
        void Update()
        {
            if(playerisinside){
                if (!musicSource.isPlaying)
                {  
                int randomIndex = Random.Range(0, musicClips.Length);
                musicSource.clip = musicClips[randomIndex];
                musicSource.Play();
                }
            }
        }
    }