using UnityEngine;
using System.Collections;

public class MeshBuid : MonoBehaviour
{
    public Collider2D col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16,
        col17, col18, col19, col20, col21, col22, col23, col24;

    public Vector3[] vertices = new Vector3[25];
    public Vector3[] vertices1 = new Vector3[25];

    // Use this for initialization
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;

        //Collider Assigment
        col0 = transform.GetChild(0).GetComponentInChildren<Collider2D>();
        col1 = transform.GetChild(1).GetComponentInChildren<Collider2D>();
        col2 = transform.GetChild(2).GetComponentInChildren<Collider2D>();
        col3 = transform.GetChild(3).GetComponentInChildren<Collider2D>();
        col4 = transform.GetChild(4).GetComponentInChildren<Collider2D>();
        col5 = transform.GetChild(5).GetComponentInChildren<Collider2D>();
        col6 = transform.GetChild(6).GetComponentInChildren<Collider2D>();
        col7 = transform.GetChild(7).GetComponentInChildren<Collider2D>();
        col8 = transform.GetChild(8).GetComponentInChildren<Collider2D>();
        col9 = transform.GetChild(9).GetComponentInChildren<Collider2D>();
        col10 = transform.GetChild(10).GetComponentInChildren<Collider2D>();
        col11 = transform.GetChild(11).GetComponentInChildren<Collider2D>();
        col12 = transform.GetChild(12).GetComponentInChildren<Collider2D>();
        col13 = transform.GetChild(13).GetComponentInChildren<Collider2D>();
        col14 = transform.GetChild(14).GetComponentInChildren<Collider2D>();
        col15 = transform.GetChild(15).GetComponentInChildren<Collider2D>();
        col16 = transform.GetChild(16).GetComponentInChildren<Collider2D>();
        col17 = transform.GetChild(17).GetComponentInChildren<Collider2D>();
        col18 = transform.GetChild(18).GetComponentInChildren<Collider2D>();
        col19 = transform.GetChild(19).GetComponentInChildren<Collider2D>();
        col20 = transform.GetChild(20).GetComponentInChildren<Collider2D>();
        col21 = transform.GetChild(21).GetComponentInChildren<Collider2D>();
        col22 = transform.GetChild(22).GetComponentInChildren<Collider2D>();
        col23 = transform.GetChild(23).GetComponentInChildren<Collider2D>();
        col24 = transform.GetChild(24).GetComponentInChildren<Collider2D>();

        //Vertices 

        vertices[0] = new Vector3(-8, -8, 0);
        vertices[1] = new Vector3(-4, -8, 0);
        vertices[2] = new Vector3( 0, -8, 0);
        vertices[3] = new Vector3( 4, -8, 0);
        vertices[4] = new Vector3( 8, -8, 0);
        vertices[5] = new Vector3(-8, -4, 0);
        vertices[6] = new Vector3(-4, -4, 0);
        vertices[7] = new Vector3(-0, -4, 0);
        vertices[8] = new Vector3( 4, -4, 0);
        vertices[9] = new Vector3( 8, -4, 0);
        vertices[10] = new Vector3(-8, 0, 0);
        vertices[11] = new Vector3(-4, 0, 0);
        vertices[12] = new Vector3( 0, 0, 0);
        vertices[13] = new Vector3( 4, 0, 0);
        vertices[14] = new Vector3( 8, 0, 0);
        vertices[15] = new Vector3(-8, 4, 0);
        vertices[16] = new Vector3(-4, 4, 0);
        vertices[17] = new Vector3( 0, 4, 0);
        vertices[18] = new Vector3( 4, 4, 0);
        vertices[19] = new Vector3( 8, 4, 0);
        vertices[20] = new Vector3(-8, 8, 0);
        vertices[21] = new Vector3(-4, 8, 0);
        vertices[22] = new Vector3( 0, 8, 0);
        vertices[23] = new Vector3( 4, 8, 0);
        vertices[24] = new Vector3( 8, 8, 0);

        //indices

        int[] triangles = new int[96]{
            0,5,6,
            0,6,1,
            1,6,2,
            2,6,7,
            2,7,8,
            2,8,3,
            3,8,4,
            4,8,9,

            5,10,6,
            6,10,11,
            6,11,12,
            6,12,7,
            7,12,8,
            8,12,13,
            8,13,14,
            8,14,9,

            10,15,16,
            10,16,11,
            11,16,12,
            12,16,17,
            12,17,18,
            12,18,13,
            13,18,14,
            14,18,19,

            15,20,16,
            16,20,21,
            16,21,22,
            16,22,17,
            17,22,18,
            18,22,23,
            18,23,24,
            18,24,19

        };

