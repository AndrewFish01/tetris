
using Enum;
using Unity.VisualScripting;

public class Grid
{
    private const int WIDTH = 10;
    private const int HEIGHT = 20;
    
    private readonly int[][] _gridSize = new int[WIDTH][];

    public Grid()
    {
        for (var i = 0; i < WIDTH; i++)
        {
            _gridSize[i] = new int[HEIGHT];
        }
    }

    private void InitGrid()
    {
        ClearGrid();
    }

    private void ClearGrid()
    {
        for (int i = 0; i < WIDTH; i++)
        {
            for (int j = 0; j < HEIGHT; j++)
            {
                _gridSize[i][j] = (int)StatusGridCell.Empty;
            }
        }
    }
}

