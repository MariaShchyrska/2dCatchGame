using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Sprite _soundOnSprite;
    [SerializeField]
    private Sprite _soundOffSprite;
    [SerializeField]
    private Audio _audio;
    
    private void Update()
    {
        if(_audio.Enabled)
            _image.sprite = _soundOnSprite;
        else
            _image.sprite = _soundOffSprite;
    }
}