using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PathDrawer : MonoBehaviour
{

    public Path path;
    private LineRenderer lineRenderer;
    public int myCurrentNumber;
    
    public void CreatePath()
    {
        path = new Path(transform.position);
        lineRenderer = this.AddComponent<LineRenderer>();
        lineRenderer.widthMultiplier= 1f;
    }

    public void DrawPath(List<Vector2> points)
    {   
        if(this.GetComponent<EdgeCollider2D>() == null) 
        {
            this.gameObject.AddComponent<EdgeCollider2D>();
        }
        this.GetComponent<EdgeCollider2D>().offset = new Vector2(0f,0f);
        this.GetComponent<EdgeCollider2D>().points = points.ToArray();
        this.GetComponent<LineRenderer>().positionCount= points.Count;
        for(int i=0; i<points.Count; i++)
        {
            this.GetComponent<LineRenderer>().SetPosition(i, points[i]);
            this.GetComponent<EdgeCollider2D>().points[i] = new Vector2(points[i].x - 90f, points[i].y - 90f);
        }
    }
}
