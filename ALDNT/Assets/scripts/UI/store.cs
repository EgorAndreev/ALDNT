using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public GameObject panel;
    public int Offset;
    private bool open = false;
    private float progress;
    private Vector2 newPos;
    private Vector2 oldPos;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = new Vector2(panel.transform.localPosition.x, panel.transform.localPosition.y);
        newPos = new Vector2(panel.transform.localPosition.x - Offset, panel.transform.localPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnStoreButtonClick()
    {
        open = !open;
        if (open) {
            panel.transform.localPosition = newPos;
        }
        else { panel.transform.localPosition = oldPos; }
    }
}
