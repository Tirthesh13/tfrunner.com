using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    [Header(" Elements ")]
    [SerializeField] private Transform runnersParent;
    [SerializeField] private RunnerSelector runnerSelectorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager.onSkinSelected += SelectSkin;
    }

    private void OnDestroy()
    {
        ShopManager.onSkinSelected -= SelectSkin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectSkin(int skinIndex)
    {
        for (int i = 0; i < runnersParent.childCount; i++)
            runnersParent.GetChild(i).GetComponent<RunnerSelector>().SelectRunner(skinIndex);

        runnerSelectorPrefab.SelectRunner(skinIndex);
    }
}
