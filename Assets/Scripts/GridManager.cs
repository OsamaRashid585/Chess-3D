using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private int _row = 8;
    private int _colum = 8;
   [SerializeField]  private GameObject _bluePrefab;
   [SerializeField] private GameObject _pinkPrefab;
    public GameObject[,] _grid;

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
                }
                else
                {
                    Instantiate(_grid[row, col], new Vector3(row, 0, col), Quaternion.identity);
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
