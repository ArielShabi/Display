using UnityEngine;

public class Drag : MonoBehaviour
{
    public LayerMask DraggbleLayerMask;

    private Collider2D _draggedCollider;    

    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            var touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                _draggedCollider = Physics2D.OverlapPoint(touchPosition, DraggbleLayerMask);
            }
            else if (touch.phase == TouchPhase.Moved && _draggedCollider != null)
            {
                _draggedCollider.transform.position = new Vector2(touchPosition.x, touchPosition.y);
            }
            else if (touch.phase == TouchPhase.Ended && _draggedCollider != null)
            {
                _draggedCollider = null;
            }          
        }
    }
}
