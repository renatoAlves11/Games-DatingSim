using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Button b1, b2, b3;
    public bool doma = false;

    public Buttons(bool doma)
    {
        this.doma = doma;
    }

    private void Awake()
    {
        b1.onClick.AddListener(OnClickDown);
        b2.onClick.AddListener(OnClickDown);
        b3.onClick.AddListener(OnClickDown);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClickDown()
    {
        doma = true;
    }
}