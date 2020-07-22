using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip1;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        FirstClass.instance.onCoinCollection += playthissound;
    }

    void playthissound()
    {
        Debug.Log("sfjkdhfjsdhjk");
        Debug.Log("sound playing");
        audio.PlayOneShot(clip1);
        // Debug.Log("thisplayer died" + playerinfo.name);
    }
}
