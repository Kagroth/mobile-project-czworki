using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardModel : MonoBehaviour {

    public int columns;
    public int rows;
    public int[] boardData;
    public int coverage;

    public Manager manager;

    // aktualizacja stanu planszy
    public Vector2Int UpdateModel(int columnNumber, int value)
    {
        for(int x = rows - 1; x >= 0; x--)
        {
            int pos = manager.TwoDimensionToOneDimension(columns, x, columnNumber);

            if (boardData[pos] == 0)
            {
                boardData[pos] = value;
                coverage++;
                return new Vector2Int(x, columnNumber);
            }
        }

        return new Vector2Int(-1, -1);
    }

    public void PopFromColumn(int col)
    {
        for(int row = 0; row < rows; row++)
        {
            int pos = manager.TwoDimensionToOneDimension(columns, row, col);

            Debug.Log(pos);

            if (boardData[pos] != 0)
            {
                boardData[pos] = 0;
                coverage--;
                return;
            }
        }
    }

    // resetowanie planszy
    public void ClearModel()
    {
        for(int x = 0; x < boardData.Length; x++)
        {
            boardData[x] = 0;
        }

        coverage = 0;
    }

    // sprawdzanie warunku zwycięstwa dla konkretnej wartości
    public bool CheckWinCondition(int value)
    {
        // horyzontalnie
        for(int col = 0; col < columns - 3; col++)
        {
            for(int row = 0; row < rows; row++)
            {
                if(boardData[manager.TwoDimensionToOneDimension(columns, row, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row, col + 1)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row, col + 2)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row, col + 3)] == value)
                {
                    return true;
                }
            }
        }

        // wertykalnie
        for(int col = 0; col < columns; col++)
        {
            for(int row = 0; row < rows - 3; row++)
            {
                if(boardData[manager.TwoDimensionToOneDimension(columns, row, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 1, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 2, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 3, col)] == value)
                {
                    return true;
                }
            }
        }

        // na skos w prawo-dol
        for(int col = 0; col < columns - 3; col++)
        {
            for(int row = 0; row < rows - 3; row++)
            {
                if(boardData[manager.TwoDimensionToOneDimension(columns, row, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 1, col + 1)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 2, col + 2)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 3, col + 3)] == value)
                {
                    return true;
                }
            }
        }

        // na skos w lewo-dol
        for (int col = 3; col < columns; col++)
        {
            for (int row = 0; row < rows - 3; row++)
            {
                if (boardData[manager.TwoDimensionToOneDimension(columns, row, col)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 1, col - 1)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 2, col - 2)] == value &&
                    boardData[manager.TwoDimensionToOneDimension(columns, row + 3, col - 3)] == value)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
