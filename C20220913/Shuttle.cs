using System;

public class Shuttle
{
	public string MsCode;
	public DateTime Launch;
	public string Name;
	public int HoursAway, MinutesAway;
	public string Base;
	public int Crew;
	public Shuttle(string[] line)
	{
		this.MsCode = line[0];
		this.Launch = Convert.ToDateTime(line[1]);
		this.Name = line[2];
		this.HoursAway = Convert.ToInt32(line[3]);
		this.MinutesAway = Convert.ToInt32(line[4]);
		this.Base = line[5];
		this.Crew = Convert.ToInt32(line[6]);
	}
}
