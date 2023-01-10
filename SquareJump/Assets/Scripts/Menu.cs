using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI title, score, highscore;
    public Button play, music, sound;
    public MusicManager mm;
    public bool Music, Sound;

    public void ChangeMenu(bool x)
    {
        title.gameObject.SetActive(x);
        score.gameObject.SetActive(!x);
        highscore.gameObject.SetActive(!x);
        play.gameObject.SetActive(x);
        sound.gameObject.SetActive(x);
        music.gameObject.SetActive(x);
    }
    public void ChangeMusic()
    {
        Music = !Music;
        mm.AsMusic.mute = Music; 
    }
    public void ChangeSound()
    {
        Sound = !Sound;
        mm.AsDie.mute = Sound;
        mm.AsJump.mute = Sound;
    }
}
