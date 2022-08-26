using UnityEngine;

public class AudioManager : MonoBehaviour
{

    #region Game Specific
    [SerializeField] private AudioClip _laserSound;
    [SerializeField] private AudioClip _explosionSound;
    [SerializeField] private AudioClip _sonarSound;
    #endregion

    #region Template Fields
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _sfxSource;

    [SerializeField] private AudioClip _gameMusic;
    [SerializeField] private AudioClip _uiClick;
    [SerializeField] private AudioClip _winSound;
    [SerializeField] private AudioClip _loseSound;
    [SerializeField] private AudioClip _popUpOpen;
    [SerializeField] private AudioClip _popUpClose;
    #endregion

    #region Sound FX Methods
    public void PlayLaserSound()
    {
        if(this._laserSound == null) return;
        _sfxSource.clip = _laserSound;
        _sfxSource.Play();
    }

    public void PlayExplosionSound()
    {
        if(this._explosionSound == null) return;
        _sfxSource.clip = _explosionSound;
        _sfxSource.Play();
    }

    public void PlaySonarSound()
    {
        if(this._sonarSound == null) return;
        _sfxSource.clip = _sonarSound;
        _sfxSource.Play();
    }
    #endregion

    #region Music Methods
    public void PlayGameMusic()
    {
        if(this._gameMusic == null) return;
        _musicSource.clip = _gameMusic;
        _musicSource.Play();
    }

    public void StopGameMusic()
    {
        _musicSource.Stop();
    }

    public void SetSoundMusicVolume(float volume)
    {
        float temp = volume + this._musicSource.volume;
        this._musicSource.volume = temp;
    }
    #endregion

}