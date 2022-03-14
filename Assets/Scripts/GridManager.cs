using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridManager : MonoBehaviour
{
    private int _row = 8;
    private int _colum = 8;
    private int i = 0;
    [SerializeField]  private GameObject _bluePrefab;
   [SerializeField] private GameObject _pinkPrefab;
    public GameObject[,] _grid;

    //public List<GameObject> BirdTxt = new List<GameObject>();
     public List<string> BirdsName = new List<string>();
     public Dictionary<string,GameObject> _text = new Dictionary<string,GameObject>();
    public GameObject _birdtText;
    private void Start()
    {
        AssignBlock();
        StartCoroutine(GenerateGrid());
    }

    private void AssignBlock()
    {
        _grid = new GameObject[_row, _colum];

        for (int row = 0; row < _row; row++)
        {
            for (int col = 0; col < _colum; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    _grid[row, col] = Instantiate(_bluePrefab);
                }
                else
                {
                    _grid[row, col] = Instantiate(_pinkPrefab);
                }
            }
        }
    }

    IEnumerator GenerateGrid()
    {
        for (int row = 0; row < _row; row++)
        {
            for (int col = 0; col < _colum; col++)
            {

                if ((row + col) % 2 == 0)
                {
                    Instantiate(_grid[row, col], new Vector3(row, 0, col), Quaternion.identity);

                    _text.Add(BirdsName[i], Instantiate(_birdtText, transform.position = new Vector3(col, 0, row), Quaternion.Euler(90, 0, 0)));
                    _text[BirdsName[i]].GetComponent<TextMesh>().text = BirdsName[i];
                    i++;
                }
                else
                {
                    Instantiate(_grid[row, col], new Vector3(row, 0, col), Quaternion.identity);

                    _text.Add(BirdsName[i], Instantiate(_birdtText, transform.position = new Vector3(col, 0, row), Quaternion.Euler(90, 0, 0)));
                    _text[BirdsName[i]].GetComponent<TextMesh>().text = BirdsName[i];
                    i++;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
