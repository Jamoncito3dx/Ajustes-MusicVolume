using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class MusicVolumeSettings : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider musicSlider; // Slider para el volumen de la música
    public TextMeshProUGUI musicText; // Texto TMP para mostrar el porcentaje

    [Header("Audio Mixer")]
    public AudioMixer audioMixer; // Referencia al Audio Mixer

    private const string musicVolumeParam = "MusicVolume";

    private void Start()
    {
        // Obtener el volumen actual del Audio Mixer y configurarlo en el slider
        float currentVolume;
        audioMixer.GetFloat(musicVolumeParam, out currentVolume);
        musicSlider.value = Mathf.Clamp(Mathf.Pow(10, currentVolume / 20) * 100, 0, 100);

        // Agregar listener al slider
        musicSlider.onValueChanged.AddListener(delegate { OnMusicSliderChanged(); });

        UpdateMusicText(musicSlider.value);
    }

    private void OnMusicSliderChanged()
    {
        // Convertir el porcentaje del slider a decibelios
        float porcentaje = Mathf.Max(musicSlider.value, 0.01f);
        float decibelios = Mathf.Log10(porcentaje / 100) * 20;

        // Aplicar el volumen al Audio Mixer
        audioMixer.SetFloat(musicVolumeParam, decibelios);

        // Actualizar el texto TMP
        UpdateMusicText(porcentaje);
    }

    private void UpdateMusicText(float porcentaje)
    {
        musicText.text = Mathf.RoundToInt(porcentaje) + "%";
    }
}
