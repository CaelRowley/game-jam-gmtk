using UnityEngine;

public class BackgroundMusic : MonoBehaviour {
    public float audioLength;
    public AudioClip[] audioClips = new AudioClip[2];
    public float volume;

    private double nextLoopTime;
    private int currentIndex = 0;
    private AudioSource[] audioSources = new AudioSource[2];

    public string tag;

    // Creates audio sources as children to Player
    private void Start() {
        if(!GameObject.Find(tag)) {
            DontDestroyOnLoad(this.gameObject);
            for(int i = 0; i < 2; i++) {
                GameObject child = new GameObject(tag);
                child.transform.parent = gameObject.transform;
                audioSources[i] = child.AddComponent<AudioSource>();
                audioSources[i].volume = volume;
            }
            nextLoopTime = AudioSettings.dspTime;
        }
    }

    // Plays audio clip after the loop time and switches the index for the next audio clip
    private void Update() {
        if(audioSources[currentIndex] != null) {
            double currentTime = AudioSettings.dspTime;
            if(currentTime > nextLoopTime) {
                audioSources[currentIndex].clip = audioClips[currentIndex];
                audioSources[currentIndex].PlayScheduled(nextLoopTime);
                nextLoopTime += audioLength;
                currentIndex = 1 - currentIndex;
            }
        }
    }
}
