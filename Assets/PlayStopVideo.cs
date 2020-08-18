using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

public class PlayStopVideo : MonoBehaviour
{
    //Raw Image to Show Video Images [Assign from the Editor]
   // public RawImage image;
    //Video To Play [Assign from the Editor]
   // public VideoClip videoToPlay;

    public VideoPlayer videoPlayer;
   

    //Audio
   // private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        //Application.runInBackground = true;
        // StartCoroutine(playVideo());
        videoPlayer.prepareCompleted += Prepared;
        videoPlayer.loopPointReached += EndReached;
    }
    public void StartPlayingVideo()
    {
        videoPlayer.Prepare();

    }
    /*
    public void StopVideo()
    {
        videoPlayer.Stop();

    }*/


     
    
    void Prepared(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("End reached!");
        vp.Play();
    }
    
            void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        videoPlayer.Stop();
    }

    void OnDestroy()
    {
       
        videoPlayer.prepareCompleted -= Prepared;
        videoPlayer.loopPointReached -= EndReached;
    }



    /*
    IEnumerator playVideo()
    {
        //Add VideoPlayer to the GameObject
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        //Add AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        //Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;

        //We want to play from video clip not from url
        videoPlayer.source = VideoSource.VideoClip;

        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        //Assign the Audio from Video to AudioSource to be played
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        //Wait until video is prepared
        WaitForSeconds waitTime = new WaitForSeconds(5);
        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");
            //Prepare/Wait for 5 sceonds only
            yield return waitTime;
            //Break out of the while loop after 5 seconds wait
            break;
        }

        Debug.Log("Done Preparing Video");

        //Assign the Texture from Video to RawImage to be displayed
        image.texture = videoPlayer.texture;

        //Play Video
        videoPlayer.Play();

        //Play Sound
        audioSource.Play();

        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        Debug.Log("Done Playing Video");
    }*/
}
