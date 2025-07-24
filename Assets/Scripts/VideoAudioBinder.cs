using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
[RequireComponent(typeof(AudioSource))]
public class VideoAudioBinder : MonoBehaviour
{
    void Awake()
    {
        var vp = GetComponent<VideoPlayer>();
        var audio = GetComponent<AudioSource>();

        vp.audioOutputMode = VideoAudioOutputMode.AudioSource;
        vp.EnableAudioTrack(0, true);            // מפעיל את טראק האודיו הראשון
        vp.SetTargetAudioSource(0, audio);       // מחבר את הטראק ל-AudioSource
    }
}