using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerGen : MonoBehaviour
{
    [ContextMenuItem("gen cubes", "PassCubeGen")]
    public float Spacing;
    public int row, column;
    public List<GameObject> Kostki= new List<GameObject>();
    public static List<GameObject> kostkistatic = new List<GameObject>();
    public List<Color> KoloriKostek = new List<Color>();
    [SerializeField] GameObject mesh;
    public delegate void PoGeneracji();
    public static event PoGeneracji Generated;
    void Start()
    {
        GenerateCube(transform.position,row,column,Spacing);
    }
    void PassCubeGen()
    {
        GenerateCube(transform.position, row, column, Spacing);
    }
    private void OnEnable()
    {
        TimerStateManager.PoSkonczeniuOffTury +=GenNewColorCubes;
        TimerStateManager.PoSkonczeniuTury +=ChangeColorAllWhite;
    }
    private void OnDisable()
    {
        TimerStateManager.PoSkonczeniuOffTury -= GenNewColorCubes;
        TimerStateManager.PoSkonczeniuTury -= ChangeColorAllWhite;
    }
   
    void GenerateCube(Vector3 pos,int row, int column, float space)
    {
        Kostki = new List<GameObject>();
        Vector3 currPos = pos;
        for(int i=0; i < row; i++)
        {
            for(int a = 0; a < column; a++)
            {
                GameObject cube =Instantiate(mesh, currPos, Quaternion.identity,transform);
                Kostki.Add(cube);
                currPos += new Vector3(0, 0,space);
            }
            
            currPos += new Vector3(space, 0,-(space*column));

        }
        Debug.Log("kostki dlugosc" + Kostki.Count);
        kostkistatic = Kostki;
        GenNewColorCubes();
    }
    public bool ArrayContains(Color col)
    {
        foreach(Color cl in KoloriKostek)
        {
            if (cl == col) { return true; }
        }
        return false;
    }
    public static void ChangeColorCorrect(Color col)
    {
        
        foreach(GameObject cubes in kostkistatic)
        {
            if (cubes.GetComponent<CubeScript>().CubeColor == col)
            {
                LeanTween.color(cubes, col, 0.2f);
                
            }
        }
    }
    void ChangeColorAllWhite()
    {
        foreach(GameObject cube in Kostki)
        {
            LeanTween.color(cube, Color.white, 0.5f).setEaseInBounce();
        }
    }
    void GenNewColorCubes()
    {
        KoloriKostek = new List<Color>();
        foreach (GameObject cube in Kostki)
        {
            Color newCo = RandomColorPicker.GenColor();
            LeanTween.color(cube, newCo, 1).setEaseOutBounce();
            cube.GetComponent<CubeScript>().CubeColor = newCo;
            KoloriKostek.Add(newCo);
        }
     
        Debug.Log(KoloriKostek);
        Generated?.Invoke();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position+new Vector3(transform.position.x*0.25f, 0,transform.position.z * 0.5f), new Vector3((1+Spacing)*row,0, (1 + Spacing) * column));
    }
}
