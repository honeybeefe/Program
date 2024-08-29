using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] Texture2D texture2D;
    [SerializeField] LayerMask layerMask;

    void Start()
    {
        Cursor.SetCursor(texture2D, new Vector2(0, 0), CursorMode.Auto);
    }
        
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                IInteractable interactable = raycastHit.collider.GetComponent<IInteractable>();

                if(interactable!=null)
                {
                    interactable.Interact();
                }                      
            }
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 0.5f);
    }

}