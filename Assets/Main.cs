using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Web;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public static Main Instance;
    public Web Web;
    void Start()
    {
        Instance = this;
        Web = GetComponent<Web>();

    }
}
