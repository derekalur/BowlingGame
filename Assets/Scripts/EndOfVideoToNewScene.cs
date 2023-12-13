using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndOfVideoToNewScene : MonoBehaviour
{
    [SerializeField]
    VideoPlayer myVideo;

    // Subscribe to ChangeScenes method when the video is finished
    void Start()
    {
        myVideo.loopPointReached += ChangeScenesWhenVidEnds;
    }

    // Change scenes when video ends
    public void ChangeScenesWhenVidEnds(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
