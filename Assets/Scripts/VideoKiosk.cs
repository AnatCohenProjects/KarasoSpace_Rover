using UnityEngine;
using UnityEngine.Video;

public class VideoKiosk : MonoBehaviour
{
    [Header("UI")]
    public CanvasGroup menu;         // הקבוצה של מסך הבחירה
    public GameObject videoUI;       // ה-GameObject שמכיל את ה-RawImage

    [Header("Video")]
    public VideoPlayer player;
    public VideoClip curiosityClip;
    public VideoClip persistenceClip;

    void Start()
    {
        ShowMenu(true);
        player.loopPointReached += OnVideoFinished; // נקרא כשסרטון מסתיים
    }

    public void PlayCuriosity() => Play(curiosityClip);
    public void PlayPersistence() => Play(persistenceClip);

    void Play(VideoClip clip)
    {
        ShowMenu(false);
        player.clip = clip;
        player.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        player.Stop();
        ShowMenu(true);  // חזרה למסך הבחירה
    }

    void ShowMenu(bool show)
    {
        menu.alpha = show ? 1f : 0f;
        menu.blocksRaycasts = show;
        menu.interactable = show;

        videoUI.SetActive(!show);
    }

    void OnDestroy()
    {
        player.loopPointReached -= OnVideoFinished;
    }
}
