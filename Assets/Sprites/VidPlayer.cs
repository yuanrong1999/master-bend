using UnityEngine.Video;
using UnityEngine;

public class VidPlayer : MonoBehaviour
{
    VideoPlayer a = new VideoPlayer();

    private void Start()
    {
       a = GetComponent<VideoPlayer>();
        a.playOnAwake = false;
        
    }

}
