# Unity Music Volume Settings

Este proyecto contiene un script de Unity que permite ajustar el volumen de la música en tiempo real utilizando un `Slider` y un `TextMeshProUGUI` para mostrar el porcentaje de volumen. Está diseñado para trabajar con un `Audio Mixer` en Unity.

## 📋 Características

- Ajusta el volumen de la música dinámicamente en tiempo real.
- Convierte valores de porcentaje del `Slider` a decibelios para integrarse con el `Audio Mixer`.
- Muestra el porcentaje actual de volumen mediante un texto de `TextMeshPro`.

## 🛠️ Requisitos

- **Unity** (versión recomendada: 2021.3 o superior).
- **TextMeshPro**: Asegúrate de que el paquete TextMeshPro esté instalado en tu proyecto de Unity.
- **Audio Mixer**: Configurado con un parámetro expuesto para el volumen de la música.

## 🚀 Cómo usar el script

1. **Agregar el script al proyecto:**
   - Copia el archivo `MusicVolumeSettings.cs` y colócalo en la carpeta `Scripts` de tu proyecto de Unity.

2. **Configurar el Audio Mixer:**
   - Crea o abre un `Audio Mixer` en Unity.
   - Añade un grupo para la música.
   - ![image](https://github.com/user-attachments/assets/8114a153-29d9-4a11-8f29-33c51ad317df)
   - Expón el parámetro de volumen del grupo de música:
     - Selecciona el grupo de música en el `Audio Mixer`.
     - Haz clic derecho sobre el control de "Volume" y selecciona **Expose 'Volume' to script**.
     - ![image](https://github.com/user-attachments/assets/8867253c-62cd-449d-995a-8d6aba648302)
     - Ve al panel **Exposed Parameters** y cambia el nombre del parámetro expuesto a **`MusicVolume`**, para que coincida con el valor definido en el script.
     - ![image](https://github.com/user-attachments/assets/df015134-69a9-4f48-8385-2da3a9e51af6)

3. **Configurar el Slider y el Texto TMP:**
   - Crea un `Slider` en tu interfaz gráfica y configúralo.
   - Crea un objeto de texto utilizando `TextMeshPro`.
   - Asigna el `Slider` al campo `musicSlider` y el texto TMP al campo `musicText` en el Inspector.
   - Asigna el `Audio Mixer` al campo correspondiente.

4. **Ejecutar el proyecto:**
   - Al iniciar el juego, el `Slider` reflejará el volumen actual de la música.
   - Ajusta el `Slider` para cambiar el volumen. El texto TMP se actualizará automáticamente con el porcentaje.

## 📂 Estructura del proyecto

```plaintext
UnityMusicVolumeSettings/
├── MusicVolumeSettings.cs   # Script principal para gestionar el volumen de música.
├── README.md                # Documentación del proyecto.
