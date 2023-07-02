using Cinemachine;
using FD.Dev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    public static CameraManager instance;

    private CinemachineVirtualCamera cvcam;
    private CinemachineBasicMultiChannelPerlin cbmcp;

    private void Awake()
    {
        
        instance = this;

        cvcam = FindObjectOfType<CinemachineVirtualCamera>();
        cbmcp = cvcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

    }

    public float GetFOV() { return cvcam.m_Lens.FieldOfView; }
    public void SetFOV(float value) { cvcam.m_Lens.FieldOfView = value; }
    public void CameraShake(float amplitudeGain, float frequencyGain, float duration)
    {

        cbmcp.m_AmplitudeGain += amplitudeGain;
        cbmcp.m_FrequencyGain += frequencyGain;

        FAED.DelayInvoke(() =>
        {

            cbmcp.m_AmplitudeGain -= amplitudeGain;
            cbmcp.m_FrequencyGain -= frequencyGain;

        }, duration);

    }

    public void SetShake(float amplitudeGain, float frequencyGain)
    {

        cbmcp.m_AmplitudeGain = amplitudeGain;
        cbmcp.m_FrequencyGain = frequencyGain;

    }

}
