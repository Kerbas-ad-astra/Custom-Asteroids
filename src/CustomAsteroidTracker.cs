using System.Collections.Generic;
using System;

namespace Starstrider42.CustomAsteroids
{
	/// <summary>
	/// A ScenarioModule that tracks which asteroids belong to which group, 
	/// </summary>
	/// 
	[KSPScenario(
		ScenarioCreationOptions.AddToAllGames,
		GameScenes.SPACECENTER,
		GameScenes.TRACKSTATION,
		GameScenes.FLIGHT)]
	public class CustomAsteroidTracker : ScenarioModule
	{
		private Dictionary<Guid, AsteroidSet> asteroidDB;

		public CustomAsteroidTracker()
		{

		}

		internal int countAsteroidsInSet(AsteroidSet group)
		{
			int count = 0;
			foreach (KeyValuePair<Guid,AsteroidSet> kvp in asteroidDB)
			{
				if (kvp.Value.Equals(group))
				{
					count++;
				}
			}
			return count;
		}
	}
}
