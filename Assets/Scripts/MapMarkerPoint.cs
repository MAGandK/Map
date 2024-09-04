using UnityEngine;

public class MapMarkerPoint : MonoBehaviour
{
   private float _width = 3000f;
   private float _height = 3000f;

   private float _mapWidth = 500f; 
   private float _mapHeight = 500f; 

   public RectTransform MapMarker;
   public Transform PointPosition;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.A))
      {
         FindMarkerPosition();
      }
   }

   public void FindMarkerPosition()
   {
      Vector2 marketPos = new Vector2(PointPosition.position.x * 0.3f, -PointPosition.position.z * 0.3f);
      MapMarker.anchoredPosition = new Vector2(marketPos.x, marketPos.y);
   }
}