        for (int i = 0; i < 25; i++)
        {
            Vector3 vertices1 = vertices[i];
        }
        //Vector3 vertices1 = vertices[0];

        Vector2[] uv = new Vector2[25]{
            
            new Vector2(-8,-8), 
            new Vector2(-4,-8),
            new Vector2( 0,-8),
            new Vector2( 4,-8),
            new Vector2( 8,-8),
            new Vector2(-8,-4),
            new Vector2(-4,-4),
            new Vector2( 0,-4),
            new Vector2( 4,-4),
            new Vector2( 8,-4),
            new Vector2(-8, 0),
            new Vector2(-4, 0),
            new Vector2( 0, 0),
            new Vector2( 4, 0),
            new Vector2( 8, 0),
            new Vector2(-8, 4),
            new Vector2(-4, 4),
            new Vector2( 0, 4),
            new Vector2( 4, 4),
            new Vector2( 8, 4),
            new Vector2(-8, 8),
            new Vector2(-4, 8),
            new Vector2( 0, 8),
            new Vector2( 4, 8),
            new Vector2( 8, 8)

        };


        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mesh.RecalculateNormals();

    }
    // Update is called once per frame
    void Update()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;
        
        
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector3 touchPos = new Vector3(wp.x, wp.y, 0.0f);
            

            //Debug.Log(Screen.height);
            //Debug.Log(Screen.width);
            //Debug.Log(touchPos);
            //Köşe Noktaları
            if (col0 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col0.name);
                vertices[0] = touchPos;
                vertices[2] = (touchPos - vertices1[0]);
                vertices[3] = (touchPos - vertices1[0]);
                vertices[6] = (touchPos - vertices1[0]);
                vertices[7] = (touchPos - vertices1[0]);
                vertices[10] = (touchPos - vertices1[0]);
                vertices[11] = (touchPos - vertices1[0]);
                vertices[15] = (touchPos - vertices1[0]);               
                mesh.vertices = vertices;
                col0.offset = touchPos;
            }
            else if (col4 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col4.name);
                vertices[4] = touchPos;
                vertices[1] = (touchPos - vertices1[4]);
                vertices[2] = (touchPos - vertices1[4]);
                vertices[7] = (touchPos - vertices1[4]);
                vertices[8] = (touchPos - vertices1[4]);
                vertices[13] = (touchPos - vertices1[4]);
                vertices[14] = (touchPos - vertices1[4]);
                vertices[19] = (touchPos - vertices1[4]);
                mesh.vertices = vertices;
                col4.offset = touchPos;
            }
            else if (col20 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col20.name);
                vertices[20] = touchPos;
                vertices[5] = (touchPos - vertices1[20]);
                vertices[10] = (touchPos - vertices1[20]);
                vertices[11] = (touchPos - vertices1[20]);
                vertices[16] = (touchPos - vertices1[20]);
                vertices[17] = (touchPos - vertices1[20]);
                vertices[22] = (touchPos - vertices1[20]);
                vertices[23] = (touchPos - vertices1[20]);
                mesh.vertices = vertices;
                col20.offset = touchPos;
            }
            else if (col24 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col24.name);
                vertices[24] = touchPos;
                vertices[9] = (touchPos - vertices1[20]);
                vertices[14] = (touchPos - vertices1[20]);
                vertices[13] = (touchPos - vertices1[20]);
                vertices[18] = (touchPos - vertices1[20]);
                vertices[17] = (touchPos - vertices1[20]);
                vertices[22] = (touchPos - vertices1[20]);
                vertices[21] = (touchPos - vertices1[20]);
                mesh.vertices = vertices;
                col24.offset = touchPos;
            }
            else if (col5 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col5.name);
                vertices[5] = touchPos;
                vertices[10] = (touchPos - vertices1[5]);
                vertices[15] = (touchPos - vertices1[5]);
                vertices[6] = (touchPos - vertices1[5]);
                vertices[16] = (touchPos - vertices1[5]);
                vertices[11] = (touchPos - vertices1[5]);               
                mesh.vertices = vertices;
                col5.offset = touchPos;
            }
            else if (col15 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col15.name);
                vertices[15] = touchPos;
                vertices[10] = (touchPos - vertices1[15]);
                vertices[5] = (touchPos - vertices1[15]);
                vertices[6] = (touchPos - vertices1[15]);
                vertices[16] = (touchPos - vertices1[15]);
                vertices[11] = (touchPos - vertices1[15]);
                mesh.vertices = vertices;
                col15.offset = touchPos;
            }
            else if (col21 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col21.name);
                vertices[21] = touchPos;
                vertices[22] = (touchPos - vertices1[21]);
                vertices[23] = (touchPos - vertices1[21]);
                vertices[16] = (touchPos - vertices1[21]);
                vertices[17] = (touchPos - vertices1[21]);
                vertices[18] = (touchPos - vertices1[21]);
                mesh.vertices = vertices;
                col21.offset = touchPos;
            }
            else if (col23 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col23.name);
                vertices[23] = touchPos;
                vertices[22] = (touchPos - vertices1[23]);
                vertices[21] = (touchPos - vertices1[23]);
                vertices[16] = (touchPos - vertices1[23]);
                vertices[17] = (touchPos - vertices1[23]);
                vertices[18] = (touchPos - vertices1[23]);
                mesh.vertices = vertices;
                col23.offset = touchPos;
            }
            else if (col19 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col19.name);
                vertices[19] = touchPos;
                vertices[14] = (touchPos - vertices1[19]);
                vertices[9] = (touchPos - vertices1[19]);
                vertices[8] = (touchPos - vertices1[19]);
                vertices[13] = (touchPos - vertices1[19]);
                vertices[18] = (touchPos - vertices1[19]);
                mesh.vertices = vertices;
                col19.offset = touchPos;
            }
            else if (col9 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col9.name);
                vertices[9] = touchPos;
                vertices[14] = (touchPos - vertices1[9]);
                vertices[19] = (touchPos - vertices1[9]);
                vertices[18] = (touchPos - vertices1[9]);
                vertices[13] = (touchPos - vertices1[9]);
                vertices[8] = (touchPos - vertices1[9]);
                mesh.vertices = vertices;
                col9.offset = touchPos;
            }
            else if (col3 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col3.name);
                vertices[3] = touchPos;
                vertices[2] = (touchPos - vertices1[3]);
                vertices[1] = (touchPos - vertices1[3]);
                vertices[6] = (touchPos - vertices1[3]);
                vertices[7] = (touchPos - vertices1[3]);
                vertices[8] = (touchPos - vertices1[3]);
                mesh.vertices = vertices;
                col3.offset = touchPos;
            }
            else if (col1 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col1.name);
                vertices[1] = touchPos;
                vertices[2] = (touchPos - vertices1[1]);
                vertices[3] = (touchPos - vertices1[1]);
                vertices[8] = (touchPos - vertices1[1]);
                vertices[7] = (touchPos - vertices1[1]);
                vertices[6] = (touchPos - vertices1[1]);
                mesh.vertices = vertices;
                col1.offset = touchPos;                
            }
            else if (col10 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col10.name);
                vertices[10] = touchPos;
                vertices[5] = (touchPos - vertices1[10]);
                vertices[15] = (touchPos - vertices1[10]);
                vertices[16] = (touchPos - vertices1[10]);
                vertices[11] = (touchPos - vertices1[10]);
                vertices[6] = (touchPos - vertices1[10]);
                mesh.vertices = vertices;
                col10.offset = touchPos;
            }
            else if (col22 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col22.name);
                vertices[22] = touchPos;
                vertices[21] = (touchPos - vertices1[22]);
                vertices[23] = (touchPos - vertices1[22]);
                vertices[18] = (touchPos - vertices1[22]);
                vertices[17] = (touchPos - vertices1[22]);
                vertices[16] = (touchPos - vertices1[22]);
                mesh.vertices = vertices;
                col22.offset = touchPos;
            }
            else if (col14 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col14.name);
                vertices[14] = touchPos;
                vertices[9] = (touchPos - vertices1[14]);
                vertices[19] = (touchPos - vertices1[14]);
                vertices[18] = (touchPos - vertices1[14]);
                vertices[13] = (touchPos - vertices1[14]);
                vertices[8] = (touchPos - vertices1[14]);
                mesh.vertices = vertices;
                col14.offset = touchPos;
            }
            else if (col2 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col2.name);
                vertices[2] = touchPos;
                vertices[1] = (touchPos - vertices1[2]);
                vertices[3] = (touchPos - vertices1[2]);
                vertices[8] = (touchPos - vertices1[2]);
                vertices[7] = (touchPos - vertices1[2]);
                vertices[6] = (touchPos - vertices1[2]);
                mesh.vertices = vertices;
                col2.offset = touchPos;
            }
            else if (col12 == Physics2D.OverlapPoint(touchPos)) // Orta Nokta
            {
                Debug.Log(col12.name);
                vertices[12] = touchPos;
                vertices[16] = (touchPos - vertices1[12]);
                vertices[17] = (touchPos - vertices1[12]);
                vertices[18] = (touchPos - vertices1[12]);
                vertices[13] = (touchPos - vertices1[12]);
                vertices[11] = (touchPos - vertices1[12]);
                vertices[6] = (touchPos - vertices1[12]);
                vertices[7] = (touchPos - vertices1[12]);
                vertices[8] = (touchPos - vertices1[12]);
                mesh.vertices = vertices;
                col12.offset = touchPos;
            }
            else if (col6 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col6.name);
                vertices[6] = touchPos;                
                vertices[11] = (touchPos - vertices1[6]);
                vertices[7] = (touchPos - vertices1[6]);
                mesh.vertices = vertices;
                col6.offset = touchPos;
            }
            else if (col16 == Physics2D.OverlapPoint(touchPos)) 
            {
                Debug.Log(col16.name);
                vertices[16] = touchPos;
                vertices[17] = (touchPos - vertices1[16]);
                vertices[11] = (touchPos - vertices1[16]);
                mesh.vertices = vertices;
                col16.offset = touchPos;
            }
            else if (col18 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col18.name);
                vertices[18] = touchPos;
                vertices[17] = (touchPos - vertices1[18]);
                vertices[13] = (touchPos - vertices1[18]);
                mesh.vertices = vertices;
                col18.offset = touchPos;
            }
            else if (col8 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col8.name);
                vertices[8] = touchPos;
                vertices[7] = (touchPos - vertices1[8]);
                vertices[13] = (touchPos - vertices1[8]);
                mesh.vertices = vertices;
                col8.offset = touchPos;
            }
            else if (col11 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col11.name);
                vertices[11] = touchPos;
                vertices[6] = (touchPos - vertices1[11]);
                vertices[16] = (touchPos - vertices1[11]);
                mesh.vertices = vertices;
                col11.offset = touchPos;
            }
            else if (col17 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col17.name);
                vertices[17] = touchPos;
                vertices[16] = (touchPos - vertices1[17]);
                vertices[18] = (touchPos - vertices1[17]);
                mesh.vertices = vertices;
                col17.offset = touchPos;
            }
            else if (col13 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col13.name);
                vertices[13] = touchPos;
                vertices[18] = (touchPos - vertices1[13]);
                vertices[8] = (touchPos - vertices1[13]);
                mesh.vertices = vertices;
                col13.offset = touchPos;
            }
            else if (col7 == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log(col7.name);
                vertices[7] = touchPos;
                vertices[8] = (touchPos - vertices1[7]);
                vertices[6] = (touchPos - vertices1[7]);
                mesh.vertices = vertices;
                col7.offset = touchPos;
            }
            

        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            col0.offset = new Vector2(-8, -8);
            col1.offset = new Vector2(-4, -8);
            col2.offset = new Vector2(-0, -8);
            col3.offset = new Vector2( 4, -8);
            col4.offset = new Vector2( 8, -8);
            col5.offset = new Vector2(-8, -4);
            col6.offset = new Vector2(-4, -4);
            col7.offset = new Vector2(-0, -4);
            col8.offset = new Vector2( 4, -4);
            col9.offset = new Vector2( 8, -4);
            col10.offset = new Vector2(-8,  0);
            col11.offset = new Vector2(-4,  0);
            col12.offset = new Vector2( 0,  0);
            col13.offset = new Vector2( 4,  0);
            col14.offset = new Vector2( 8,  0);
            col15.offset = new Vector2(-8,  4);
            col16.offset = new Vector2(-4,  4);
            col17.offset = new Vector2( 0,  4);
            col18.offset = new Vector2( 4,  4);
            col19.offset = new Vector2( 8,  4);
            col20.offset = new Vector2(-8,  8);
            col21.offset = new Vector2(-4,  8);
            col22.offset = new Vector2( 0,  8);
            col23.offset = new Vector2( 4,  8);
            col24.offset = new Vector2( 8,  8);

            Start();            
        }
    }
}
