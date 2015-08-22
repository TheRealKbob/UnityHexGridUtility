using UnityEngine;
using System.Collections;

public class GridController : MonoBehaviour, IGridController {

	[SerializeField]
	private GridOrientation orientation;
	
	
	[SerializeField]
	private GridLayout layout;

	void Start()
	{

	}

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

}
