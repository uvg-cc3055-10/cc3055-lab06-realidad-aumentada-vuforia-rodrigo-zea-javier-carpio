using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
/* UVG 
 * Javier Carpio - 17077
 * Rodrigo Zea - 17058
 * Plataformas Moviles y Juegos */
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {
    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Use this for initialization
    void Start () {
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
