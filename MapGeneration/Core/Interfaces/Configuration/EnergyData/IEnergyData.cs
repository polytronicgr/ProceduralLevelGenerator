﻿namespace MapGeneration.Core.Interfaces.Configuration.EnergyData
{
	public interface IEnergyData
	{
		float Energy { get; set; }

		int Overlap { get; set; }

		int MoveDistance { get; set; }

		bool IsValid { get; set; }
	}
}