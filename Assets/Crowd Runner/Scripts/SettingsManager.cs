using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

    [Header(" Elements ")]
    [SerializeField] private Sprite optionOnSprite;
    [SerializeField] private Sprite optionOffSprite;
    [SerializeField] private Image soundsButtonImage;

    [Header(" Settings ")]
    private bool soundsState = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSoundsState()
    {
        if (soundsState)
            DisableSounds();
        else
            EnableSounds();

        soundsState = !soundsState;
       
    }

    private void DisableSounds()
    {

    }

    private void EnableSounds()
    {

    }
}
