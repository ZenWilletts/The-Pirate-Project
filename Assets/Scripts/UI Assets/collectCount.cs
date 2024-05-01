using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void OnEnable() => collectable.OnCollected += OnCollectableCollected;
    void OnDisable() => collectable.OnCollected -= OnCollectableCollected;



    // Update is called once per frame
    void OnCollectableCollected()
    {
        text.text = (++count).ToString();
    }
}
