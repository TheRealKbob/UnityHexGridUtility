using UnityEngine;
using System.Collections;

public class HexUtilities {

	public static Vector2 CubeToOffset( int x, int z )
	{
		int row = -1, col = -1;

		switch( GridManager.GridController.Layout )
		{
			case GridLayout.EVENCOL:
				col = x;
				row = ( z + ( x + ( x & 1 ) ) / 2 );
				break;

			case GridLayout.ODDCOL:
				col = x;
				row = ( z + ( x - ( x & 1 ) ) / 2 );
				break;

			case GridLayout.EVENROW:
				col = ( x + ( z + ( z & 1 ) ) / 2 );
				row = z;
				break;
				
			case GridLayout.ODDROW:
				col = ( x + ( z - ( z & 1 ) ) / 2 );
				row = z;
				break;
		}

		return new Vector2( col, row );

	}

	public static Vector3 OffsetToCube( int col, int row )
	{
		int x = -1, y = -1, z = -1;

		switch( GridManager.GridController.Layout )
		{
			case GridLayout.EVENCOL:
				x = col;
				z = ( row - ( col + ( col & 1 ) ) / 2 );
				y = -x - z;
				break;
				
			case GridLayout.ODDCOL:
				x = col;
				z = ( row - ( col - ( col & 1 ) ) / 2 );
				y = -x - z;
				break;
				
			case GridLayout.EVENROW:
				x = ( col - ( row + ( row & 1 ) ) / 2 );
				z = row;
				y = -x - z;
				break;
				
			case GridLayout.ODDROW:
				x = ( col - ( row - ( row & 1 ) ) / 2 );
				z = row;
				y = -x - z;
				break;
		}
		
		return new Vector3( x, y, z );

	}

}
