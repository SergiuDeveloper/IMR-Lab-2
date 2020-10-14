using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VRTK;

public class LineDrawScript : MonoBehaviour
{
    private TrailRenderer trailRenderer;

    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.emitting = false;

        VRTK_InteractableObject interactableObject = GetComponent<VRTK_InteractableObject>();
        interactableObject.InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsedCallback);
        interactableObject.InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnusedCallback);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ObjectUsedCallback(object sender, InteractableObjectEventArgs e)
    {
        trailRenderer.emitting = true;
    }

    private void ObjectUnusedCallback(object sender, InteractableObjectEventArgs e)
    {
        trailRenderer.emitting = false;
    }
}