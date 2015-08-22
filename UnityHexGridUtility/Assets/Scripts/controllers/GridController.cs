using UnityEngine;
using System.Collections;

public class GridController : MonoBehaviour, IGridController {

	[SerializeField]
	private GridOrientation orientation;
	
	
	[SerializeField]
	private GridLayout layout;

	protected IGridObject[] directions;
	protected IGridObject[] diagonals;

	public GridOrientation Orientation
	{
		get{
			return orientation;
		}
	}
	
	public GridLayout Layout
	{
		get{
			return layout;
		}
	}

	void Start()
	{
		
	}

	public virtual IGridObject GetNeighbor( IGridObject a, int direction )
	{
		return null;
	}

	public virtual IGridObject GetDiagonalNeighbor( IGridObject a, int direction )
	{
		return null;
	}

}
