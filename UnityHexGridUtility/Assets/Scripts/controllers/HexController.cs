using UnityEngine;
using System.Collections;

public class HexController : GridController {
	
	// Use this for initialization
	void Start () 
	{

		directions = new IGridObject[]{
			 new Hex( 1, -1, 0 ), new Hex( 1, 0, -1 ), new Hex( 0, 1, -1 ),
			 new Hex( -1, 1, 0 ), new Hex( -1, 0, 1 ), new Hex( 0, -1, 1 )
		};

		diagonals = new IGridObject[]{
			new Hex( 2, -1, -1 ), new Hex( 1, 1, -2 ), new Hex( -1, 2, -1 ),
			new Hex( -2, 1, 1 ), new Hex( -1, -1, 2 ), new Hex( 1, -2, 1 )
		};

	}

	public override IGridObject GetNeighbor( IGridObject a, int direction )
	{
		return HexUtilities.Add( a as Hex, directions[direction] as Hex );
	}

	public override IGridObject GetDiagonalNeighbor( IGridObject a, int direction )
	{
		return HexUtilities.Add( a as Hex, diagonals[direction] as Hex );
	}

}
