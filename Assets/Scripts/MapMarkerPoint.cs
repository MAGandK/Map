using UnityEngine;

public class MapMarkerPoint : MonoBehaviour
{
   private float _width = 3000f;
   private float _height = 3000f;

   private float _mapWidth = 500f; 
   private float _mapHeight = 500f; 

   public RectTransform MapMain;
   public RectTransform MapMarker;
   public Transform PointPosition;

   
   private float _mapScale = 1f;
   private float _minScale = 1f; 
   private float _maxScale = 5f;
   private void Update()
   {
      float scroll = Input.GetAxis("Mouse ScrollWheel");
      if (scroll != 0)
      {
         _mapScale = Mathf.Clamp(_mapScale + scroll, _minScale, _maxScale);
         UpdateMapSize();
         FindMarkerPosition();
      }

      
      if (Input.GetKeyDown(KeyCode.A))
      {
         FindMarkerPosition();
      }
   }

   public void FindMarkerPosition()
   {
      Vector2 markerPos = new Vector2(PointPosition.position.x * 0.3f * _mapScale, -PointPosition.position.z * 0.3f * _mapScale);
      MapMarker.anchoredPosition = markerPos;

   }
   
   private void UpdateMapSize()
   { 
     MapMain.sizeDelta = new Vector2(_mapWidth * _mapScale, _mapHeight * _mapScale); 
   }
}
