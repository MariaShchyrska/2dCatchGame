using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private AudioClip _coinSound;
    
    public bool Enabled { get; private set; } = true;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Sound"))
            Enabled = PlayerPrefs.GetInt("Sound") == 1;
        else
            PlayerPrefs.SetInt("Sound", 1);
        
        if(!Enabled)
            _audioSource.Pause();
    }

    public void PlayCoinSound()
    {
        if(Enabled)
            _audioSource.PlayOneShot(_coinSound);
    }

    public void ToggleSound()
    {
        if(Enabled)
            StopSounds();
        else
            ResumeSounds();
    }
    
    public void StopSounds()
    {
        Enabled = false;
        PlayerPrefs.SetInt("Sound", 0);
        _audioSource.Pause();
    }
    
    public void ResumeSounds()
    {
        Enabled = true;
        PlayerPrefs.SetInt("Sound", 1);
        _audioSource.Play();
    }
}