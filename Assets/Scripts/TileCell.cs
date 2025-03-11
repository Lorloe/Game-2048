using UnityEngine;

public class TileCell : MonoBehaviour
{
    public Vector2Int coordinates { get; set; }

    // private Tile _tile;
    // public Tile tile
    // {
    //     get => _tile;  // Getter: Lấy giá trị của _tile
    //     set
    //     {
    //         _tile = value; // Gán giá trị mới vào _tile
            
    //         if (_tile == null)
    //         {
    //             Debug.Log($"Tile tại {coordinates} đã bị xóa!");
    //         }
    //         else
    //         {
    //             Debug.Log($"Tile tại {coordinates} đã được cập nhật thành {_tile.number}!");
    //         }
    //     }
    // }
    public Tile tile { get; set; }

    // public bool empty
    // {
    //     get { return tile == null; }
    // }
    // Expression-Bodied
    public bool empty => tile == null;

    // public bool occupied
    // {
    //     get { return tile != null; }
    // }
    // Expression-Bodied
    public bool occupied => tile != null;
}
